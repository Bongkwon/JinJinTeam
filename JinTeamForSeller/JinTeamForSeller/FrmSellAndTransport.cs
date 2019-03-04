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
        List<string> lstOldWaybill = new List<string>();

        public FrmSellAndTransport()
        {
            InitializeComponent();
        }

        private void FrmSellAndTransport_Load(object sender, EventArgs e)
        {
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - this.Size.Width / 2, Screen.PrimaryScreen.Bounds.Height / 2 - this.Size.Height / 2);
            dc.Name = "trans_State_Com";
            dc.HeaderText = "배송 완료시 체크";
            
            lstPInfo = pDao.SelectPaymentInfoForSeller(Form1.CompanyNo);
            if (!gViewPayInfo.Columns.Contains(dc))
            {
                gViewPayInfo.Columns.Add(dc);
            }
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.BackColor = Color.FromArgb(143, 145, 147);
            //style.
            gViewPayInfo.DefaultCellStyle = style;
            gViewPayInfo.DataSource = lstPInfo;
            gViewPayInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //gViewPayInfo.Columns["order_ID"].Visible = false;
            //gViewPayInfo.Columns["Seller_No"].Visible = false;
            foreach (DataGridViewColumn item in gViewPayInfo.Columns)
            {
                item.ReadOnly = true;
            }
            gViewPayInfo.Columns["Waybill_ID"].ReadOnly = false;
            foreach (var item in lstPInfo)
            {
                lstOldWaybill.Add(item.Waybill_ID);
            }
            dc.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            //DataGridViewColumn dc = new DataGridViewColumn();
            //dc.DefaultCellStyle = bool;
            
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
                lstOldWaybill.Clear();
                foreach (var item in lstPInfo)
                {
                    lstOldWaybill.Add(item.Waybill_ID);
                }                
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
                lstOldWaybill.Clear();
                foreach (var item in lstPInfo)
                {
                    if (string.IsNullOrEmpty(item.Waybill_ID) != false || item.Transport_state.Contains("전"))
                    {
                        lstYet.Add(item);
                        lstOldWaybill.Add(item.Waybill_ID);
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
                lstOldWaybill.Clear();
                foreach (var item in lstPInfo)
                {
                    if (item.Transport_state.Contains("중"))
                    {
                        lstIng.Add(item);
                        lstOldWaybill.Add(item.Waybill_ID);
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
                lstOldWaybill.Clear();
                foreach (var item in lstPInfo)
                {
                    if (item.Transport_state.Contains("완"))
                    {
                        lstFin.Add(item);
                        lstOldWaybill.Add(item.Waybill_ID);
                    }
                }
                gViewPayInfo.DataSource = lstFin;
                CheckTransportStateCom();
            }
        }
        string trans_State = "";
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                for (int i = 0; i < gViewPayInfo.RowCount; i++)
                {
                    bool result = false;
                    if (!string.IsNullOrEmpty(gViewPayInfo["Waybill_ID", i].Value.ToString()))
                    {
                        string oldwaybill = gViewPayInfo["Waybill_ID", i].Value.ToString();
                    }
                    try
                    {
                        result = (bool)gViewPayInfo["trans_State_Com", i].Value;
                    }
                    catch (Exception)
                    {
                    }
                    //MessageBox.Show(result.ToString());
                    if (result)
                    {
                        trans_State = "배송 완료";
                    }
                    else
                    {
                        trans_State = "배송 중";
                    }
                    if (string.IsNullOrEmpty(lstOldWaybill[i]) &&
                        !string.IsNullOrEmpty(gViewPayInfo["Waybill_ID", i].Value.ToString()))
                    {
                        Transport_InfoVO tVo = new Transport_InfoVO(0, Form1.CompanyNo, gViewPayInfo["Waybill_ID", i].Value.ToString(), trans_State);
                        tDao.InsertTransport(tVo, (int)gViewPayInfo["Pay_ID", i].Value);
                        //MessageBox.Show("Test1");
                    }
                    else if (!string.IsNullOrEmpty(gViewPayInfo["Waybill_ID", i].Value.ToString()))
                    {
                        // && lstPInfo[i].Waybill_ID != gViewPayInfo["Waybill_ID", i].Value.ToString()
                        Transport_InfoVO tVo = new Transport_InfoVO(0, Form1.CompanyNo, gViewPayInfo["Waybill_ID", i].Value.ToString(), trans_State);
                        tDao.UpdateTransportWaybill(tVo, lstOldWaybill[i], (int)gViewPayInfo["Pay_ID", i].Value);
                        //MessageBox.Show(lstOldWaybill[i]);
                        //MessageBox.Show(tVo.Waybill_ID);
                    }
                }
            }
            catch (Exception)
            {                
            }
            this.OnLoad(null);
            rdoShowAll.Checked = true;
            //int i = 0;
            //foreach (DataGridViewRow item in gViewPayInfo.Rows)
            //{
            //    try
            //    {
            //        Payment_InfoVO pay = new Payment_InfoVO
            //            (
            //            (int)item.Cells["Pay_ID"].Value,
            //            item.Cells["order_ID"].Value.ToString(),
            //            item.Cells["User_Ship_ID"].Value.ToString(),
            //            (int)item.Cells["Seller_No"].Value,
            //            (int)item.Cells["Pay_count"].Value,
            //            (int)item.Cells["Pay_Price"].Value,
            //            item.Cells["Waybill_ID"].Value.ToString(),
            //            item.Cells["Cus_name"].Value.ToString(),
            //            item.Cells["User_addr"].Value.ToString(),
            //            item.Cells["Stock_ID"].Value.ToString(),
            //            item.Cells["Order_require"].Value.ToString(),
            //            item.Cells["Ship_require"].Value.ToString(),
            //            item.Cells["Transport_state"].Value.ToString(),
            //            item.Cells["User_name"].Value.ToString()
            //            );
            //        Transport_InfoVO ti = new Transport_InfoVO(Form1.CompanyNo, pay.Waybill_ID);
            //        if (string.IsNullOrEmpty(lstPInfo[i].Waybill_ID) == false)
            //        {
            //            tDao.UpdateTransportWaybill(lstPInfo[i].Waybill_ID, pay.Waybill_ID);
            //            pDao.UpdatePaymentInfo(pay);
            //        }
            //        else if (string.IsNullOrEmpty(lstPInfo[i].Waybill_ID) == true && string.IsNullOrEmpty(item.Cells["Waybill_ID"].Value.ToString()) == false)
            //        {
            //            tDao.InsertTransport(ti);
            //            pDao.UpdatePaymentInfo(pay);
            //        }
            //        if ((bool)item.Cells["trans_State_Com"].FormattedValue == true)
            //        {
            //            item.Cells["Transport_state"].Value = "배송 완료";
            //        }
            //        else if ((bool)item.Cells["trans_State_Com"].FormattedValue == false)
            //        {
            //            item.Cells["Transport_state"].Value = "배송 중";
            //        }
            //        Transport_InfoVO ti2 = new Transport_InfoVO(item.Cells["waybill_ID"].Value.ToString(), item.Cells["transport_State"].Value.ToString());
            //        tDao.UpdateTransportState(ti2);
            //    }
            //    catch (Exception)
            //    {
            //        MessageBox.Show("저장 실패");
            //    }

            //    if (string.IsNullOrEmpty(item.Cells["Transport_State"].Value.ToString()) == false && item.Cells["Transport_State"].Value.ToString().Contains("전"))
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        Payment_InfoVO pay = new Payment_InfoVO(
            //        (int)item.Cells["Pay_ID"].Value,
            //        item.Cells["order_ID"].Value.ToString(),
            //        item.Cells["User_Ship_ID"].Value.ToString(),
            //        (int)item.Cells["Seller_No"].Value,
            //        (int)item.Cells["Pay_count"].Value,
            //        (int)item.Cells["Pay_Price"].Value,
            //        item.Cells["Waybill_ID"].Value.ToString(),
            //        item.Cells["Cus_name"].Value.ToString(),
            //        item.Cells["User_addr"].Value.ToString(),
            //        item.Cells["Stock_ID"].Value.ToString(),
            //        item.Cells["Order_require"].Value.ToString(),
            //        item.Cells["Ship_require"].Value.ToString(),
            //        item.Cells["Transport_state"].Value.ToString(),
            //        item.Cells["User_name"].Value.ToString()
            //    );
            //        Transport_InfoVO ti = new Transport_InfoVO(Form1.CompanyNo, pay.Waybill_ID);
            //        if (string.IsNullOrEmpty(lstPInfo[i].Waybill_ID) == false)
            //        {
            //            try
            //            {
            //                tDao.InsertTransport(ti);
            //                pDao.UpdatePaymentInfo(pay);
            //            }
            //            catch (Exception)
            //            {
            //                tDao.UpdateTransportWaybill(lstPInfo[i].Waybill_ID, pay.Waybill_ID);
            //                pDao.UpdatePaymentInfo(pay);
            //            }
            //        }
            //    }
            //    i++;
            //}
            //if (UpdateTrans_State())
            //{
            //    result3 = true;
            //}
            //else
            //{
            //    result3 = false;
            //}
            //if (result && result3)
            //{
            //    MessageBox.Show("저장 완료");
            //}

            //this.OnLoad(null);
            //rdoShowAll.Checked = true;
        }

        private bool UpdateTrans_State()
        {
            bool result = false;
            foreach (DataGridViewRow item in gViewPayInfo.Rows)
            {
                //MessageBox.Show(item.Cells["trans_State_Com"].Value.ToString());
                if ((bool)item.Cells["trans_State_Com"].FormattedValue == true)
                {
                    item.Cells["Transport_state"].Value = "배송 완료";
                }
                else if ((bool)item.Cells["trans_State_Com"].FormattedValue == false)
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
        string oldway = "";
        private void gViewPayInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                oldway = gViewPayInfo["Waybill_ID", e.RowIndex].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
