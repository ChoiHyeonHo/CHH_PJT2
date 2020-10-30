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
using MySql.Data.MySqlClient;
using MetroFramework.Forms;
using CHH_PJT2.DB;

namespace CHH_PJT2
{
    public partial class frmLogIn : MetroForm
    {
        public frmLogIn()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtID.Focus();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Trim().Length < 1 || txtPwd.Text.Trim().Length < 1)
            {
                MessageBox.Show("제대로 입력해 주세요");
            }
            LogInDB db = new LogInDB();
            LogIn logIn = db.LogIn(txtID.Text.Trim(), txtPwd.Text.Trim());
            db.Dispose();

            if (logIn == null)
            {
                MessageBox.Show("회원 정보가 없습니다. 다시 확인하여 주십시오.");
            }
            else
            {
                if (logIn.ID == "admin")
                {
                    MessageBox.Show($"개발자 로그인");
                    frmMain frm = new frmMain();
                    frm.Show();
                    frm.TopLevel = true;
                }
                else
                {
                    MessageBox.Show($"{logIn.Name}님 환영합니다");
                    frmMain frm = new frmMain();
                    frm.Show();
                    frm.TopLevel = true;
                }
            }
        }
    }
}
