using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ListBoxToTextBox
{
    /// <summary>
    /// Form3 클래스는 전달받은 DataTable 데이터를 사용하여 레이더 차트를 생성하고 표시합니다.
    /// </summary>
    public partial class Form3 : Form
    {
        private readonly DataTable _dataTable; // 데이터 테이블

        /// <summary>
        /// Form3의 생성자.
        /// 전달받은 DataTable 데이터를 기반으로 레이더 차트를 초기화합니다.
        /// </summary>
        /// <param name="dataTable">레이더 차트에 표시할 데이터를 포함하는 DataTable 객체.</param>
        public Form3(DataTable dataTable)
        {
            InitializeComponent();
            _dataTable = dataTable; // DataTable 저장
            InitializeRadarChart(); // 레이더 차트 초기화
        }

        /// <summary>
        /// 레이더 차트를 초기화하고 데이터를 설정합니다.
        /// </summary>
        private void InitializeRadarChart()
        {
            // Chart 컨트롤 생성 및 폼에 추가
            Chart radarChart = new Chart
            {
                Dock = DockStyle.Fill // 차트를 폼에 꽉 채움
            };
            this.Controls.Add(radarChart);

            // ChartArea(차트 영역) 설정
            ChartArea chartArea = CreateChartArea();
            radarChart.ChartAreas.Add(chartArea);

            // 범례 설정
            Legend legend = CreateLegend();
            radarChart.Legends.Add(legend);

            // 데이터 테이블의 각 행 데이터를 기반으로 Series 추가
            AddSeriesToChart(radarChart);
        }

        /// <summary>
        /// 차트 영역을 생성하고 반환합니다.
        /// </summary>
        /// <returns>설정된 ChartArea 객체.</returns>
        private ChartArea CreateChartArea()
        {
            ChartArea chartArea = new ChartArea("RadarChartArea")
            {
                // X축 설정 (격자선 제거)
                AxisX = { MajorGrid = { LineWidth = 0 }, Interval = 1 },
                // Y축 설정 (최소값, 최대값, 간격 설정)
                AxisY = {
                    MajorGrid = { LineDashStyle = ChartDashStyle.Dash },
                    Minimum = 60,
                    Maximum = 100,
                    Interval = 10
                }
            };
            return chartArea;
        }

        /// <summary>
        /// 범례를 생성하고 반환합니다.
        /// </summary>
        /// <returns>설정된 Legend 객체.</returns>
        private Legend CreateLegend()
        {
            return new Legend("DefaultLegend")
            {
                Docking = Docking.Top, // 범례를 차트 상단에 위치
                Alignment = StringAlignment.Center // 가운데 정렬
            };
        }

        /// <summary>
        /// DataTable 데이터를 기반으로 Series를 생성하여 차트에 추가합니다.
        /// </summary>
        /// <param name="radarChart">데이터가 추가될 Chart 컨트롤.</param>
        private void AddSeriesToChart(Chart radarChart)
        {
            foreach (DataRow row in _dataTable.Rows)
            {
                // 데이터 행에서 이름 및 각 속성 점수 가져오기
                string playerName = row["이름"].ToString();
                int attack = Convert.ToInt32(row["공격"]);
                int defense = Convert.ToInt32(row["수비"]);
                int pass = Convert.ToInt32(row["패스"]);
                int shot = Convert.ToInt32(row["슛"]);

                // 새로운 Series(데이터 집합) 생성
                Series series = new Series(playerName)
                {
                    ChartType = SeriesChartType.Radar, // 레이더 차트 유형
                    BorderWidth = 2 // 데이터 선 두께
                };

                // 데이터 포인트 추가
                series.Points.AddXY("공격", attack);
                series.Points.AddXY("수비", defense);
                series.Points.AddXY("패스", pass);
                series.Points.AddXY("슛", shot);

                // 차트에 Series 추가
                radarChart.Series.Add(series);
            }
        }
    }
}
