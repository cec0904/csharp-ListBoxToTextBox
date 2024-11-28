
using System;
using System.Data;
using System.Windows.Forms;

namespace ListBoxToTextBox
{
    /// <summary>
    /// Form1 클래스는 선수 데이터를 관리하며, 이를 기반으로 다른 폼과 상호작용합니다.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// 선수 데이터를 저장하는 DataTable 객체.
        /// </summary>
        private readonly DataTable playerDataTable = new DataTable();

        /// <summary>
        /// Form1 생성자. UI를 초기화하고 데이터 그리드와 콤보박스를 설정합니다.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            InitializeMenu();          // 메뉴 초기화
            InitializeDataGridView();  // 데이터 그리드 초기화
            InitializeComboBoxes();    // 콤보박스 초기화
        }

        /// <summary>
        /// 메뉴를 초기화하고 메뉴 항목에 이벤트 핸들러를 연결합니다.
        /// </summary>
        private void InitializeMenu()
        {
            // MenuStrip 생성
            MenuStrip menuStrip = new MenuStrip();

            // "파일" 메뉴
            ToolStripMenuItem fileMenu = new ToolStripMenuItem("파일");
//            ToolStripMenuItem openMenuItem = new ToolStripMenuItem("열기", null, OnOpenMenuClick);  // "열기" 메뉴 항목
            ToolStripMenuItem exitMenuItem = new ToolStripMenuItem("종료", null, OnExitMenuClick);  // "종료" 메뉴 항목
//            fileMenu.DropDownItems.Add(openMenuItem);
            fileMenu.DropDownItems.Add(exitMenuItem);

            // "도움말" 메뉴
            ToolStripMenuItem helpMenu = new ToolStripMenuItem("도움말");
            ToolStripMenuItem aboutMenuItem = new ToolStripMenuItem("정보", null, OnAboutMenuClick); // "정보" 메뉴 항목
            helpMenu.DropDownItems.Add(aboutMenuItem);

            // 메뉴 항목을 MenuStrip에 추가
            menuStrip.Items.Add(fileMenu);
            menuStrip.Items.Add(helpMenu);

            // MenuStrip을 Form의 최상단에 추가
            this.MainMenuStrip = menuStrip;
            this.Controls.Add(menuStrip);
        }

        ///// <summary>
        ///// "열기" 메뉴 클릭 이벤트 핸들러.
        ///// </summary>
        //private void OnOpenMenuClick(object sender, EventArgs e)
        //{
        //    MessageBox.Show("열기 메뉴를 클릭했습니다.", "열기", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //}

        /// <summary>
        /// "종료" 메뉴 클릭 이벤트 핸들러.
        /// </summary>
        private void OnExitMenuClick(object sender, EventArgs e)
        {
            var result = MessageBox.Show("프로그램을 종료하시겠습니까?", "종료 확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close(); // 폼 종료
            }
        }

        /// <summary>
        /// "정보" 메뉴 클릭 이벤트 핸들러.
        /// </summary>
        private void OnAboutMenuClick(object sender, EventArgs e)
        {
            MessageBox.Show("이 프로그램은 선수 데이터를 관리하고 차트를 표시합니다.\n© 2024 대림대", "프로그램 정보", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// 데이터 그리드 뷰를 초기화하고 열 이름을 설정합니다.
        /// </summary>
        private void InitializeDataGridView()
        {
            // 데이터 테이블 열 정의
            playerDataTable.Columns.Add("이름");  // 선수 이름
            playerDataTable.Columns.Add("공격"); // 공격 점수
            playerDataTable.Columns.Add("수비"); // 수비 점수
            playerDataTable.Columns.Add("패스"); // 패스 점수
            playerDataTable.Columns.Add("슛");  // 슛 점수

            // 데이터 테이블을 데이터 그리드 뷰에 연결
            dataGridView.DataSource = playerDataTable;
        }

        /// <summary>
        /// 각 콤보박스에 점수 값을 추가합니다 (100, 90, 80, 70).
        /// </summary>
        private void InitializeComboBoxes()
        {
            var scores = new[] { 100, 90, 80, 70 }; // 점수 배열

            // 점수를 각 콤보박스에 추가
            foreach (var score in scores)
            {
                intAttack.Items.Add(score);  // 공격 점수 콤보박스
                intDifense.Items.Add(score); // 수비 점수 콤보박스
                intPass.Items.Add(score);    // 패스 점수 콤보박스
                intShot.Items.Add(score);    // 슛 점수 콤보박스
            }
        }

        /// <summary>
        /// Form2를 열고 선택된 데이터를 TextBox에 표시합니다.
        /// </summary>
        private void btnOpenForm2_Click(object sender, EventArgs e)
        {
            using (var form2 = new Form2()) // Form2 생성 및 표시
            {
                if (form2.ShowDialog() == DialogResult.OK) // 확인 버튼이 눌렸을 경우
                {
                    textBox1.Text = string.Join(", ", form2.SelectedItems); // 선택된 데이터 표시
                }
            }
        }

        /// <summary>
        /// 사용자가 입력한 수식을 계산하여 결과를 Label에 표시합니다.
        /// </summary>
        private void btnCalculateFormula_Click(object sender, EventArgs e)
        {
            string formula = txtFormula.Text; // 사용자 입력 수식 가져오기

            try
            {
                // 수식 계산
                var table = new DataTable();
                var result = table.Compute(formula, string.Empty);

                // 계산 결과를 Label에 표시
                lblResult.Text = $"{formula} = {result}";
                txtFormula.Clear(); // 입력 필드 초기화
            }
            catch
            {
                lblResult.Text = "잘못된 수식입니다. 다시 입력하세요."; // 잘못된 수식에 대한 경고 메시지
            }
        }

        /// <summary>
        /// 입력된 데이터를 DataTable에 추가하고 입력 필드를 초기화합니다.
        /// </summary>
        private void btnAddData_Click(object sender, EventArgs e)
        {
            // 데이터 테이블에 새로운 행 추가
            playerDataTable.Rows.Add(
                txtName.Text,       // 선수 이름
                intAttack.Text,     // 공격 점수
                intDifense.Text,    // 수비 점수
                intPass.Text,       // 패스 점수
                intShot.Text        // 슛 점수
            );

            ClearInputFields(); // 입력 필드 초기화
        }

        /// <summary>
        /// TextBox 및 ComboBox 입력값을 초기화합니다.
        /// </summary>
        private void ClearInputFields()
        {
            txtName.Clear();                // 이름 입력 필드 초기화
            intAttack.SelectedIndex = -1;   // 공격 점수 초기화
            intDifense.SelectedIndex = -1;  // 수비 점수 초기화
            intPass.SelectedIndex = -1;     // 패스 점수 초기화
            intShot.SelectedIndex = -1;     // 슛 점수 초기화
        }

        /// <summary>
        /// Form3을 열어 데이터 테이블을 차트로 표시합니다.
        /// </summary>
        private void btnShowChart_Click(object sender, EventArgs e)
        {
            // Form3을 생성하고 DataTable을 전달
            var form3 = new Form3(playerDataTable);
            form3.Show(); // Form3 표시
        }


    }
}