using CHH_PJT2.DB;
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
    public partial class frmBoard : Form
    {
        string staffID; // 게시글 작성시 현재 로그인 정보를 전달하기 위한 변수 생성.

        public frmBoard()
        {
            InitializeComponent();
        }
        public frmBoard(Info info)
        {
            InitializeComponent();
            staffID = info.staffID;
        }

        /// <summary>
        /// Board 폼 로드시
        /// 1. DataGridView에 Column 추가
        /// 2. SetData()호출 => LoadBoardData() 호출
        /// 3. DB에 있는 LoadBoardData()에서 Binding 할 Data 가져오기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmBoard_Load(object sender, EventArgs e)
        {
            try
            {
                CommonUtil.SetInitGridView(BoardDataGridView);
                CommonUtil.AddGridTextColumn(BoardDataGridView, "글 번호", "boardID", 80);                 //index[0]
                CommonUtil.AddGridTextColumn(BoardDataGridView, "제목", "boardName", 230);                 //1
                CommonUtil.AddGridTextColumn(BoardDataGridView, "내용", "boardContent", 170, false);      //2
                CommonUtil.AddGridTextColumn(BoardDataGridView, "작성자", "staffID", 110);                      //3
                CommonUtil.AddGridTextColumn(BoardDataGridView, "작성일", "postingDate", 170);             //4
                CommonUtil.AddGridTextColumn(BoardDataGridView, "수정일", "correctDate", 170);              //5
                this.BoardDataGridView.Font = new Font("나눔바른고딕", 10, FontStyle.Regular);

                SetData();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        /// <summary>
        /// 1. DB에 있는 LoadBoardData() 호출
        /// 2. DataTable에 담아 DataView로
        /// 3. DataGridView의 DataSource를 Dataview로
        /// </summary>
        private void SetData()
        {
            try
            {
                BoardDB db = new BoardDB();
                DataTable dt = db.LoadBoardData();
                db.Dispose();
                DataView dataView = new DataView(dt);
                BoardDataGridView.DataSource = dataView;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }


        /// <summary>
        /// 셀 더블클릭 이벤트
        /// 1. 게시글번호, 게시글 제목, 게시글 내용, 작성자(직원)ID, 작성일, 수정일 등의 정보를 각 TextBox에 출력
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BoardDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblBoardID.Text = BoardDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtBoardName.Text = BoardDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtBoardContent.Text = BoardDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                lblStaffID.Text = BoardDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                lblpostingDate.Text = BoardDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                lblcorrectDate.Text = BoardDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }


        /// <summary>
        /// 게시글 저장 버튼클릭 이벤트. 
        /// 1. 작성자는 전역변수로 두었던 staffID(로그인계정)
        /// 2. 작성일은 현재시간 기준 (yyyy-MM-dd HH:mm:ss) 형식으로 저장
        /// 3. 파라미터 게시글 제목, 내용, 작성일, 작성자, 수정일 => st
        /// 3. DB의 InsertBoard(st) 수행하여 bool타입으로 받아 true/ false
        /// 3. true = 저장완료/ false = 저장불가 메세지 출력
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                BoardDB db = new BoardDB();
                lblStaffID.Text = staffID;
                lblpostingDate.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                SetBoardText st = new SetBoardText(txtBoardName.Text, txtBoardContent.Text, lblpostingDate.Text, lblStaffID.Text, lblcorrectDate.Text);
                bool bFlag;
                bFlag = db.CreateBoard(st);

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
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        /// <summary>
        /// 게시글 수정 버튼클릭 이벤트. 
        /// 1. 작성자는 전역변수로 두었던 staffID(로그인계정)
        /// 2. 수정일은 현재시간 기준 (yyyy-MM-dd HH:mm:ss) 형식으로 저장
        /// 3. 파라미터 게시글 번호, 제목, 내용, 작성일, 작성자, 수정일 => st
        /// 3. DB의 UpdateBoard(st) 수행하여 bool타입으로 받아 true/ false
        /// 3. true = 저장완료/ false = 저장불가 메세지 출력
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                BoardDB db = new BoardDB();
                lblStaffID.Text = staffID;
                lblcorrectDate.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                SetBoardText st = new SetBoardText(int.Parse(lblBoardID.Text), txtBoardName.Text, txtBoardContent.Text, lblpostingDate.Text, lblStaffID.Text, lblcorrectDate.Text);
                bool bFlag;
                bFlag = db.UpdateBoard(st);

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
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        /// <summary>
        /// 게시글 삭제 버튼클릭 이벤트. 
        /// 1. 파라미터 게시글 번호, 제목, 내용, 작성일, 작성자, 수정일 => st
        /// 2. DB의 DeleteBoard(st) 수행하여 bool타입으로 받아 true/ false
        /// 3. true = 삭제완료/ false = 삭제불가 메세지 출력
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
                    BoardDB db = new BoardDB();
                    SetBoardText st = new SetBoardText(int.Parse(lblBoardID.Text), txtBoardName.Text, txtBoardContent.Text, lblpostingDate.Text, lblStaffID.Text, lblcorrectDate.Text);
                    bool bFlag;
                    bFlag = db.DeleteBoard(st);

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
        /// 게시글 검색 버튼클릭 이벤트. 
        /// 2. DB의 SearchBoard(txtSearch) 수행하여 DataTable dt 로 받아서
        /// 3. 정보 바인딩
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                BoardDB db = new BoardDB();
                DataTable dt = db.SearchBoard(txtSearch.Text);
                db.Dispose();
                DataView dataView = new DataView(dt);
                BoardDataGridView.DataSource = dataView;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
