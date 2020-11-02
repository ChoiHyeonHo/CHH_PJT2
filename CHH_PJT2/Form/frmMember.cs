using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinLendingProject;

namespace CHH_PJT2
{
    public partial class frmMember : Form
    {
        public frmMember()
        {
            InitializeComponent();
        }

        private void frmMember_Load(object sender, EventArgs e)
        {
            SetData();
        }

        private void SetData()
        {
            CommonUtil.SetInitGridView(memberDataGridView);
            CommonUtil.AddGridTextColumn(memberDataGridView, "학생ID", "stuID", 100); //index[0]
            CommonUtil.AddGridTextColumn(memberDataGridView, "이름", "stuName", 100); //1
            CommonUtil.AddGridTextColumn(memberDataGridView, "번호", "phNum", 170); //2
            CommonUtil.AddGridTextColumn(memberDataGridView, "학교", "school", 120); //3
            CommonUtil.AddGridTextColumn(memberDataGridView, "학년", "grade", 80); //4 
            CommonUtil.AddGridTextColumn(memberDataGridView, "수강코드", "lessonCode", 170); //5
            CommonUtil.AddGridTextColumn(memberDataGridView, "성별", "stuGender", 100); //6
            CommonUtil.AddGridTextColumn(memberDataGridView, "우편번호", "postalCode", 100);// 7
            CommonUtil.AddGridTextColumn(memberDataGridView, "기본주소", "priAddress", 170);//8
            CommonUtil.AddGridTextColumn(memberDataGridView, "상세주소", "detAddress", 120);//9
            CommonUtil.AddGridTextColumn(memberDataGridView, "생년월일", "birth", 80);//10
            CommonUtil.AddGridTextColumn(memberDataGridView, "수강등록일", "regDate", 170);//11
            CommonUtil.AddGridTextColumn(memberDataGridView, "보호자번호", "pPNum", 170);//12
            CommonUtil.AddGridTextColumn(memberDataGridView, "특이사항", "nsReport", 120);//13
            CommonUtil.AddGridTextColumn(memberDataGridView, "삭제여부", "deleted", 80);//14
            CommonUtil.AddGridTextColumn(memberDataGridView, "선행여부", "antecedent", 170);//15
            CommonUtil.AddGridTextColumn(memberDataGridView, "학생사진", "stuPic", 80);//16
            this.memberDataGridView.Font = new Font("나눔바른고딕", 10, FontStyle.Regular);

            
            MainDB db = new MainDB();
            DataTable dt = db.LoadMemberData();
            db.Dispose();

            DataView dataView = new DataView(dt);
            memberDataGridView.DataSource = dataView;
        }

        private void memberDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            List<string> col = new List<string>();
            col.Add("학생ID");
            col.Add("이름");
            col.Add("번호");
            col.Add("학교");
            col.Add("학년");
            col.Add("수강코드");
            //Id, 이름, 번호, 학교, 학년, 수강코드

            for (int i = 0; i < memberDataGridView.Columns.Count; i++)
            {
                if (!col.Contains(memberDataGridView.Columns[i].HeaderText))
                {
                    memberDataGridView.Columns[i].Visible = false;
                }
            }
        }


        private void frmMember_Activated(object sender, EventArgs e)
        {
            SetData();
        }

        private void memberDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = memberDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = memberDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtNum.Text = memberDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtSchool.Text = memberDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtGrade.Text = memberDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtlessonCode.Text = memberDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            dtpBirth.Text = memberDataGridView.Rows[e.RowIndex].Cells[10].Value.ToString();
            dtpRegDate.Text = memberDataGridView.Rows[e.RowIndex].Cells[11].Value.ToString();
            txtPPNum.Text = memberDataGridView.Rows[e.RowIndex].Cells[12].Value.ToString();
            txtNs.Text = memberDataGridView.Rows[e.RowIndex].Cells[13].Value.ToString();
            txtAntecedent.Text = memberDataGridView.Rows[e.RowIndex].Cells[15].Value.ToString();

            if (memberDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString() == rbtnGenderM.Tag.ToString())
            {
                rbtnGenderM.Checked = true;
            }
            else
            {
                rbtnGenderW.Checked = true;
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MainDB db = new MainDB();
            bool bFlag = db.UpdateMember(txtName.Text, txtNum.Text, txtSchool.Text, txtGrade.Text, dtpBirth.Value, int.Parse(txtlessonCode.Text), dtpRegDate.Value, txtAntecedent.Text, txtPPNum.Text, txtID.Text);

            if (bFlag)
            {
                MessageBox.Show("정보 수정이 완료되었습니다.");
            }
            else
            {
                MessageBox.Show("형식을 잘못 입력하였거나 빈 항목이 있습니다.");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            txtID.Text = txtName.Text = txtNum.Text = txtSchool.Text = txtGrade.Text = txtPostalCode.Text = txtPriAddress.Text = txtDetAddress.Text = txtlessonCode.Text = txtAntecedent.Text = txtPPNum.Text = txtNs.Text = "";

            rbtnGenderM.Checked = rbtnGenderW.Checked = false;

            dtpBirth.Value = dtpRegDate.Value = DateTime.Now;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            MainDB db = new MainDB();
            bool bFlag;
            if (rbtnGenderM.Checked == true)
            {
                bFlag = db.CreateMember(txtID.Text, txtName.Text, rbtnGenderM.Tag.ToString(), txtNum.Text, txtPostalCode.Text, txtPriAddress.Text, txtDetAddress.Text, txtSchool.Text, txtGrade.Text, dtpBirth.Value, int.Parse(txtlessonCode.Text), dtpRegDate.Value, txtPPNum.Text, txtNs.Text, txtAntecedent.Text);
            }
            else
            {
                bFlag = db.CreateMember(txtID.Text, txtName.Text, rbtnGenderW.Tag.ToString(), txtNum.Text, txtPostalCode.Text, txtPriAddress.Text, txtDetAddress.Text, txtSchool.Text, txtGrade.Text, dtpBirth.Value, int.Parse(txtlessonCode.Text), dtpRegDate.Value, txtPPNum.Text, txtNs.Text, txtAntecedent.Text);
            }

            if (bFlag)
            {
                MessageBox.Show("정보 저장이 완료되었습니다.");
            }
            else
            {
                MessageBox.Show("형식을 잘못 입력하였거나 빈 항목이 있습니다.");
            }
        }

        //private void btnRenew_Click(object sender, EventArgs e)
        //{
        //    SetData();
        //}
    }
}
