using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace CHH_PJT2
{
    public partial class frmDetAttendance : Form
    {
        public frmDetAttendance()
        {
            InitializeComponent();

        }

        /// <summary>
        /// info에 담아놓은 내용 TextBox에 전달
        /// </summary>
        /// <param name="info"></param>
        public frmDetAttendance(AttendanceInfo info)
        {
            try
            {
                InitializeComponent();
                txtName.Text = info.stuName;
                txtCode.Text = info.lessonCode;
                dtpEnteringTime.Value = info.entering;
                dtpEntranceTime.Value = info.entrance;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }


        /// <summary>
        /// 출석 이미지 클릭 이벤트
        /// 1. 입실 시간, 이름의 내용을 SetAttendanceText의 st에 담아 DB의 UpdateEnteringTime() 수행
        /// 2. bool 타입의 bFlag로 받아서 true = 정보수정/ false = 수정불가 메세지 출력
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                AttendanceDB db = new AttendanceDB();
                SetAttendanceText st = new SetAttendanceText(dtpEnteringTime.Value, txtName.Text);
                bool bFlag = db.UpdateEnteringTime(st);
                if (bFlag)
                {
                    MessageBox.Show("정보 수정이 완료되었습니다.");
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
        /// 결석 이미지 클릭 이벤트
        /// 1. 퇴실 시간, 이름, 기록사항의 내용을 SetAttendanceText의 st에 담아 DB의 UpdateEnteranceTime() 수행
        /// 2. bool 타입의 bFlag로 받아서 true = 정보수정/ false = 수정불가 메세지 출력
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                AttendanceDB db = new AttendanceDB();
                SetAttendanceText st = new SetAttendanceText(dtpEntranceTime.Value, txtName.Text, txtRecordContent.Text);
                bool bFlag = db.UpdateEnteranceTime(st);
                if (bFlag)
                {
                    MessageBox.Show("정보 수정이 완료되었습니다.");
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
        /// 기타 이미지 클릭 이벤트
        /// 1. 출석시간, 퇴실시간, 지각여부, 조퇴여부, 기록사항, 이름의 내용을 SetAttendanceText의 st에 담아 DB의 UpdateETC() 수행
        /// 2. bool 타입의 bFlag로 받아서 true = 정보수정/ false = 수정불가 메세지 출력
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            try
            {
                AttendanceDB db = new AttendanceDB();
                SetAttendanceText st = new SetAttendanceText(dtpEnteringTime.Value, dtpEntranceTime.Value, Convert.ToChar(rbtnLatenessY.Text.ToUpper().Trim()), Convert.ToChar(rbtnLeaveY.Text.ToUpper().Trim()), txtRecordContent.Text, txtName.Text);
                bool bFlag = db.UpdateETC(st);
                if (bFlag)
                {
                    MessageBox.Show("정보 수정이 완료되었습니다.");
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
        /// DetAttendance폼 로드시 라디오버튼 초기 Checked 상태
        /// 1. 지각No, 조퇴No 에 Checked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDetAttendance_Load(object sender, EventArgs e)
        {
            try
            {
                rbtnLatenessN.Checked = true;
                rbtnLeaveN.Checked = true;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
