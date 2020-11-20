using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace CHH_PJT2
{
    public partial class frmDetAttendance : Form
    {
        public frmDetAttendance()
        {
            InitializeComponent();

        }
        public frmDetAttendance(AttendanceInfo info)
        {
            InitializeComponent();
            txtName.Text = info.stuName;
            txtCode.Text = info.lessonCode;
            dtpEnteringTime.Value = info.entering;
            dtpEntranceTime.Value = info.entrance;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AttendanceDB db = new AttendanceDB();
            SetAttendanceText st = new SetAttendanceText(dtpEnteringTime.Value, txtName.Text);
            bool bFlag = db.UpdateEnteringTime(st);
            if (bFlag)
            {
                MessageBox.Show("정보 수정이 완료되었습니다.");
            }
            else
            {
                MessageBox.Show("형식을 잘못 입력하였거나 빈 항목이 있습니다.");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            AttendanceDB db = new AttendanceDB();
            SetAttendanceText st = new SetAttendanceText(dtpEntranceTime.Value, txtName.Text, txtRecordContent.Text);
            bool bFlag = db.UpdateEnteranceTime(st);
            if (bFlag)
            {
                MessageBox.Show("정보 수정이 완료되었습니다.");
            }
            else
            {
                MessageBox.Show("형식을 잘못 입력하였거나 빈 항목이 있습니다.");
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            AttendanceDB db = new AttendanceDB();
            SetAttendanceText st = new SetAttendanceText(dtpEnteringTime.Value, dtpEntranceTime.Value, Convert.ToChar(rbtnLatenessY.Text.ToUpper().Trim()), Convert.ToChar(rbtnLeaveY.Text.ToUpper().Trim()), txtRecordContent.Text, txtName.Text);
            bool bFlag = db.UpdateETC(st);            if (bFlag)
            {
                MessageBox.Show("정보 수정이 완료되었습니다.");
            }
            else
            {
                MessageBox.Show("형식을 잘못 입력하였거나 빈 항목이 있습니다.");
            }
        }

        private void frmDetAttendance_Load(object sender, EventArgs e)
        {
            rbtnLatenessN.Checked = true;
            rbtnLeaveN.Checked = true;
        }
    }
}
