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
        CheckBox headerCheckBox = new CheckBox();

        public class setdata
        {
            public string Name { get; set; }
            public string Code { get; set; }
            public DateTime Entering { get; set; }
            public DateTime Entrance { get; set; }
            public setdata(string Name, string Code, DateTime Entering, DateTime Entrance)
            {
                this.Name = Name;
                this.Code = Code;
                this.Entering = Entering;
                this.Entrance = Entrance;
            }
        }

        public frmAttendance()
        {
            InitializeComponent();

        }
        private void frnAttendance_Load(object sender, EventArgs e)
        {
            DataGridViewCheckBoxColumn col = new DataGridViewCheckBoxColumn();
            col.Name = "chk";
            col.HeaderText = "";
            col.Width = 30;
            AttDataGridView.Columns.Add(col);

            Point headerCellLocation = AttDataGridView.GetCellDisplayRectangle(0, -1, true).Location;
            //헤더부분의 체크박스
            headerCheckBox.Location = new Point(headerCellLocation.X + 8, headerCellLocation.Y + 2);
            headerCheckBox.Size = new Size(18, 18);
            headerCheckBox.BackColor = Color.Transparent;
            headerCheckBox.Click += HeaderCheckBox_Click;
            AttDataGridView.Controls.Add(headerCheckBox); //3

            CommonUtil.SetInitGridView(AttDataGridView);
            CommonUtil.AddGridTextColumn(AttDataGridView, "출결 번호", "attendanceNum", 70, false);       //index[1]
            CommonUtil.AddGridTextColumn(AttDataGridView, "학생ID", "stuID", 65);                         //index[2]
            CommonUtil.AddGridTextColumn(AttDataGridView, "이름", "stuName", 65);                        //3
            CommonUtil.AddGridTextColumn(AttDataGridView, "강의코드", "lessonCode", 70);                 //4
            CommonUtil.AddGridTextColumn(AttDataGridView, "출결날짜", "attendanceDate", 100);            //5
            CommonUtil.AddGridTextColumn(AttDataGridView, "입실 시간", "enteringTime", 100);             //6
            CommonUtil.AddGridTextColumn(AttDataGridView, "퇴실 시간", "entranceTime", 100);             //7
            CommonUtil.AddGridTextColumn(AttDataGridView, "지각 여부", "lateness", 75);                  //8 
            CommonUtil.AddGridTextColumn(AttDataGridView, "결석 여부", "absence", 75);                   //9
            CommonUtil.AddGridTextColumn(AttDataGridView, "조퇴 여부", "early_Leave", 75);               //10
            CommonUtil.AddGridTextColumn(AttDataGridView, "기록사항", "recordContent", 10, false);       //11
            
            this.AttDataGridView.Font = new Font("나눔바른고딕", 10, FontStyle.Regular);

            SetData();
        }

        private void HeaderCheckBox_Click(object sender, EventArgs e) //4
        {
            AttDataGridView.EndEdit(); //현재 cell의 편집모드(포커스가 있을때)를 종료 => Commit

            foreach (DataGridViewRow row in AttDataGridView.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["chk"];
                chk.Value = headerCheckBox.Checked;
                AttDataGridView.SelectAll();
            }
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
            txtID.Text = AttDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtName.Text = AttDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            dtpAttendanceDate.Text = AttDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtLessonCode.Text = AttDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtEnteringTime.Text = AttDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtEntranceTime.Text = AttDataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void 출결변경ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //dgv의 Row가 1개라도 있고, CurrentCell이 Null이 아닐때만
            AttendanceInfo info = new AttendanceInfo();
            info.stuName = txtName.Text;
            info.lessonCode = txtLessonCode.Text;
            info.entering = Convert.ToDateTime(txtEnteringTime.Text);
            info.entrance = Convert.ToDateTime(txtEntranceTime.Text);
            frmDetAttendance frm = new frmDetAttendance(info);
            frm.Size = new Size(404, 408);
            frm.button1.Location = new Point(372, 12);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                SetData();
            }
        }

        private void 결석변경ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AttendanceInfo info = new AttendanceInfo();
            info.stuName = txtName.Text;
            info.lessonCode = txtLessonCode.Text;
            info.entering = Convert.ToDateTime(txtEnteringTime.Text);
            info.entrance = Convert.ToDateTime(txtEntranceTime.Text);
            frmDetAttendance frm = new frmDetAttendance(info);
            frm.panel1.Visible = false;
            frm.panel2.Visible = false;
            frm.lblLate.Visible = false;
            frm.lblLeave.Visible = false;
            frm.groupBox2.Size = new Size(320, 355);
            frm.groupBox2.Location = new Point(409, 47);
            frm.txtRecordContent.Size = new Size(307, 319);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                SetData();
            }
        }

        private void 기타사항ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AttendanceInfo info = new AttendanceInfo();
            info.stuName = txtName.Text;
            info.lessonCode = txtLessonCode.Text;
            info.entering = Convert.ToDateTime(txtEnteringTime.Text);
            info.entrance = Convert.ToDateTime(txtEntranceTime.Text);
            frmDetAttendance frm = new frmDetAttendance(info);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                SetData();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
