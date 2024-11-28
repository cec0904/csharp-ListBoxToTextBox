using System;
using System.Windows.Forms;

namespace ListBoxToTextBox
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnOpenForm2;
        private TextBox textBox1;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnOpenForm2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFormula = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.intShot = new System.Windows.Forms.ComboBox();
            this.intPass = new System.Windows.Forms.ComboBox();
            this.intDifense = new System.Windows.Forms.ComboBox();
            this.intAttack = new System.Windows.Forms.ComboBox();
            this.btnChartView = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnDataAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpenForm2
            // 
            this.btnOpenForm2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnOpenForm2.Location = new System.Drawing.Point(15, 24);
            this.btnOpenForm2.Name = "btnOpenForm2";
            this.btnOpenForm2.Size = new System.Drawing.Size(177, 30);
            this.btnOpenForm2.TabIndex = 0;
            this.btnOpenForm2.Text = "좋아하는 음식은?";
            this.btnOpenForm2.UseVisualStyleBackColor = true;
            this.btnOpenForm2.Click += new System.EventHandler(this.btnOpenForm2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.Location = new System.Drawing.Point(204, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(290, 26);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(3, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "수식을　입력하세요";
            // 
            // txtFormula
            // 
            this.txtFormula.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtFormula.Location = new System.Drawing.Point(204, 70);
            this.txtFormula.MaxLength = 20;
            this.txtFormula.Name = "txtFormula";
            this.txtFormula.Size = new System.Drawing.Size(290, 26);
            this.txtFormula.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(83, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "결과 보기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnCalculateFormula_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblResult.Location = new System.Drawing.Point(200, 114);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(166, 16);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "계산 결과가 없습니다.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.intShot);
            this.groupBox1.Controls.Add(this.intPass);
            this.groupBox1.Controls.Add(this.intDifense);
            this.groupBox1.Controls.Add(this.intAttack);
            this.groupBox1.Controls.Add(this.btnChartView);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.btnDataAdd);
            this.groupBox1.Controls.Add(this.btnOpenForm2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.txtFormula);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.lblResult);
            this.groupBox1.Location = new System.Drawing.Point(15, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(513, 248);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "컴퓨터소프트웨어학과 김기춘";
            // 
            // intShot
            // 
            this.intShot.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.intShot.FormattingEnabled = true;
            this.intShot.Location = new System.Drawing.Point(435, 209);
            this.intShot.Name = "intShot";
            this.intShot.Size = new System.Drawing.Size(57, 24);
            this.intShot.TabIndex = 12;
            // 
            // intPass
            // 
            this.intPass.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.intPass.FormattingEnabled = true;
            this.intPass.Location = new System.Drawing.Point(360, 209);
            this.intPass.Name = "intPass";
            this.intPass.Size = new System.Drawing.Size(57, 24);
            this.intPass.TabIndex = 11;
            // 
            // intDifense
            // 
            this.intDifense.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.intDifense.FormattingEnabled = true;
            this.intDifense.Location = new System.Drawing.Point(284, 209);
            this.intDifense.Name = "intDifense";
            this.intDifense.Size = new System.Drawing.Size(57, 24);
            this.intDifense.TabIndex = 10;
            // 
            // intAttack
            // 
            this.intAttack.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.intAttack.FormattingEnabled = true;
            this.intAttack.Location = new System.Drawing.Point(204, 209);
            this.intAttack.Name = "intAttack";
            this.intAttack.Size = new System.Drawing.Size(57, 24);
            this.intAttack.TabIndex = 9;
            // 
            // btnChartView
            // 
            this.btnChartView.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnChartView.Location = new System.Drawing.Point(204, 148);
            this.btnChartView.Name = "btnChartView";
            this.btnChartView.Size = new System.Drawing.Size(126, 30);
            this.btnChartView.TabIndex = 8;
            this.btnChartView.Text = "챠트 보기";
            this.btnChartView.UseVisualStyleBackColor = true;
            this.btnChartView.Click += new System.EventHandler(this.btnShowChart_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtName.Location = new System.Drawing.Point(99, 209);
            this.txtName.MaxLength = 5;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(93, 26);
            this.txtName.TabIndex = 7;
            // 
            // btnDataAdd
            // 
            this.btnDataAdd.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDataAdd.Location = new System.Drawing.Point(360, 147);
            this.btnDataAdd.Name = "btnDataAdd";
            this.btnDataAdd.Size = new System.Drawing.Size(134, 32);
            this.btnDataAdd.TabIndex = 6;
            this.btnDataAdd.Text = "데이터 추가";
            this.btnDataAdd.UseVisualStyleBackColor = true;
            this.btnDataAdd.Click += new System.EventHandler(this.btnAddData_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(432, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "슛";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(357, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "패스";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(281, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "수비";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(200, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "공격";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(95, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "이름";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView);
            this.panel1.Location = new System.Drawing.Point(12, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 508);
            this.panel1.TabIndex = 7;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(5, 246);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(513, 259);
            this.dataGridView.TabIndex = 7;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(542, 557);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Quiz";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        private Label label1;
        private TextBox txtFormula;
        private ContextMenuStrip contextMenuStrip1;
        private Button button1;
        private BindingSource bindingSource1;
        private Label lblResult;
        private GroupBox groupBox1;
        private Panel panel1;
        private Button btnChartView;
        private TextBox txtName;
        private Button btnDataAdd;
        private Label label2;
        private ContextMenuStrip contextMenuStrip2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox intAttack;
        private ComboBox intDifense;
        private ComboBox intShot;
        private ComboBox intPass;
        private DataGridView dataGridView;
    }
}
