using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JinTeamForAdmin.Dao;
using JinTeamForAdmin.Vo;
using JinTeamForAdmin.Bus;
using Excel = Microsoft.Office.Interop.Excel;

namespace JinTeamForAdmin.Bus
{
    public partial class Tax_Ex : Form
    {
        bool path_switch = false;
        string date_short;
        private TaxBill_Vo tv;

        public Tax_Ex()
        {
            InitializeComponent();
        }

        public Tax_Ex(TaxBill_Vo tv) : this()
        {
            this.tv = tv;
        }

        /// <summary>
        /// 화면 로드시 발생하는 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Load</param>
        private void Tax_Ex_Load(object sender, EventArgs e)
        {

            pb_Exit.BackgroundImage = Image.FromFile(Application.StartupPath + "/Resources/cancel.png");

            lbl_path.Text = "저장위치를 지정 해주세요";

            //BackgroundImage = Image.FromFile(Application.StartupPath + "/Resources/세금계산서_양식예시.png");
            pictureBox1.Image = Image.FromFile(Application.StartupPath + "/Resources/Tax_FormatEx.png");


            lbl_corporate_registration_no.Text = tv.Corporate_registration_no;
            lbl_stock_id.Text = tv.Stock_ID;
            lbl_seller_Id.Text = tv.Seller_ID;
            lbl_seller_boss.Text = tv.Seller_boss;
            lbl_seller_addr.Text = tv.Seller_addr;

            lbl_pay_count.Text = tv.Pay_count.ToString("#,##0");
            
            lbl_pay_date_1.Text = tv.Pay_date.Substring(0, tv.Pay_date.IndexOf('오'));

            lbl_pay_date_2.Text = tv.Pay_date.Substring(5,5);

            lbl_pay_price_1.Text = tv.Pay_price.ToString();
            int pay_price = Int32.Parse(tv.Pay_price.Replace(",", ""));

            lbl_pay_price_6.Text = (pay_price * tv.Pay_count).ToString("#,##0");
            lbl_pay_price_2.Text = (pay_price * tv.Pay_count * 0.9).ToString("#,##0");
            lbl_pay_price_3.Text = (pay_price * 0.9).ToString("#,##0");
            lbl_pay_price_5.Text = (pay_price * tv.Pay_count * 0.1).ToString("#,##0");
            lbl_pay_price_4.Text = (pay_price * 0.1).ToString("#,##0");


        }

        /// <summary>
        /// 저장위치 변경 버튼 클릭시 발생하는 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">버튼 클릭</param>
        private void btn_saveLocation_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                lbl_path.Text = folderBrowserDialog1.SelectedPath;
                path_switch = true;
            }
            if (path_switch)
            {
                btn_output.Enabled = true;
            }
        }

        /// <summary>
        /// 종료 버튼 클릭시 발생하는 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// 출력 버튼 클릭시 발생하는 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_output_Click(object sender, EventArgs e)
        {

            Excel.Application excelApp = new Excel.Application();
            if (excelApp == null)
            {
                MessageBox.Show("Excel 응용 프로그램을 찾을 수 없거나, 설치 되지 않았습니다.");
            }
            Excel.Workbook workBook;
            Excel.Worksheet workSheet;
            object missingValue = System.Reflection.Missing.Value;

            workBook = excelApp.Workbooks.Open(Application.StartupPath +"/Resources/Tax_Format.xlsx");
            workSheet = workBook.Worksheets.Item[1];


            workSheet.Cells[5, 3] = lbl_corporate_registration_no.Text;

            workSheet.Cells[6, 6] = lbl_seller_boss.Text;
            workSheet.Cells[6, 3] = lbl_seller_Id.Text;

            workSheet.Cells[7, 3] = lbl_seller_addr.Text;

            workSheet.Cells[10, 1] = lbl_pay_date_1.Text;
            workSheet.Cells[10, 3] = lbl_pay_price_2.Text;
            workSheet.Cells[10, 7] = lbl_pay_price_5.Text;

            workSheet.Cells[12, 1] = lbl_pay_date_2.Text;
            workSheet.Cells[12, 2] = lbl_stock_id.Text;
            workSheet.Cells[12, 5] = lbl_pay_count.Text;
            workSheet.Cells[12, 6] = lbl_pay_price_1.Text;
            workSheet.Cells[12, 8] = lbl_pay_price_3.Text;
            workSheet.Cells[12, 10] = lbl_pay_price_4.Text;

            workSheet.Cells[17, 1] = lbl_pay_price_6.Text;

            try
            {
                date_short = DateTime.Now.ToShortDateString();
                workBook.SaveAs(lbl_path.Text+@"\세금계산서 "+ lbl_stock_id.Text+" "+ date_short + ".xls", Excel.XlFileFormat.xlWorkbookNormal, null, null, null, null, Excel.XlSaveAsAccessMode.xlNoChange, Excel.XlSaveConflictResolution.xlLocalSessionChanges, missingValue, missingValue, missingValue, missingValue);
            }
            catch (Exception)
            {
                MessageBox.Show("저장 실패");
                return;
            }

            excelApp.Quit();
            Marshal.ReleaseComObject(workSheet);
            Marshal.ReleaseComObject(workBook);
            Marshal.ReleaseComObject(excelApp);
            
            string type_u = "pay";

            TaxBill_Vo tv_sub = new TaxBill_Vo()
            {
                Pay_ID = tv.Pay_ID
            };
 
            if (new Admin_Dao().Update_state_ob(tv_sub, type_u))
            {
                MessageBox.Show("저장 성공");

                Admin_main ad = (Admin_main)Owner;
                ad.Pro_Temp = true;
            }
        }

        /// <summary>
        /// 종료 버튼 클릭시 발생하는 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">버튼 클릭</param>
        private void pb_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        Point mousePoint;
        /// <summary>
        /// 화면이동을 위한 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        /// <summary>
        /// 화면이동을 위한 이벤트 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X), this.Top - (mousePoint.Y - e.Y));
            }
        }

    }
}
