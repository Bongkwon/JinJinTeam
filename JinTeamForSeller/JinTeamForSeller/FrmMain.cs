using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JinTeamForSeller.Dao;
namespace JinTeamForSeller
{
    public partial class FrmMain : Form
    {
        InquireDao idao = new InquireDao();
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["azureCon"].ConnectionString);        
        public FrmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmProducts frm = new FrmProducts();
            frm.Show();
            //this.clo
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {            
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - this.Size.Width / 2, Screen.PrimaryScreen.Bounds.Height / 2 - this.Size.Height / 2);

            //string msg = idao.GetMsg();
            //if (!string.IsNullOrEmpty(msg))
            //{
            //msg = GetMassage(msg);
            //MessageBox.Show(idao.GetMsg());
            //}
            conn.InfoMessage += new SqlInfoMessageEventHandler(OninfoMsg);
            conn.FireInfoMessageEventOnUserErrors = true;
            conn.Open();
            //SqlCommand cmd = new SqlCommand("insert into Inquire_Seller (Inquire_type, cus_no, stock_ID, Inquire_title, Inquire_body)" + "values(N'기타', 1, N'CominFa_1234_L', N'문의', N'문의');", conn);
            //cmd.ExecuteNonQuery();
        }

        public static void OninfoMsg(object sender, SqlInfoMessageEventArgs e)
        {
            //label1.Text = e.Message;
            //foreach (SqlError item in e.Errors)
            //{
            //    MessageBox.Show(item.Message + item.Number + item.Procedure + item.Server + item.Source + item.State);
            //    label1.Text += item.Message + item.Number + item.Procedure + item.Server + item.Source + item.State;
            //}
            MessageBox.Show(e.Message);
        }

        //private static string GetMassage(string msg)
        //{          
        //        conn.FireInfoMessageEventOnUserErrors = true;
        //        conn.Open();
        //        conn.InfoMessage += delegate (object sender, SqlInfoMessageEventArgs e)
        //        {
        //            msg = "";
        //            msg = e.Message;
        //            MessageBox.Show(msg);
        //        };
        //        conn.Close();

        //    return msg;
            
        //}

        private void button5_Click(object sender, EventArgs e)
        {
            FrmSellAndTransport frm = new FrmSellAndTransport();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            FrmInquiry frm = new FrmInquiry();
            frm.Show();
            
        }

        private void btnSaleManagement_Click(object sender, EventArgs e)
        {
            FrmSaleManagement frm = new FrmSaleManagement();
            frm.Show();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            var s = sender as Panel;
            if (e.Button != System.Windows.Forms.MouseButtons.Left)
                return;

            s.Parent.Left = this.Left + (e.X - ((Point)s.Tag).X);
            s.Parent.Top = this.Top + (e.Y - ((Point)s.Tag).Y);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            var s = sender as Panel;
            s.Tag = new Point(e.X, e.Y);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
