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

        /// <summary>
        ///  Class 폼 로드시
        /// 1. DataGridView에 Column 추가
        /// 2. SetData()호출 => LoadClassData() 호출
        /// 3. DB에 있는 LoadClassData()에서 Binding 할 Data 가져오기
        /// 4. ComboBox에 공통코드(LessonType) 추가
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmClass_Load(object sender, EventArgs e)
        {
            try
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
                CommonUtil.BindingComboBox(cbClass, ds.Tables["LessonType"], "Code", "Name");
                SetMemberText st = new SetMemberText(comboBox1.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            
        }


        /// <summary>
        /// 1. DB에 있는 LoadClassData() 호출
        /// 2. DataTable에 담아 DataView로
        /// 3. DataGridView의 DataSource를 Dataview로
        /// </summary>
        private void SetData()
        {
            try
            {
                ClassDB db = new ClassDB();
                DataTable dt = db.LoadClassData();
                db.Dispose();
                DataView dataView = new DataView(dt);
                classDataGridView.DataSource = dataView;

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }


        /// <summary>
        /// 셀 더블클릭 이벤트
        /// 1. 수강코드, 강의명, 반, 직원ID, 시작/종료일, 시작/종료시간, 수강료, 특이사항 등의 정보를 각 TextBox에 출력
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void classDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
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
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        /// <summary>
        /// 수정버튼 클릭 이벤트
        /// 1. DB에 있는 SetClassText Class의 Property들에 TextBox의 내용 담는다.
        /// 2. DB의 UpdateClass 메서드에 SetMemberText st 선언을 담아서 메서드 수행
        /// 3. 결과값 bool타입으로 받아서 true = 수정/ false = 수정불가 메세지 출력
        /// 4. 수정완료시 SetData()를 통해 DataGridView에 변경된 내용 다시 출력
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }


        /// <summary>
        /// 신규 버튼 클릭 이벤트
        /// 1. DB에 있는 SetClassText Class의 Property들에 TextBox의 내용 담는다.
        /// 2. DB의 CreateClass()에 SetMemberText st 선언을 담아서 메서드 수행
        /// 3. 결과값 bool타입으로 받아서 true = 신규저장/ false = 신규저장 불가 메세지 출력
        /// 4. 신규저장시 SetData()를 통해 DataGridView에 변경된 내용 다시 출력
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }


        /// <summary>
        /// 삭제 버튼 클릭 이벤트
        /// 1. DB에 있는 SetClassText Class의 Property들에 TextBox의 내용 담는다.
        /// 2. DB의 DeleteClass()에 SetMemberText st 선언을 담아서 메서드 수행
        /// 3. 결과값 bool타입으로 받아서 true = 삭제 완료 / false = 삭제 불가 메세지 출력
        /// 4. 삭제 완료시 SetData()를 통해 DataGridView에 변경된 내용 다시 출력
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                frmDelete frm = new frmDelete();
                if (frm.ShowDialog() == DialogResult.OK)
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
                else
                {
                    frm.Close();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }


        /// <summary>
        /// 항목 초기화 버튼 클릭 이벤트
        /// 1. TextBox의 내용 빈 문자열("")로 변환
        /// 2. 강의시작/종료일, 강의 시작/종료시간을 오늘날짜로
        /// 3. comboBox의 내용 초기화
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                txtLessonName.Text = txtLessonCode.Text = txtStaffID.Text = txtAmount.Text = txtNsReport.Text = "";
                dtpStartDate.Value = dtpEndDate.Value = dtpStartTime.Value = dtpEndTime.Value = DateTime.Now;
                cbClass.Text = null;
            }
            catch (Exception err)
            {
                throw err;
            }
            
        }

        /// <summary>
        /// 새로고침 버튼 클릭 이벤트
        /// 1. ComboBox1 의 내용을 담아서 DB의 LoadClass() 수행
        /// 2. ComboBox1의 내용을 쿼리문 where절에 담아서 정보 다시 출력
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
