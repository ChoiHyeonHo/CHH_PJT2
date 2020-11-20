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

        /// <summary>
        /// Member 폼 로드시
        /// 1. DataGridView에 Column 추가
        /// 2. SetData()호출 => LoadMemberData() 호출
        /// 3. DB에 있는 LoadMemberData()에서 Binding 할 Data 가져오기
        /// 4. ComboBox에 공통코드(ClassType) 추가
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMember_Load(object sender, EventArgs e)
        {
            try
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
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            
        }


        /// <summary>
        /// 1. DB에 있는 LoadMemberData() 호출
        /// 2. DataTable에 담아 DataView로
        /// 3. DataGridView의 DataSource를 Dataview로
        /// </summary>
        private void SetData()
        {
            try
            {
                MemberDB db = new MemberDB();
                DataTable dt = db.LoadMemberData();
                db.Dispose();
                DataView dataView = new DataView(dt);
                memberDataGridView.DataSource = dataView;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }


        private void frmMember_Activated(object sender, EventArgs e)
        {
            try
            {
                SetData();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }


        /// <summary>
        /// 셀 더블클릭 이벤트
        /// 1. ID, 이름 번호, 학교, 성적, 수강코드, 생일, 등록일, 보호자 번호, 특이사항, 선행학습 정도 등의 정보를 각 TextBox에 출력
        /// 2. 성별에 남/여 한개만 선택
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void memberDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
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
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }


        /// <summary>
        /// 수정버튼 클릭 이벤트
        /// 1. DB에 있는 SetMemberText Class의 Property들에 TextBox의 내용 담는다.
        /// 2. DB의 UpdateMember메서드에 SetMemberText st 선언을 담아서 메서드 수행
        /// 3. 결과값 bool타입으로 받아서 true = 수정/ false = 수정불가 메세지 출력
        /// 4. 수정완료시 SetData()를 통해 DataGridView에 변경된 내용 다시 출력
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
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
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }


        /// <summary>
        /// 항목 초기화 버튼 클릭 이벤트
        /// 1. TextBox의 내용 빈 문자열("")로 변환
        /// 2. 성별을 나타내는 라디오버튼 체크상태 false
        /// 3. 생일, 등록일을 나타내는 DateTimePicker 오늘날짜로 변환
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                txtID.Text = txtName.Text = txtNum.Text = txtSchool.Text = txtGrade.Text = txtPostalCode.Text = txtPriAddress.Text = txtDetAddress.Text = txtlessonCode.Text = txtAntecedent.Text = txtPPNum.Text = txtNs.Text = "";

                rbtnGenderM.Checked = rbtnGenderW.Checked = false;

                dtpBirth.Value = dtpRegDate.Value = DateTime.Now;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }


        /// <summary>
        /// 신규 버튼 클릭 이벤트
        /// 1. DB에 있는 SetMemberText Class의 Property들에 TextBox의 내용 담는다.
        /// 2. DB의 CreateMember()에 SetMemberText st 선언을 담아서 메서드 수행
        /// 3. 결과값 bool타입으로 받아서 true = 신규저장/ false = 신규저장 불가 메세지 출력
        /// 4. 신규저장시 SetData()를 통해 DataGridView에 변경된 내용 다시 출력
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                MemberDB db = new MemberDB();
                SetMemberText st = new SetMemberText(txtID.Text, txtName.Text, rbtnGenderM.Tag.ToString(), txtNum.Text, txtPostalCode.Text, txtPriAddress.Text, txtDetAddress.Text, txtSchool.Text, txtGrade.Text, dtpBirth.Value, txtlessonCode.Text, dtpRegDate.Value, txtPPNum.Text, txtNs.Text, txtAntecedent.Text);
                bool bFlag;
                bFlag = db.CreateMember(st);

                if (bFlag)
                {
                    MessageBox.Show("신규 저장이 완료되었습니다.");
                    SetData();
                }
                else
                {
                    MessageBox.Show("형식을 잘못 입력하였거나 빈 항목이 있습니다.");
                }
                db.Dispose();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }


        /// <summary>
        /// 삭제 버튼 클릭 이벤트
        /// 1.  DB에 있는 SetMemberText Class의 Property들에 TextBox의 내용 담는다.
        /// 2. DB의 DeleteMember()에 SetMemberText st 선언을 담아서 메서드 수행
        /// 3. 결과값 bool타입으로 받아서 true = 삭제 완료 / false = 삭제 불가 메세지 출력
        /// 4. 삭제 완료시 SetData()를 통해 DataGridView에 변경된 내용 다시 출력
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
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
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
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
            try
            {
                MemberDB db = new MemberDB();
                DataTable dt = db.LoadClass(comboBox1.Text);
                db.Dispose();
                DataView dataView = new DataView(dt);
                memberDataGridView.DataSource = dataView;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
