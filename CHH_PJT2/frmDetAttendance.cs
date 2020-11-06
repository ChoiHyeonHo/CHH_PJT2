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

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void frmDetAttendance_Load(object sender, EventArgs e)
        {
            SetAttendanceText st = new SetAttendanceText(dtpEnteringTime.Text, dtpEntranceTime.Text, txtName.Text, int.Parse(txtCode.Text));
            txtName.Text = st.stuName;
            txtCode.Text = st.lessonCode.ToString();
            dtpEnteringTime.Text = st.enteringTime;
            dtpEntranceTime.Text = st.entranceTime;
        }
    }
}
