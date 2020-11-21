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
    public partial class frmMembership : Form
    {
        public frmMembership()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmSearchRoad frm = new frmSearchRoad();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtPostalCode.Text = frm.ZipCode;
                txtPriAddr.Text = frm.Address1;
                txtDetAddr.Text = frm.Address2;
            }
        }

        private void frmMembership_Load(object sender, EventArgs e)
        {
            string[] codes = { "JOB" };
            MemberDB db = new MemberDB();
            DataSet ds = db.GetCommonCode(codes);

            CommonUtil.BindingComboBox(cboJob, ds.Tables["JOB"], "Code", "Name");
            SetMemberText st = new SetMemberText(cboJob.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MembershipDB db = new MembershipDB();
                SetMembershipText st = new SetMembershipText(txtID.Text, txtPwd.Text, txtName.Text, txtNum.Text, dtpBirth.Value, cboJob.Text, txtPostalCode.Text, txtPriAddr.Text, txtDetAddr.Text);
                bool bFlag = db.CreateMembership(st);
                if (bFlag)
                {
                    MessageBox.Show("가입이 완료되었습니다.");
                }
                else
                {
                    MessageBox.Show("형식을 잘못 입력하였거나 빈 항목이 있습니다.");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
