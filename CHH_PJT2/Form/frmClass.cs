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
    public partial class frmClass : Form
    {
        public frmClass()
        {
            InitializeComponent();
        }

        private void frmClass_Load(object sender, EventArgs e)
        {
            CommonUtil.SetInitGridView(classDataGridView);
            CommonUtil.AddGridTextColumn(classDataGridView, "강의", "lessonCode", 50);                   //index[0]
            CommonUtil.AddGridTextColumn(classDataGridView, "강의명", "lessonName", 80);                     //1
            CommonUtil.AddGridTextColumn(classDataGridView, "클래스", "classDistribution", 60);              //2
            CommonUtil.AddGridTextColumn(classDataGridView, "직원ID", "staffID", 70);                        //3
            CommonUtil.AddGridTextColumn(classDataGridView, "강의 시작일", "lessonStartDate", 100);          //4 
            CommonUtil.AddGridTextColumn(classDataGridView, "강의 종료일", "lessonEndDate", 100);            //5
            CommonUtil.AddGridTextColumn(classDataGridView, "강의 시작시간", "lessonStartTime", 100);        //6
            CommonUtil.AddGridTextColumn(classDataGridView, "강의 종료시간", "lessonEndTime", 100);          //7
            CommonUtil.AddGridTextColumn(classDataGridView, "강의료", "lessonAmount", 100);                  //8
            CommonUtil.AddGridTextColumn(classDataGridView, "특이사항", "lessonNsReport", 10, false);        //9
            this.classDataGridView.Font = new Font("나눔바른고딕", 10, FontStyle.Regular);

            SetData();

            string[] codes = { "LessonType" };
            MemberDB db = new MemberDB();
            DataSet ds = db.GetCommonCode(codes);

            CommonUtil.BindingComboBox(comboBox1, ds.Tables["LessonType"], "Code", "Name");
            SetMemberText st = new SetMemberText(comboBox1.Text);
        }

        private void SetData()
        {
            ClassDB db = new ClassDB();
            DataTable dt = db.LoadMemberData();
            db.Dispose();
            DataView dataView = new DataView(dt);
            classDataGridView.DataSource = dataView;
        }

        private void classDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtLessonCode.Text = classDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtLessonName.Text = classDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbClass.Text = classDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtStaffID.Text = classDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            dtpStartDate.Text = classDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            dtpEndDate.Text = classDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            dtpStartTime.Text = classDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
            dtpEndTime.Text = classDataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtAmount.Text = classDataGridView.Rows[e.RowIndex].Cells[8].Value.ToString();
            txtNsReport.Text = classDataGridView.Rows[e.RowIndex].Cells[9].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ClassDB db = new ClassDB();
            SetClassText st = new SetClassText(txtLessonCode.Text, txtLessonName.Text, cbClass.Text, txtStaffID.Text, dtpStartDate.Value, dtpEndDate.Value, dtpStartTime.Value, dtpEndTime.Value, int.Parse(txtAmount.Text), txtNsReport.Text);
            bool bFlag = db.UpdateClass(st);
            if (bFlag)
            {
                MessageBox.Show("정보 수정이 완료되었습니다.");
                SetData();
            }
            else
            {
                MessageBox.Show("형식을 잘못 입력하였거나 빈 항목이 있습니다.");
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            ClassDB db = new ClassDB();
            SetClassText st = new SetClassText(txtLessonCode.Text, txtLessonName.Text, cbClass.Text, txtStaffID.Text, dtpStartDate.Value, dtpEndDate.Value, dtpStartTime.Value, dtpEndTime.Value, int.Parse(txtAmount.Text), txtNsReport.Text);
            bool bFlag = db.CreateClass(st);
            if (bFlag)
            {
                MessageBox.Show("정보 등록이 완료되었습니다.");
                SetData();
            }
            else
            {
                MessageBox.Show("형식을 잘못 입력하였거나 빈 항목이 있습니다.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ClassDB db = new ClassDB();
            SetClassText st = new SetClassText(txtLessonCode.Text, txtLessonName.Text, cbClass.Text, txtStaffID.Text, dtpStartDate.Value, dtpEndDate.Value, dtpStartTime.Value, dtpEndTime.Value, int.Parse(txtAmount.Text), txtNsReport.Text);
            bool bFlag = db.DeleteClass(st);
            if (bFlag)
            {
                MessageBox.Show("정보 삭제가 완료되었습니다.");
                SetData();
            }
            else
            {
                MessageBox.Show("형식을 잘못 입력하였거나 빈 항목이 있습니다.");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            txtLessonName.Text = txtLessonCode.Text = txtStaffID.Text = txtAmount.Text = txtNsReport.Text = "";
            dtpStartDate.Value = dtpEndDate.Value = dtpStartTime.Value = dtpEndTime.Value = DateTime.Now;
            cbClass.Text = null;
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            ClassDB db = new ClassDB();
            DataTable dt = db.LoadClass(comboBox1.Text);
            db.Dispose();
            DataView dataView = new DataView(dt);
            classDataGridView.DataSource = dataView;
        }
    }
}
