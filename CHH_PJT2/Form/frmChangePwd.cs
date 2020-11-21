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
    public partial class ChangePwdForm : Form
    {
        public ChangePwdForm()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            LogInDB db = new LogInDB();
            int result = db.CheckPwd(txtName.Text, txtphNum.Text, txtID.Text, cbJob.Text);
            //db.Dispose();

            if (result < 1)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("입력한 정보가 잘못되었거나");
                sb.Append("정보를 찾을 수 없습니다.");
                MessageBox.Show(sb.ToString());
            }
            else
            {
                bool flag = db.ChangePwd(txtName.Text, txtphNum.Text, txtID.Text, cbJob.Text, txtChangePwd.Text);
                if (flag)
                {
                    MessageBox.Show("정보 변경이 완료되었습니다." +
                        "다시 로그인해 주세요.");
                }
                else
                {
                    MessageBox.Show("비밀번호 변경 오류. 다시 시도해 주세요.");
                }
            }
        }
    }
}
