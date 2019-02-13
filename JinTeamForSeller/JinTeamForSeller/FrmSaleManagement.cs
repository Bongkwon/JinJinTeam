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
            if(dTPicToDate.Value - dTPicFromDate.Value < TimeSpan.Zero)
            {
                //MessageBox.Show("Test");
                DateTime tempTime = dTPicToDate.Value;
                dTPicToDate.Value = dTPicFromDate.Value;
                dTPicFromDate.Value = tempTime;
            }
            foreach (var item in lstSales)
            {
                
            }
        }
    }
}
