using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHH_PJT2
{
    public partial class frmAttendance : Form
    {

        public frmAttendance()
        {
            InitializeComponent();

        }
        private void frnAttendance_Load(object sender, EventArgs e)
        {
            CommonUtil.SetInitGridView(AttDataGridView);
            CommonUtil.AddGridTextColumn(AttDataGridView, "출결 번호", "attendanceNum", 70, false);       //index[0]
            CommonUtil.AddGridTextColumn(AttDataGridView, "학생ID", "stuID", 65);                         //index[1]
            CommonUtil.AddGridTextColumn(AttDataGridView, "이름", "stuName", 65);                        //2
            CommonUtil.AddGridTextColumn(AttDataGridView, "강의코드", "lessonCode", 70);                 //3
            CommonUtil.AddGridTextColumn(AttDataGridView, "출결날짜", "attendanceDate", 100);            //4
            CommonUtil.AddGridTextColumn(AttDataGridView, "입실 시간", "enteringTime", 100);             //5
            CommonUtil.AddGridTextColumn(AttDataGridView, "퇴실 시간", "entranceTime", 100);             //6
            CommonUtil.AddGridTextColumn(AttDataGridView, "지각 여부", "lateness", 80);                  //7 
            CommonUtil.AddGridTextColumn(AttDataGridView, "결석 여부", "absence", 80);                   //8
            CommonUtil.AddGridTextColumn(AttDataGridView, "조퇴 여부", "early_Leave", 80);               //9
            CommonUtil.AddGridTextColumn(AttDataGridView, "기록사항", "recordContent", 10, false);       //10
            
            this.AttDataGridView.Font = new Font("나눔바른고딕", 10, FontStyle.Regular);

            SetData();
        }
        private void SetData()
        {
            AttendanceDB db = new AttendanceDB();
            DataTable dt = db.LoadAttendanceData();
            db.Dispose();
            DataView dataView = new DataView(dt);
            AttDataGridView.DataSource = dataView;
        }

        private void AttDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = AttDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtName.Text = AttDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            dtpAttendanceDate.Text = AttDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtClass.Text = AttDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtEnteringTime.Text = AttDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtEntranceTime.Text = AttDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void 출결변경ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDetAttendance frm = new frmDetAttendance();
            frm.ShowDialog();
        }
    }
}
