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
using Excel = Microsoft.Office.Interop.Excel;

namespace CHH_PJT2
{
    public partial class frmCounseling : Form
    {
        public frmCounseling()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Counseling 폼 로드시
        /// 1. DataGridView에 Column 추가
        /// 2. SetData()호출 => LoadCounselingData() 호출
        /// 3. DB에 있는 LoadCounselingData()에서 Binding 할 Data 가져오기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                CommonUtil.SetInitGridView(CouDataGridView);
                CommonUtil.AddGridTextColumn(CouDataGridView, "상담번호", "advNum", 100);                 //index[0]
                CommonUtil.AddGridTextColumn(CouDataGridView, "상담일자", "advDate", 100);                //1
                CommonUtil.AddGridTextColumn(CouDataGridView, "직원ID", "staffID", 80);                   //2
                CommonUtil.AddGridTextColumn(CouDataGridView, "학생ID", "stuID", 80);                     //3
                CommonUtil.AddGridTextColumn(CouDataGridView, "점수", "mathScore", 70);                   //4 
                CommonUtil.AddGridTextColumn(CouDataGridView, "상담내용", "advContents", 170, false);     //5
                CommonUtil.AddGridTextColumn(CouDataGridView, "조치내용", "actions", 10, false);          //6
                this.CouDataGridView.Font = new Font("나눔바른고딕", 10, FontStyle.Regular);

                SetData();
            }
            catch (Exception err)
            {
                throw err;
            }
        }


        /// <summary>
        /// 1. DB에 있는 LoadCounselingData() 호출
        /// 2. DataTable에 담아 DataView로
        /// 3. DataGridView의 DataSource를 Dataview로
        /// </summary>
        private void SetData()
        {
            try
            {
                CounselingDB db = new CounselingDB();
                DataTable dt = db.LoadCounselingData();
                db.Dispose();
                DataView dataView = new DataView(dt);
                CouDataGridView.DataSource = dataView;
            }
            catch (Exception err)
            {
                throw err;
            }
        }


        /// <summary>
        /// 셀 더블클릭 이벤트
        /// 1. 상담번호, 상담일, 직원ID, 학생ID, 점수, 상담내용, 조치내용 등의 정보를 각 TextBox에 출력
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CouDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtAdvNum.Text = CouDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                dtpAdvDate.Text = CouDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtStaffID.Text = CouDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtStuID.Text = CouDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtMathScore.Text = CouDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtAdvContents.Text = CouDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtAdvActions.Text = CouDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            catch (Exception err)
            {
                throw err;
            }
        }


        /// <summary>
        /// 신규저장 버튼 클릭 이벤트
        /// 1. DB에 있는 SetCounselingText Class의 Property들에 TextBox의 내용 담는다.
        /// 2. DB의 InsertAdvice()에 SetMemberText st 선언을 담아서 메서드 수행
        /// 3. 결과값 bool타입으로 받아서 true = 신규저장/ false = 신규저장 불가 메세지 출력
        /// 4. 신규저장시 SetData()를 통해 DataGridView에 변경된 내용 다시 출력
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                CounselingDB db = new CounselingDB();
                SetCounselingText st = new SetCounselingText(int.Parse(txtAdvNum.Text), dtpAdvDate.Value, txtStaffID.Text, txtStuID.Text, int.Parse(txtMathScore.Text), txtAdvContents.Text, txtAdvActions.Text);
                bool bFlag;
                bFlag = db.CreateAdvice(st);

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
                throw err;
            }
        }


        /// <summary>
        /// 정보수정 버튼 클릭 이벤트
        /// 1. DB에 있는 SetCounselingText Class의 Property들에 TextBox의 내용 담는다.
        /// 2. DB의 UpdateAdvice()에 SetMemberText st 선언을 담아서 메서드 수행
        /// 3. 결과값 bool타입으로 받아서 true = 수정/ false = 수정불가 메세지 출력
        /// 4. 수정완료시 SetData()를 통해 DataGridView에 변경된 내용 다시 출력
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                CounselingDB db = new CounselingDB();
                SetCounselingText st = new SetCounselingText(int.Parse(txtAdvNum.Text), dtpAdvDate.Value, txtStaffID.Text, txtStuID.Text, int.Parse(txtMathScore.Text), txtAdvContents.Text, txtAdvActions.Text);
                bool bFlag;
                bFlag = db.UpdateAdvice(st);

                if (bFlag)
                {
                    MessageBox.Show("정보 수정이 완료되었습니다.");
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

                throw err;
            }
        }


        /// <summary>
        /// 엑셀저장 버튼 클릭 이벤트
        /// DB에서 데이터를 조회해서 바로 excel 파일로 저장
        /// 1. 저장할 파일명을 물어본다.
        /// 2. 데이터를 조회해서 DataTable에 저장.
        /// 3. 저장된 데이터를 저장할 파일명으로 Write.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                string advNum = CouDataGridView.CurrentCell.Value.ToString();
                string deptName = "상담 차트";

                SaveFileDialog dlg = new SaveFileDialog();
                dlg.Filter = "Excel Files(*.xls)|*.xls";
                dlg.Title = "엑셀파일로 내보내기";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    CounselingDB db = new CounselingDB();
                    DataTable dt = db.GetCounselingList(advNum);
                    db.Dispose();

                    dt.Columns[0].ColumnName = "상담번호";
                    dt.Columns[1].ColumnName = "상담일자";
                    dt.Columns[2].ColumnName = "직원ID";
                    dt.Columns[3].ColumnName = "학생ID";
                    dt.Columns[4].ColumnName = "점수";
                    dt.Columns[5].ColumnName = "상담내용";
                    dt.Columns[6].ColumnName = "조치내용";

                    dt.TableName = $"{deptName} 사원현황";

                    if (ExportDataToExcel(dt, dlg.FileName))
                    {
                        MessageBox.Show("엑셀파일에 저장하였습니다.");
                    }
                    else
                    {
                        MessageBox.Show("엑셀파일에 저장에 실패하였습니다.");
                    }
                }
            }
            catch (Exception err)
            {

                throw err;
            }
        }


        private bool ExportDataToExcel(DataTable dt, string fileName)
        {
            Cursor currentCursor = this.Cursor;
            try
            {
                this.Cursor = Cursors.WaitCursor;
                //파일 Export 저장

                Excel.Application xlApp = new Excel.Application();
                Excel.Workbook xlWorkBook = xlApp.Workbooks.Add();
                Excel.Worksheet xlSheet = (Excel.Worksheet)xlWorkBook.Sheets.Add();
                xlSheet.Name = dt.TableName;

                //엑셀파일 내용에 대한 설명
                xlSheet.Cells[1, 1] = "상담 차트";
                xlSheet.Range[xlSheet.Cells[1, 1], xlSheet.Cells[1, 7]].Merge();
                xlSheet.Range[xlSheet.Cells[1, 1], xlSheet.Cells[1, 7]].font.Size = 30;
                ((Excel.Range)xlSheet.Cells[1, 1]).EntireRow.RowHeight = 70;

                //타이틀
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    xlSheet.Cells[2, i + 1] = dt.Columns[i].ColumnName;
                    ((Excel.Range)xlSheet.Cells[2, i + 1]).Interior.Color = Excel.XlRgbColor.rgbAliceBlue;
                }

                //데이터
                for (int r = 0; r < dt.Rows.Count; r++)
                {
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        xlSheet.Cells[r + 3, i + 1] = dt.Rows[r][i].ToString();
                    }
                }
                xlSheet.Columns.AutoFit();
                //컬럼의 너비가 데이터길이에 따라서 자동조정

                xlWorkBook.SaveAs(fileName, Excel.XlFileFormat.xlWorkbookNormal);
                xlWorkBook.Close();
                xlApp.Quit();

                releaseObject(xlSheet);
                releaseObject(xlWorkBook);
                releaseObject(xlApp);

                this.Cursor = currentCursor;
                return true;
            }
            catch (Exception err)
            {
                this.Cursor = currentCursor;

                MessageBox.Show(err.Message);
                return false;
            }
        }


        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
