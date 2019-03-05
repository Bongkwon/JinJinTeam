using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using JinTeamForSeller.Dao;
using JinTeamForSeller.Vo;

namespace JinTeamForSeller
{
    public partial class FrmSaleManagement : Form
    {
        SalesManagementDAO sDao = new SalesManagementDAO();
        List<SalesManagementVO> lstSales = new List<SalesManagementVO>();
        List<int> lstPrice = new List<int>();
        List<int> lstCount = new List<int>();
        List<string> lstProName = new List<string>();
        List<string> lstDate = new List<string>();        

        public FrmSaleManagement()
        {
            InitializeComponent();
        }

        private void FrmSaleManagement_Load(object sender, EventArgs e)
        {
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - this.Size.Width / 2, Screen.PrimaryScreen.Bounds.Height / 2 - this.Size.Height / 2); ViewGView();
            chartSales.Series[0].LegendText = "매출액";
            dTPicToDate.CustomFormat = "yyyy-MM";
            dTPicFromDate.CustomFormat = "yyyy-MM";
            btnSearch_Click(null, null);
            chartSales.Legends[0].BackColor = Color.FromArgb(206, 206, 210);
            //chartSales.Palette = ChartColorPalette.Light;
        }

        private void ViewGView()
        {            
            
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            lstSales = sDao.selectSalesManagementForSeller(Form1.CompanyNo);
            dataGridView1.DataSource = lstSales;            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int totalPrice = 0;
            int totalCount = 0;
            int i = 0;
            List<string> lstgroup = new List<string>();
            lstCount.Clear();
            lstPrice.Clear();
            lstProName.Clear();
            lstDate.Clear();

            if (dTPicToDate.Value - dTPicFromDate.Value < TimeSpan.Zero)
            {
                //MessageBox.Show("Test");
                DateTime tempTime = dTPicToDate.Value;
                dTPicToDate.Value = dTPicFromDate.Value;
                dTPicFromDate.Value = tempTime;
            }



            #region 일별매출액
            if (rdoDayDay.Checked == true)
            {
                var grouping = from s in lstSales
                               where s.Pay_Date >= dTPicFromDate.Value.Date && dTPicToDate.Value > s.Pay_Date
                               group s by s.Pay_Date;

                foreach (var item in grouping)
                {
                    //textBox1.Text += item.Key + "\r\n";
                    lstgroup.Add(item.Key.ToString().Remove(10));
                    lstPrice.Add(0);
                    lstCount.Add(0);
                    lstProName.Add("");
                    lstDate.Add("");
                    foreach (var item2 in item)
                    {
                        lstPrice[i] += item2.Pay_Price;
                        lstCount[i] += item2.Pay_Count;
                        lstProName[i] = item2.Pro_Name;
                        lstDate[i] = item2.Pay_Date.Date.ToString();
                    }
                    i++;
                }
            }
            #endregion


            #region 월별 매출액
            if (rdoMonthMonth.Checked == true)
            {
                DateTime fromDate = new DateTime(dTPicFromDate.Value.Year, dTPicFromDate.Value.Month,1);
                DateTime toDate = new DateTime(dTPicToDate.Value.Year, dTPicToDate.Value.Month, DateTime.DaysInMonth(dTPicToDate.Value.Year, dTPicToDate.Value.Month), 23, 59, 59);
                
                var groupingbyMonth = from s in lstSales
                                      where s.Pay_Date >= fromDate.Date
                                      && toDate.Date >= s.Pay_Date
                                      //s.Pay_Date.Month >= dTPicFromDate.Value.Month
                                      //&& s.Pay_Date.Year >= dTPicFromDate.Value.Year
                                      //&& dTPicToDate.Value.Year >= s.Pay_Date.Year
                                      //&& dTPicToDate.Value.Month >= s.Pay_Date.Month
                                      group s by s.Pay_Date;

                foreach (var item in groupingbyMonth)
                {
                    //textBox1.Text += item.Key + "\r\n";
                    lstgroup.Add(item.Key.ToString().Remove(10));
                    lstPrice.Add(0);
                    lstCount.Add(0);
                    lstProName.Add("");
                    lstDate.Add("");
                    foreach (var item2 in item)
                    {
                        lstPrice[i] += item2.Pay_Price;
                        lstCount[i] += item2.Pay_Count;
                        lstProName[i] = item2.Pro_Name;
                        lstDate[i] = item2.Pay_Date.Date.ToString();
                    }
                    i++;
                }
                for (int j = 0; j < lstCount.Count; j++)
                {
                    totalCount += lstCount[j];
                    totalPrice += lstPrice[j];
                }
            }
            #endregion

            chartSales.Series[0].Points.DataBindXY(lstgroup, lstPrice);
            lblTotal.Text = totalPrice.ToString();
            lblTotalCount.Text = totalCount.ToString();
            // MessageBox.Show(new DateTime(dTPicToDate.Value.Year, dTPicToDate.Value.Month,1).ToString());
        }

        private void rdoDayDay_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoDayDay.Checked == true)
            {
                dTPicFromDate.Format = DateTimePickerFormat.Short;
                dTPicToDate.Format = DateTimePickerFormat.Short;
            }
        }

        private void rdoMonthMonth_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoMonthMonth.Checked == true)
            {
                dTPicFromDate.Format = DateTimePickerFormat.Custom;
                dTPicToDate.Format = DateTimePickerFormat.Custom;
            }
        }
        Point? previous = null;
        ToolTip myToolTip = new ToolTip();

        private void chartSales_MouseMove(object sender, MouseEventArgs e)
        {
            Point nowPosition = e.Location;
            if (previous.HasValue && nowPosition == previous) // 마우스 움직임이 없을 때
            {
                return;
            }
            myToolTip.RemoveAll();
            previous = nowPosition;
            HitTestResult hit = chartSales.HitTest(nowPosition.X, nowPosition.Y, ChartElementType.DataPoint);
            //balls.Reverse();
            
            if (hit.ChartElementType == ChartElementType.DataPoint)
            {
                //MessageBox.Show(lstProName[hit.PointIndex].ToString());
                myToolTip.Show("상품명 : " + lstProName[hit.PointIndex] + "\r\n판매량 : " + lstCount[hit.PointIndex] + "\r\n 판매가격 : " +lstPrice[hit.PointIndex] + "\r\n판매일 : " + lstDate[hit.PointIndex], chartSales, new Point(nowPosition.X + 10, nowPosition.Y + 15));
                
                //myToolTip.Show(ballNum + "번 공 당첨 횟수 : " + ptBalls, chart1, new Point(nowPosition.X + 10, nowPosition.Y + 15));
            }
        }
        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            var s = sender as Panel;
            if (e.Button != System.Windows.Forms.MouseButtons.Left)
                return;

            s.Parent.Left = this.Left + (e.X - ((Point)s.Tag).X);
            s.Parent.Top = this.Top + (e.Y - ((Point)s.Tag).Y);
        }

        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            var s = sender as Panel;
            s.Tag = new Point(e.X, e.Y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
