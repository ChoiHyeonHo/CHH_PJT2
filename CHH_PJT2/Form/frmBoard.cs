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
        string staffID;
        public frmBoard()
        {
            InitializeComponent();
        }
        public frmBoard(Info info)
        {
            InitializeComponent();
            staffID = info.staffID;
        }

        private void frmBoard_Load(object sender, EventArgs e)
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

        /// <summary>
        /// 데이터 그리드 뷰 출력
        /// </summary>
        private void SetData()
        {
            BoardDB db = new BoardDB();
            DataTable dt = db.LoadBoardData();
            db.Dispose();
            DataView dataView = new DataView(dt);
            BoardDataGridView.DataSource = dataView;
        }

        /// <summary>
        /// 셀 더블클릭시 텍스트박스, 라벨에 정보 출력
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BoardDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lblBoardID.Text = BoardDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtBoardName.Text = BoardDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtBoardContent.Text = BoardDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            lblStaffID.Text = BoardDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            lblpostingDate.Text = BoardDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            lblcorrectDate.Text = BoardDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        /// <summary>
        /// 게시글 저장. 작성자는 현재 로그인계정, 작성일은 현재시간 기준
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            BoardDB db = new BoardDB();
            lblStaffID.Text = staffID;
            lblpostingDate.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            SetBoardText st = new SetBoardText(txtBoardName.Text, txtBoardContent.Text, lblpostingDate.Text, lblStaffID.Text, lblcorrectDate.Text);
            bool bFlag;
            bFlag = db.InsertBoard(st);

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

        /// <summary>
        /// 게시글 수정. 작성자를 로그인계정, 수정일을 현재시간으로.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
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

        /// <summary>
        /// 게시글 삭제. 게시글 번호가 일치하는 조건
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
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

        /// <summary>
        /// 게시글 검색. 해당하는 단어 포함시 모두 검색
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            BoardDB db = new BoardDB();
            DataTable dt = db.SearchBoard(txtSearch.Text);
            db.Dispose();
            DataView dataView = new DataView(dt);
            BoardDataGridView.DataSource = dataView;
        }
    }
}
