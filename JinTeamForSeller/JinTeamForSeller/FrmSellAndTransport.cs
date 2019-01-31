using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JinTeamForSeller.Vo;
using JinTeamForSeller.Dao;

namespace JinTeamForSeller
{
    public partial class FrmSellAndTransport : Form
    {
        PaymentInfoDAO pDao = new PaymentInfoDAO();
        List<Payment_InfoVO> lstPInfo;
        DataGridViewCheckBoxColumn dc = new DataGridViewCheckBoxColumn();
        TransportInfoDAO tDao = new TransportInfoDAO();
        public FrmSellAndTransport()
        {
            InitializeComponent();
        }

        private void FrmSellAndTransport_Load(object sender, EventArgs e)
        {
            
            dc.Name = "trans_State_Com";
            dc.HeaderText = "배송 완료시 체크";
            
            lstPInfo = pDao.SelectPaymentInfoForSeller(Form1.CompanyNo);
            gViewPayInfo.DataSource = lstPInfo;
            gViewPayInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gViewPayInfo.Columns["order_ID"].Visible = false;
            gViewPayInfo.Columns["Seller_No"].Visible = false;
            foreach (DataGridViewColumn item in gViewPayInfo.Columns)
            {
                item.ReadOnly = true;
            }
            gViewPayInfo.Columns["Waybill_ID"].ReadOnly = false;
            
            dc.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            //DataGridViewColumn dc = new DataGridViewColumn();
            //dc.DefaultCellStyle = bool;
            if (!gViewPayInfo.Columns.Contains(dc))
            {
                gViewPayInfo.Columns.Add(dc);
            }
            CheckTransportStateCom();
            gViewPayInfo.Columns["trans_State_Com"].ReadOnly = false;
            // MessageBox.Show(gViewPayInfo.Rows.Count.ToString());
        }

        private void CheckTransportStateCom()
        {
            foreach (DataGridViewRow item in gViewPayInfo.Rows)
            {
                if (item.Cells["transport_state"].Value.ToString().Contains("완"))
                {
                    item.Cells["trans_State_Com"].Value = true;
                }
            }
        }

        private void gViewPayInfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && gViewPayInfo.Columns["Waybill_ID"] != gViewPayInfo.Columns[e.ColumnIndex])
            {
                if(gViewPayInfo[e.ColumnIndex,e.RowIndex] != null)
                {
                    FrmSalesDetail frm = new FrmSalesDetail(gViewPayInfo.Rows[e.RowIndex]);
                    frm.ShowDialog();
                }
            }
        }

        private void rdoShowAll_CheckedChanged(object sender, EventArgs e)
        {
            if(rdoShowAll.Checked == true)
            {
                gViewPayInfo.DataSource = null;
                gViewPayInfo.DataSource = lstPInfo;
                CheckTransportStateCom();
            }
        }
        private void rdoShowYet_CheckedChanged(object sender, EventArgs e)
        {
            List<Payment_InfoVO> lstYet = new List<Payment_InfoVO>();
            if (rdoShowYet.Checked == true)
            {
                foreach (var item in lstPInfo)
                {
                    if (string.IsNullOrEmpty(item.Waybill_ID) != false || item.Transport_state.Contains("전"))
                    {
                        lstYet.Add(item);
                    }
                }
                gViewPayInfo.DataSource = lstYet;
                CheckTransportStateCom();
            }
        }

        private void rdoShowIng_CheckedChanged(object sender, EventArgs e)
        {
            List<Payment_InfoVO> lstIng = new List<Payment_InfoVO>();
            if (rdoShowIng.Checked == true)
            {
                foreach (var item in lstPInfo)
                {
                    if (item.Transport_state.Contains("중"))
                    {
                        lstIng.Add(item);
                    }
                }
                gViewPayInfo.DataSource = lstIng;
                CheckTransportStateCom();
            }
        }

        private void rdoShowFin_CheckedChanged(object sender, EventArgs e)
        {
            List<Payment_InfoVO> lstFin = new List<Payment_InfoVO>();
            if (rdoShowFin.Checked == true)
            {
                foreach (var item in lstPInfo)
                {
                    if (item.Transport_state.Contains("완"))
                    {
                        lstFin.Add(item);
                    }
                }
                gViewPayInfo.DataSource = lstFin;
                CheckTransportStateCom();
            }
        }

        private void gViewPayInfo_KeyUp(object sender, KeyEventArgs e)
        {
            //if (gViewPayInfo.CurrentRow.Index >= 0 && gViewPayInfo.CurrentCell.ColumnIndex == 7)
            //{
            //    if (e.KeyCode == Keys.Down)
            //        e.KeyCode == Keys.Enter || || e.KeyCode == Keys.Up
            //    {
            //        MessageBox.Show(gViewPayInfo.CurrentCell.Value.ToString());
            //        if (string.IsNullOrEmpty(gViewPayInfo.CurrentRow.Cells["Transport_State"].Value.ToString()) == false)
            //        {
            //            Payment_InfoVO pay = new Payment_InfoVO();
            //            if (gViewPayInfo.CurrentRow.Index == gViewPayInfo.Rows.Count - 1)
            //            {
            //                pay = new Payment_InfoVO(
            //                (int)gViewPayInfo.Rows[gViewPayInfo.CurrentRow.Index].Cells["Pay_ID"].Value,
            //                gViewPayInfo.Rows[gViewPayInfo.CurrentRow.Index].Cells["order_ID"].Value.ToString(),
            //                gViewPayInfo.Rows[gViewPayInfo.CurrentRow.Index].Cells["User_Ship_ID"].Value.ToString(),
            //                (int)gViewPayInfo.Rows[gViewPayInfo.CurrentRow.Index].Cells["Seller_No"].Value,
            //                (int)gViewPayInfo.Rows[gViewPayInfo.CurrentRow.Index].Cells["Pay_count"].Value,
            //                (int)gViewPayInfo.Rows[gViewPayInfo.CurrentRow.Index].Cells["Pay_Price"].Value,
            //                gViewPayInfo.Rows[gViewPayInfo.CurrentRow.Index].Cells["Waybill_ID"].Value.ToString(),
            //                gViewPayInfo.Rows[gViewPayInfo.CurrentRow.Index].Cells["Cus_name"].Value.ToString(),
            //                gViewPayInfo.Rows[gViewPayInfo.CurrentRow.Index].Cells["User_addr"].Value.ToString(),
            //                gViewPayInfo.Rows[gViewPayInfo.CurrentRow.Index].Cells["Stock_ID"].Value.ToString(),
            //                gViewPayInfo.Rows[gViewPayInfo.CurrentRow.Index].Cells["Order_require"].Value.ToString(),
            //                gViewPayInfo.Rows[gViewPayInfo.CurrentRow.Index].Cells["Ship_require"].Value.ToString(),
            //                gViewPayInfo.Rows[gViewPayInfo.CurrentRow.Index].Cells["Transport_state"].Value.ToString(),
            //                gViewPayInfo.Rows[gViewPayInfo.CurrentRow.Index].Cells["User_name"].Value.ToString()
            //            );
            //            }
            //            else if (gViewPayInfo.CurrentRow.Index < gViewPayInfo.Rows.Count - 1)
            //            {
            //                pay = new Payment_InfoVO(
            //                (int)gViewPayInfo.Rows[gViewPayInfo.CurrentRow.Index - 1].Cells["Pay_ID"].Value,
            //                gViewPayInfo.Rows[gViewPayInfo.CurrentRow.Index - 1].Cells["order_ID"].Value.ToString(),
            //                gViewPayInfo.Rows[gViewPayInfo.CurrentRow.Index - 1].Cells["User_Ship_ID"].Value.ToString(),
            //                (int)gViewPayInfo.Rows[gViewPayInfo.CurrentRow.Index - 1].Cells["Seller_No"].Value,
            //                (int)gViewPayInfo.Rows[gViewPayInfo.CurrentRow.Index - 1].Cells["Pay_count"].Value,
            //                (int)gViewPayInfo.Rows[gViewPayInfo.CurrentRow.Index - 1].Cells["Pay_Price"].Value,
            //                gViewPayInfo.Rows[gViewPayInfo.CurrentRow.Index - 1].Cells["Waybill_ID"].Value.ToString(),
            //                gViewPayInfo.Rows[gViewPayInfo.CurrentRow.Index - 1].Cells["Cus_name"].Value.ToString(),
            //                gViewPayInfo.Rows[gViewPayInfo.CurrentRow.Index - 1].Cells["User_addr"].Value.ToString(),
            //                gViewPayInfo.Rows[gViewPayInfo.CurrentRow.Index - 1].Cells["Stock_ID"].Value.ToString(),
            //                gViewPayInfo.Rows[gViewPayInfo.CurrentRow.Index - 1].Cells["Order_require"].Value.ToString(),
            //                gViewPayInfo.Rows[gViewPayInfo.CurrentRow.Index - 1].Cells["Ship_require"].Value.ToString(),
            //                gViewPayInfo.Rows[gViewPayInfo.CurrentRow.Index - 1].Cells["Transport_state"].Value.ToString(),
            //                gViewPayInfo.Rows[gViewPayInfo.CurrentRow.Index - 1].Cells["User_name"].Value.ToString()
            //            );
            //            }
            //            Transport_InfoVO ti = new Transport_InfoVO(Form1.CompanyNo, pay.Waybill_ID);
            //            if (!pDao.UpdatePaymentInfo(pay))
            //            {

            //            }
            //            if (!tDao.InsertTransport(ti))
            //            {
            //                MessageBox.Show("오류 발생");
            //            }
            //        }
            //    }
            //}

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool result = false;
            foreach (DataGridViewRow item in gViewPayInfo.Rows)
            {
                if(string.IsNullOrEmpty(item.Cells["Transport_State"].Value.ToString()) == false || item.Cells["Transport_State"].Value.ToString().Contains("전"))
                {
                    //MessageBox.Show("Test");
                    break;
                }
                
                Payment_InfoVO pay = new Payment_InfoVO(
                (int)item.Cells["Pay_ID"].Value,
                item.Cells["order_ID"].Value.ToString(),
                item.Cells["User_Ship_ID"].Value.ToString(),
                (int)item.Cells["Seller_No"].Value,
                (int)item.Cells["Pay_count"].Value,
                (int)item.Cells["Pay_Price"].Value,
                item.Cells["Waybill_ID"].Value.ToString(),
                item.Cells["Cus_name"].Value.ToString(),
                item.Cells["User_addr"].Value.ToString(),
                item.Cells["Stock_ID"].Value.ToString(),
                item.Cells["Order_require"].Value.ToString(),
                item.Cells["Ship_require"].Value.ToString(),
                item.Cells["Transport_state"].Value.ToString(),
                item.Cells["User_name"].Value.ToString()
            );                
                Transport_InfoVO ti = new Transport_InfoVO(Form1.CompanyNo, pay.Waybill_ID);
                if (pDao.UpdatePaymentInfo(pay))
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
                if (tDao.InsertTransport(ti))
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            if (UpdateTrans_State())
            {
                result = true;
            }
            else
            {
                result = false;
            }
            if (result)
            {
                MessageBox.Show("저장 완료");                
            }
            this.OnLoad(null);
            rdoShowAll.Checked = true;
        }

        private void btnSaveTrans_State_Click(object sender, EventArgs e)
        {
            
        }

        private bool UpdateTrans_State()
        {
            bool result = false;
            foreach (DataGridViewRow item in gViewPayInfo.Rows)
            {
                if ((bool)item.Cells["trans_State_Com"].Value == true)
                {
                    item.Cells["Transport_state"].Value = "배송 완료";
                }
                else if ((bool)item.Cells["trans_State_Com"].Value == false)
                {
                    item.Cells["Transport_state"].Value = "배송 중";
                }
                Transport_InfoVO ti = new Transport_InfoVO(item.Cells["waybill_ID"].Value.ToString(), item.Cells["transport_State"].Value.ToString());
                if (tDao.UpdateTransportState(ti))
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            return result;
        }
    }
}
