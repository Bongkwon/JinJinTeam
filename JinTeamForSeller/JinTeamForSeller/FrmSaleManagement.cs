using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JinTeamForSeller.Dao;
using JinTeamForSeller.Vo;

namespace JinTeamForSeller
{
    public partial class FrmSaleManagement : Form
    {
        SalesManagementDAO sDao = new SalesManagementDAO();
        List<SalesManagementVO> lstSales = new List<SalesManagementVO>();
        public FrmSaleManagement()
        {
            InitializeComponent();
        }

        private void FrmSaleManagement_Load(object sender, EventArgs e)
        {
            ViewGView();
            chartSales.Series[0].LegendText = "매출액";
            dTPicToDate.CustomFormat = "yyyy-MM";
            dTPicFromDate.CustomFormat = "yyyy-MM";
            btnSearch_Click(null, null);
        }

        private void ViewGView()
        {            
            int totalPrice = 0;
            int totalCount = 0;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            lstSales = sDao.selectSalesManagementForSeller(Form1.CompanyNo);
            dataGridView1.DataSource = lstSales;
            foreach (var item in lstSales)
            {
                totalPrice += item.Pay_Price;
                totalCount += item.Pay_Count;
            }
            lblTotal.Text = totalPrice.ToString();
            lblTotalCount.Text = totalCount.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int i = 0;
            List<string> lstgroup = new List<string>();
            List<int> lstPrice = new List<int>();

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
                    foreach (var item2 in item)
                    {
                        lstPrice[i] += item2.Pay_Price;
                    }
                    i++;
                }
            }
            #endregion


            #region 월별 매출액
            if (rdoMonthMonth.Checked == true)
            {
                var groupingbyMonth = from s in lstSales
                                      where s.Pay_Date.Month >= dTPicFromDate.Value.Month
                                      && s.Pay_Date.Year >= dTPicFromDate.Value.Year
                                      && dTPicToDate.Value.Year >= s.Pay_Date.Year
                                      && dTPicToDate.Value.Month >= s.Pay_Date.Month
                                      group s by s.Pay_Date;

                foreach (var item in groupingbyMonth)
                {
                    //textBox1.Text += item.Key + "\r\n";
                    lstgroup.Add(item.Key.ToString().Remove(10));
                    lstPrice.Add(0);
                    foreach (var item2 in item)
                    {
                        lstPrice[i] += item2.Pay_Price;
                    }
                    i++;
                }
            }
            #endregion

            chartSales.Series[0].Points.DataBindXY(lstgroup, lstPrice);
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
    }
}
