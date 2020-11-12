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
    public partial class frmMember : Form
    {

        public frmMember()
        {
            InitializeComponent();
        }

        private void frmMember_Load(object sender, EventArgs e)
        {
            CommonUtil.SetInitGridView(memberDataGridView);
            CommonUtil.AddGridTextColumn(memberDataGridView, "학생ID", "stuID", 100);                 //index[0]
            CommonUtil.AddGridTextColumn(memberDataGridView, "이름", "stuName", 100);                 //1
            CommonUtil.AddGridTextColumn(memberDataGridView, "번호", "phNum", 170);                   //2
            CommonUtil.AddGridTextColumn(memberDataGridView, "학교", "school", 120);                  //3
            CommonUtil.AddGridTextColumn(memberDataGridView, "학년", "class", 80);                    //4 
            CommonUtil.AddGridTextColumn(memberDataGridView, "수강코드", "lessonCode", 170);          //5
            CommonUtil.AddGridTextColumn(memberDataGridView, "성별", "stuGender", 10, false);         //6
            CommonUtil.AddGridTextColumn(memberDataGridView, "우편번호", "postalCode", 10, false);    //7
            CommonUtil.AddGridTextColumn(memberDataGridView, "기본주소", "priAddress", 10, false);    //8
            CommonUtil.AddGridTextColumn(memberDataGridView, "상세주소", "detAddress", 10, false);    //9
            CommonUtil.AddGridTextColumn(memberDataGridView, "생년월일", "birth", 10, false);         //10
            CommonUtil.AddGridTextColumn(memberDataGridView, "수강등록일", "regDate", 10, false);     //11
            CommonUtil.AddGridTextColumn(memberDataGridView, "보호자번호", "pPNum", 10, false);       //12
            CommonUtil.AddGridTextColumn(memberDataGridView, "특이사항", "nsReport", 10, false);      //13
            CommonUtil.AddGridTextColumn(memberDataGridView, "삭제여부", "deleted", 10, false);       //14
            CommonUtil.AddGridTextColumn(memberDataGridView, "선행여부", "antecedent", 10, false);    //15
            CommonUtil.AddGridTextColumn(memberDataGridView, "학생사진", "stuPic", 10, false);        //16
            this.memberDataGridView.Font = new Font("나눔바른고딕", 10, FontStyle.Regular);

            SetData();

            string[] codes = { "ClassType" };
            MemberDB db = new MemberDB();
            DataSet ds = db.GetCommonCode(codes);

            CommonUtil.BindingComboBox(comboBox1, ds.Tables["ClassType"], "lessonCode", "Name");
            SetMemberText st = new SetMemberText(comboBox1.Text);
        }

        private void SetData()
        {           
            MemberDB db = new MemberDB();
            DataTable dt = db.LoadMemberData();
            db.Dispose();
            DataView dataView = new DataView(dt);
            memberDataGridView.DataSource = dataView;
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
            MemberDB db = new MemberDB();
            SetMemberText st = new SetMemberText(txtID.Text, txtName.Text, rbtnGenderM.Tag.ToString(), txtNum.Text, txtPostalCode.Text, txtPriAddress.Text, txtDetAddress.Text, txtSchool.Text, txtGrade.Text, dtpBirth.Value, txtlessonCode.Text, dtpRegDate.Value, txtPPNum.Text, txtNs.Text, txtAntecedent.Text);
            bool bFlag;
            bFlag = db.UpdateMember(st);

            if (bFlag)
            {
                MessageBox.Show("정보 수정이 완료되었습니다.");
                SetData();
            }
            else
            {
                MessageBox.Show("형식을 잘못 입력하였거나 빈 항목이 있습니다.");
            }
        } //수정

        private void btnRemove_Click(object sender, EventArgs e)
        {
            txtID.Text = txtName.Text = txtNum.Text = txtSchool.Text = txtGrade.Text = txtPostalCode.Text = txtPriAddress.Text = txtDetAddress.Text = txtlessonCode.Text = txtAntecedent.Text = txtPPNum.Text = txtNs.Text = "";

            rbtnGenderM.Checked = rbtnGenderW.Checked = false;

            dtpBirth.Value = dtpRegDate.Value = DateTime.Now;
        } // 텍스트내용 초기화

        private void btnCreate_Click(object sender, EventArgs e)
        {
            MemberDB db = new MemberDB();
            SetMemberText st = new SetMemberText(txtID.Text, txtName.Text, rbtnGenderM.Tag.ToString(), txtNum.Text, txtPostalCode.Text, txtPriAddress.Text, txtDetAddress.Text, txtSchool.Text, txtGrade.Text, dtpBirth.Value, txtlessonCode.Text, dtpRegDate.Value, txtPPNum.Text, txtNs.Text, txtAntecedent.Text);
            bool bFlag;
            bFlag = db.CreateMember(st);

            if (bFlag)
            {
                MessageBox.Show("정보 저장이 완료되었습니다.");
                SetData();
            }
            else
            {
                MessageBox.Show("형식을 잘못 입력하였거나 빈 항목이 있습니다.");
            }
            db.Dispose();
        } //신규등록
        private void btnDelete_Click(object sender, EventArgs e)
        {
            MemberDB db = new MemberDB();
            SetMemberText st = new SetMemberText(txtID.Text, txtName.Text, rbtnGenderM.Tag.ToString(), txtNum.Text, txtPostalCode.Text, txtPriAddress.Text, txtDetAddress.Text, txtSchool.Text, txtGrade.Text, dtpBirth.Value, txtlessonCode.Text, dtpRegDate.Value, txtPPNum.Text, txtNs.Text, txtAntecedent.Text);
            bool bFlag;
            bFlag = db.DeleteMember(st);

            if (bFlag)
            {
                MessageBox.Show("정보 삭제가 완료되었습니다.");
                SetData();
            }
            else
            {
                MessageBox.Show("형식을 잘못 입력하였거나 빈 항목이 있습니다.");
            }
            db.Dispose();
        } //삭제
        private void btnRenew_Click(object sender, EventArgs e)
        {
            MemberDB db = new MemberDB();
            DataTable dt = db.LoadClass(comboBox1.Text);
            db.Dispose();
            DataView dataView = new DataView(dt);
            memberDataGridView.DataSource = dataView;
        } //새로고침
    }
}
