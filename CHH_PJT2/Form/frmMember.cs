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
            CommonUtil.AddGridTextColumn(memberDataGridView, "학생ID", "stuID", 100);
            CommonUtil.AddGridTextColumn(memberDataGridView, "이름", "stuName", 100);
            CommonUtil.AddGridTextColumn(memberDataGridView, "번호", "phNum", 170);
            CommonUtil.AddGridTextColumn(memberDataGridView, "학교", "school", 120);
            CommonUtil.AddGridTextColumn(memberDataGridView, "학년", "grade", 80);
            CommonUtil.AddGridTextColumn(memberDataGridView, "수강코드", "lessonCode", 170);
            CommonUtil.AddGridTextColumn(memberDataGridView, "성별", "stuGender", 100);
            CommonUtil.AddGridTextColumn(memberDataGridView, "우편번호", "postalCode", 100);
            CommonUtil.AddGridTextColumn(memberDataGridView, "기본주소", "priAddress", 170);
            CommonUtil.AddGridTextColumn(memberDataGridView, "상세주소", "detAddress", 120);
            CommonUtil.AddGridTextColumn(memberDataGridView, "생년월일", "birth", 80);
            CommonUtil.AddGridTextColumn(memberDataGridView, "수강등록일", "regDate", 170);
            CommonUtil.AddGridTextColumn(memberDataGridView, "보호자번호", "pPNum", 170);
            CommonUtil.AddGridTextColumn(memberDataGridView, "특이사항", "nsReport", 120);
            CommonUtil.AddGridTextColumn(memberDataGridView, "삭제여부", "deleted", 80);
            CommonUtil.AddGridTextColumn(memberDataGridView, "선행여부", "antecedent", 170);
            CommonUtil.AddGridTextColumn(memberDataGridView, "학생사진", "stuPic", 80);
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
            txtNum.Text = memberDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtSchool.Text = memberDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtGrade.Text = memberDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtlessonCode.Text = memberDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtBirth.Text = memberDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtID.Text = memberDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtID.Text = memberDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtID.Text = memberDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtID.Text = memberDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtID.Text = memberDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtID.Text = memberDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtID.Text = memberDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtID.Text = memberDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
    }
}
