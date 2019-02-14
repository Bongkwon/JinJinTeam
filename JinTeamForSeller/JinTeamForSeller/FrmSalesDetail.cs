using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JinTeamForSeller
{
    public partial class FrmSalesDetail : Form
    {
        DataGridViewRow dr;
        public FrmSalesDetail()
        {
            InitializeComponent();
        }
        public FrmSalesDetail(DataGridViewRow dr):this()
        {
            this.dr = dr;
        }

        private void FrmSalesDetail_Load(object sender, EventArgs e)
        {
            string pay_ID = dr.Cells["pay_ID"].Value.ToString();            
            string stock_ID = dr.Cells["stock_ID"].Value.ToString();
            string pay_count = dr.Cells["pay_count"].Value.ToString();
            string pay_Price = dr.Cells["pay_Price"].Value.ToString();
            string cus_Name = dr.Cells["cus_name"].Value.ToString();
            string user_Name = dr.Cells["user_Name"].Value.ToString();
            string transprot_State = "";
            string waybill_ID = "";
            if (string.IsNullOrEmpty(dr.Cells["transport_state"].Value.ToString()) == false)
            {
                transprot_State = "배송 상태 : " + dr.Cells["transport_state"].Value.ToString();
            }
            else
            {
                transprot_State = "아직 배송 전입니다.";
            } 
            string order_Require = dr.Cells["order_require"].Value.ToString();
            string ship_Require = dr.Cells["ship_require"].Value.ToString();
            string user_Addr = dr.Cells["User_Addr"].Value.ToString();
            if (string.IsNullOrEmpty(dr.Cells["waybill_ID"].Value.ToString()) == false)
            {
                waybill_ID = "운송장 번호 : " + dr.Cells["waybill_ID"].Value.ToString();
            }
            else {
                waybill_ID = "운송장 번호가 아직 등록되지 않았습니다.";
            }

            lblPay_ID.Text += pay_ID;
            lblStock_no.Text += stock_ID;
            lblPro_Count.Text += pay_count;
            lblPay_Price.Text += pay_Price;
            lblCus_Name.Text += cus_Name;
            lblUser_Name.Text += user_Name;
            lblTrans_State.Text = transprot_State;
            lblOrder_Require.Text += order_Require;
            lblShip_Require.Text += ship_Require;
            lblUser_Addr.Text += user_Addr;
            lblWaybill_ID.Text = waybill_ID;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
