using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CHH_PJT2
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Home폼이 로드시 월별 등록 학생수, 출/결석 학생수, 출석률% 출력하는 메서드 호출
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmHome_Load(object sender, EventArgs e)
        {
            SetRegDate();
            SetAtt();
            progressBar();
        }

        /// <summary>
        /// 새로고침 버튼 클릭시 ComboBox에 따른 조건으로 다시 출력
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            SetRegDate();
        }

        /// <summary>
        /// 출석률% 새로고침하는 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void refresh_Click(object sender, EventArgs e)
        {
            progressBar();
        }

        /// <summary>
        /// ComboBox에 해당하는 조건으로 월별 등록학생 조회
        /// </summary>
        private void SetRegDate()
        {
            HomeDB db = new HomeDB();
            DataTable dt = db.GetRegDate(cboYear.Text);
            db.Dispose();

            DataView dv = new DataView(dt);
            chart1.Series[0].Points.DataBind(dv, "mm", "stu", "ToolTip=stu");
            chart1.Series[0].ChartType = SeriesChartType.Column;
            chart1.Series[0].Name = "등록 학생수";

        }

        /// <summary>
        /// 출/결석에 대해 각각의 학생수 별로 차트 바인딩
        /// </summary>
        private void SetAtt()
        {
            HomeDB db = new HomeDB();
            DataTable dt = db.GetAbsenceY();
            DataTable dt2 = db.GetAbsenceN();
            db.Dispose();

            DataView dv = new DataView(dt);
            DataView dv2 = new DataView(dt2);
            chart2.Series[0].Points.DataBind(dv, "absence", "count(stuID)", "ToolTip=count(stuID)");
            chart2.Series[1].Points.DataBind(dv2, "absence", "count(stuID)", "ToolTip=count(stuID)");
            chart2.Series[0].ChartType = SeriesChartType.Column;
            chart2.Series[1].ChartType = SeriesChartType.Column;

        }

        /// <summary>
        /// DB에서 DataReader로 읽어온 수치를 프로퍼티에 담아 ProgressBar의 Value, Maximum에 전달하여 출력
        /// </summary>
        private void progressBar()
        {
            HomeDB db = new HomeDB();
            info info = db.SetProgressBarValue();
            db.Dispose();
            circularProgressBar1.Value = info.Att;
            circularProgressBar1.Maximum = info.AllStu;
        }
    }
}
