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
    public partial class frmAttendance : Form
    {
        CheckBox headerCheckBox = new CheckBox();

        public class setdata
        {
            public string Name { get; set; }
            public string Code { get; set; }
            public DateTime Entering { get; set; }
            public DateTime Entrance { get; set; }
            public setdata(string Name, string Code, DateTime Entering, DateTime Entrance)
            {
                this.Name = Name;
                this.Code = Code;
                this.Entering = Entering;
                this.Entrance = Entrance;
            }
        }

        public frmAttendance()
        {
            InitializeComponent();
        }


        /// <summary>
        ///  Attendance_Load 폼 로드시
        /// 1. DataGridView에 Column 추가
        /// 2. SetData()호출 => LoadCounselingData() 호출
        /// 3. DB에 있는 LoadCounselingData()에서 Binding 할 Data 가져오기
        /// 4. 공통 코드 가져오는 메서드 GetCommonCode()
        /// 5. BindingComboBox()로 콤보박스에 공통코드 바인딩
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frnAttendance_Load(object sender, EventArgs e)
        {
            try
            {
                DataGridViewCheckBoxColumn col = new DataGridViewCheckBoxColumn();
                col.Name = "chk";
                col.HeaderText = "";
                col.Width = 30;
                AttDataGridView.Columns.Add(col);

                Point headerCellLocation = AttDataGridView.GetCellDisplayRectangle(0, -1, true).Location;
                //헤더부분의 체크박스
                headerCheckBox.Location = new Point(headerCellLocation.X + 8, headerCellLocation.Y + 2);
                headerCheckBox.Size = new Size(18, 18);
                headerCheckBox.BackColor = Color.Transparent;
                headerCheckBox.Click += HeaderCheckBox_Click;
                AttDataGridView.Controls.Add(headerCheckBox); //3

                CommonUtil.SetInitGridView(AttDataGridView);
                CommonUtil.AddGridTextColumn(AttDataGridView, "출결 번호", "attendanceNum", 70, false);       //index[1]
                CommonUtil.AddGridTextColumn(AttDataGridView, "학생ID", "stuID", 65);                         //index[2]
                CommonUtil.AddGridTextColumn(AttDataGridView, "이름", "stuName", 65);                        //3
                CommonUtil.AddGridTextColumn(AttDataGridView, "강의코드", "lessonCode", 70);                 //4
                CommonUtil.AddGridTextColumn(AttDataGridView, "출결날짜", "attendanceDate", 100);            //5
                CommonUtil.AddGridTextColumn(AttDataGridView, "입실 시간", "enteringTime", 100);             //6
                CommonUtil.AddGridTextColumn(AttDataGridView, "퇴실 시간", "entranceTime", 100);             //7
                CommonUtil.AddGridTextColumn(AttDataGridView, "지각 여부", "lateness", 75);                  //8 
                CommonUtil.AddGridTextColumn(AttDataGridView, "결석 여부", "absence", 75);                   //9
                CommonUtil.AddGridTextColumn(AttDataGridView, "조퇴 여부", "early_Leave", 75);               //10
                CommonUtil.AddGridTextColumn(AttDataGridView, "기록사항", "recordContent", 10, false);       //11

                this.AttDataGridView.Font = new Font("나눔바른고딕", 10, FontStyle.Regular);

                SetData();

                string[] codes = { "LessonType" };
                MemberDB db = new MemberDB();
                DataSet ds = db.GetCommonCode(codes);

                CommonUtil.BindingComboBox(comboBox1, ds.Tables["LessonType"], "lessonCode", "Code");
                SetMemberText st = new SetMemberText(comboBox1.Text);
            }
            catch (Exception err)
            {
                throw err;
            }
        }


        /// <summary>
        /// DataGridView 헤더 체크박스 클릭 이벤트 ☆★수정 필요☆★
        /// 1. EndEdit()을 통해 현재 셀의 편집모드 종료(Commit)
        /// 2. foreach를 통해 체크/ 체크해제
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HeaderCheckBox_Click(object sender, EventArgs e)
        {
            try
            {
                AttDataGridView.EndEdit();

                foreach (DataGridViewRow row in AttDataGridView.Rows)
                {
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["chk"];
                    chk.Value = headerCheckBox.Checked;
                    AttDataGridView.SelectAll();
                }
            }
            catch (Exception err)
            {
                throw err;
            }
        }


        /// <summary>
        /// 1. DB에 있는 LoadAttendanceData() 호출
        /// 2. DataTable에 담아 DataView로
        /// 3. DataGridView의 DataSource를 Dataview로
        /// </summary>
        private void SetData()
        {
            try
            {
                AttendanceDB db = new AttendanceDB();
                DataTable dt = db.LoadAttendanceData();
                db.Dispose();
                DataView dataView = new DataView(dt);
                AttDataGridView.DataSource = dataView;
            }
            catch (Exception err)
            {
                throw err;
            }
        }


        /// <summary>
        /// 셀 더블클릭 이벤트
        /// 1. 학생ID, 이름, 출석일, 수강코드, 출석시간, 퇴실시간 정보를 각 TextBox에 출력
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AttDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtID.Text = AttDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtName.Text = AttDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                dtpAttendanceDate.Text = AttDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtLessonCode.Text = AttDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtEnteringTime.Text = AttDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtEntranceTime.Text = AttDataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
            catch (Exception err)
            {
                throw err;
            }
        }


        /// <summary>
        /// ContextMenuStrip - 출결변경 클릭 이벤트
        /// 1. 셀 더블클릭 이벤트를 통해 TextBox에 바인딩한 애용을 AttendanceInfo 타입의 각 info.- 에 담아 저장
        /// 2. DetAttendance 폼에 info를 파라미터로 전달하여 인스턴스 생성
        /// 3. DetAttendance 폼의 사이즈, 위치 지정
        /// 3. DetAttendance 폼 ShowDialog()로 호출, DialogResult가 OK이면 SetData() 호출
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 출결변경ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                //dgv의 Row가 1개라도 있고, CurrentCell이 Null이 아닐때만
                AttendanceInfo info = new AttendanceInfo();
                info.stuName = txtName.Text;
                info.lessonCode = txtLessonCode.Text;
                info.entering = Convert.ToDateTime(txtEnteringTime.Text);
                info.entrance = Convert.ToDateTime(txtEntranceTime.Text);
                frmDetAttendance frm = new frmDetAttendance(info);
                frm.Size = new Size(404, 408);
                frm.button1.Location = new Point(372, 12);

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    SetData();
                }
            }
            catch (Exception err)
            {
                throw err;
            }
        }


        /// <summary>
        /// ContextMenuStrip - 결석변경 클릭 이벤트
        /// 1. 셀 더블클릭 이벤트를 통해 TextBox에 바인딩한 애용을 AttendanceInfo 타입의 각 info.- 에 담아 저장
        /// 2. DetAttendance 폼에 info를 파라미터로 전달하여 인스턴스 생성
        /// 3. DetAttendance 폼의 사이즈, 위치 지정, 특이사항 입력하는 TextBox 사이즈 조정
        /// 3. DetAttendance 폼 ShowDialog()로 호출, DialogResult가 OK이면 SetData() 호출
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 결석변경ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                AttendanceInfo info = new AttendanceInfo();
                info.stuName = txtName.Text;
                info.lessonCode = txtLessonCode.Text;
                info.entering = Convert.ToDateTime(txtEnteringTime.Text);
                info.entrance = Convert.ToDateTime(txtEntranceTime.Text);
                frmDetAttendance frm = new frmDetAttendance(info);
                frm.panel1.Visible = false;
                frm.panel2.Visible = false;
                frm.lblLate.Visible = false;
                frm.lblLeave.Visible = false;
                frm.groupBox2.Size = new Size(320, 355);
                frm.groupBox2.Location = new Point(409, 47);
                frm.txtRecordContent.Size = new Size(307, 319);

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    SetData();
                }
            }
            catch (Exception err)
            {
                throw err;
            }
        }


        /// <summary>
        /// ContextMenuStrip - 기타사항 클릭 이벤트
        /// 1. 셀 더블클릭 이벤트를 통해 TextBox에 바인딩한 애용을 AttendanceInfo 타입의 각 info.- 에 담아 저장
        /// 2. DetAttendance 폼에 info를 파라미터로 전달하여 인스턴스 생성
        /// 3. DetAttendance 폼 ShowDialog()로 호출, DialogResult가 OK이면 SetData() 호출
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 기타사항ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                AttendanceInfo info = new AttendanceInfo();
                info.stuName = txtName.Text;
                info.lessonCode = txtLessonCode.Text;
                info.entering = Convert.ToDateTime(txtEnteringTime.Text);
                info.entrance = Convert.ToDateTime(txtEntranceTime.Text);
                frmDetAttendance frm = new frmDetAttendance(info);

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    SetData();
                }
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //??
        }

        /// <summary>
        /// 새로고침 버튼 클릭 이벤트
        /// 1. ComboBox1 의 내용을 담아서 DB의 LoadLesson() 수행
        /// 2. ComboBox1의 내용을 쿼리문 where절에 담아서 정보 다시 출력
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRenew_Click(object sender, EventArgs e)
        {
            try
            {
                AttendanceDB db = new AttendanceDB();
                DataTable dt = db.LoadLesson(comboBox1.Text);
                db.Dispose();
                DataView dataView = new DataView(dt);
                AttDataGridView.DataSource = dataView;
            }
            catch (Exception err)
            {
                throw err;
            }
        }
    }
}
