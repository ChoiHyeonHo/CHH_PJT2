using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CHH_PJT2.DB;
using MetroFramework.Forms;

namespace CHH_PJT2
{
    public partial class frmMain : MetroForm
    {
        public string staffID { get; set; }
        public string staffName { get; set; }
        public string Job { get; set; }

        public static frmHome frmHome;
        public static frmMember frmMember;
        public static frmClass frmClass;
        public static frmAttendance frmAttendance;
        public static frmCounseling frmCounseling;
        public static frmBoard frmBoard;
        public LogIn UserInfo;

        public frmMain()
        {
            InitializeComponent();
        }

        public frmMain(LogIn info)
        {
            InitializeComponent();
            UserInfo = info;
        }

        public static frmHome CreateHomeForm()
        {
            if (frmHome == null)
            {
                frmHome = new frmHome();
            }
            return frmHome;
        }
        public static frmMember CreateMemberForm()
        {
            if (frmMember == null)
            {
                frmMember = new frmMember();
            }
            return frmMember;
        }
        public static frmClass CreateClassForm()
        {
            if (frmClass == null)
            {
                frmClass = new frmClass();
            }
            return frmClass;
        }
        public static frmAttendance CreateAttendanceForm()
        {
            if (frmAttendance == null)
            {
                frmAttendance = new frmAttendance();
            }
            return frmAttendance;
        }
        public static frmCounseling CreateCounselingForm()
        {
            if (frmCounseling == null)
            {
                frmCounseling = new frmCounseling();
            }
            return frmCounseling;
        }
        public static frmBoard CreateBoardForm(Info info)
        {
            if (frmBoard == null)
            {
                frmBoard = new frmBoard(info);
            }
            return frmBoard;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            lblId.Text = UserInfo.ID;
            lblName.Text = UserInfo.Name;
            lblJob.Text = UserInfo.JobClassifyID.ToString();
            CreateHomeForm();
            frmHome.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(frmHome);
            frmHome.Dock = DockStyle.Fill;
            frmHome.Show();

            GetStaffID getStaffID = new GetStaffID();
            getStaffID.staffID = lblId.Text;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            CreateHomeForm();
            frmHome.TopLevel = false;
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(frmHome);
            frmHome.Dock = DockStyle.Fill;
            frmHome.Show();
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            CreateMemberForm();
            frmMember.TopLevel = false;
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(frmMember);
            frmMember.Dock = DockStyle.Fill;
            frmMember.Show();
        }

        private void btnClass_Click(object sender, EventArgs e)
        {
            CreateClassForm();
            frmClass.TopLevel = false;
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(frmClass);
            frmClass.Dock = DockStyle.Fill;
            frmClass.Show();
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            CreateAttendanceForm();
            frmAttendance.TopLevel = false;
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(frmAttendance);
            frmAttendance.Dock = DockStyle.Fill;
            frmAttendance.Show();
        }

        private void btnCounseling_Click(object sender, EventArgs e)
        {
            CreateCounselingForm();
            frmCounseling.TopLevel = false;
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(frmCounseling);
            frmCounseling.Dock = DockStyle.Fill;
            frmCounseling.Show();
        }

        private void btnBoard_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            info.staffID = lblId.Text;
            CreateBoardForm(info);
            frmBoard.TopLevel = false;
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(frmBoard);
            frmBoard.Dock = DockStyle.Fill;
            frmBoard.Show();
        }
    }
}
