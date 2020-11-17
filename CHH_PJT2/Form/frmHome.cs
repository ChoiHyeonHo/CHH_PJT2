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

        private void frmHome_Load(object sender, EventArgs e)
        {
            SetRegDate();
            SetAtt();
            //chart2.Series[0].Points.AddXY("출석", 10);
            //chart2.Series[0].Points.AddXY("결석", 5);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetRegDate();
        }

        private void SetRegDate()
        {
            HomeDB db = new HomeDB();
            DataTable dt = db.GetRegDate(cboYear.Text);
            db.Dispose();

            DataView dv = new DataView(dt);
            chart1.Series[0].Points.DataBind(dv, "mm", "stu", "ToolTip=stu");
            chart1.Series[0].ChartType = SeriesChartType.Column;
        }

        private void SetAtt()
        {
            HomeDB db = new HomeDB();
            DataTable dt = db.GetAttendance();
            DataTable dt2 = db.GetAbsence();
            db.Dispose();

            DataView dv = new DataView(dt);
            DataView dv2 = new DataView(dt2);
            chart2.Series[0].Points.DataBind(dv, "absence", "count(stuID)", "ToolTip=count(stuID)");
            chart2.Series[1].Points.DataBind(dv2, "absence", "count(stuID)", "ToolTip=count(stuID)");
            chart2.Series[0].ChartType = SeriesChartType.Line;
            chart2.Series[1].ChartType = SeriesChartType.Line;
            //chart2.ChartAreas[0].AxisX.AxisName
        }
    }
}
