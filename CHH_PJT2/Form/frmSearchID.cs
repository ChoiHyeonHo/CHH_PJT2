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
    public partial class frmSearchID : Form
    {
        public frmSearchID()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //유효성 검사
            if (txtName.Text.Trim().Length < 1 || txtphNum.Text.Trim().Length < 1 || dtpBirth.Value > DateTime.Now || cbJob.SelectedIndex == 0)
            {
                MessageBox.Show("제대로 된 정보 입력이 아닙니다.");
            }
            LogInDB db = new LogInDB();
            //입력 정보가 적합한지 체크
            int result = db.SearchID(txtName.Text, txtphNum.Text, dtpBirth.Value, cbJob.Text);
            db.Dispose();

            if (result < 1)
            {
                MessageBox.Show("회원 정보를 찾을 수 없습니다.");
                return;
            }
            else
            {
                lblResult.Text = db.ResultID(txtName.Text, txtphNum.Text, dtpBirth.Value, cbJob.Text);
            }
        }

        private void frmSearchID_Load(object sender, EventArgs e)
        {
            LogInDB db = new LogInDB();
            DataTable dt = db.Category("Job");
            db.Dispose();

            DataRow dr = dt.NewRow();
            dr["Code"] = "";
            dr["Name"] = "선택";
            dt.Rows.InsertAt(dr, 0);
            dt.AcceptChanges();

            cbJob.DisplayMember = "Name";
            cbJob.ValueMember = "Code";
            cbJob.DataSource = dt;
        }
    }
}
