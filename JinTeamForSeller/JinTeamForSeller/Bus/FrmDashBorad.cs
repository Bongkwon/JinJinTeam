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

namespace JinTeamForSeller
{
    public partial class FrmDashBorad : Form
    {
        public FrmDashBorad()
        {
            InitializeComponent();
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

        private void FrmDashBorad_Load(object sender, EventArgs e)
        {
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - this.Size.Width / 2, Screen.PrimaryScreen.Bounds.Height / 2 - this.Size.Height / 2);
            TransportInfoDAO tDao = new TransportInfoDAO();
            ProductDAO pDao = new ProductDAO();
            InquireDao iDao = new InquireDao();
            ReviewDAO rDao = new ReviewDAO();            
            lblNewInquireSeller.Text = iDao.NewInquireSeller(Form1.CompanyNo).ToString();
            lblNewReview.Text = rDao.NewReview(Form1.CompanyNo).ToString();
            lblNotShipping.Text = tDao.NotShipping(Form1.CompanyNo).ToString();
            lblWaybillNotYet.Text = tDao.WaybillNotYet(Form1.CompanyNo).ToString();
            lblSumOfProLike.Text = pDao.CountOfProState(Form1.CompanyNo).ToString();
            lblSumOfPayCount.Text = tDao.SumOfPayCount(Form1.CompanyNo).ToString();

        }

        private void panel2_Click(object sender, EventArgs e)
        {
            FrmInquiry frm = new FrmInquiry();
            frm.Show();
        }

        private void panelFor_Click(object sender, EventArgs e)
        {
            FrmSellAndTransport frm = new FrmSellAndTransport();
            frm.Show();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            FrmProducts frm = new FrmProducts();
            frm.Show();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            FrmSaleManagement frm = new FrmSaleManagement();
            frm.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.OnLoad(null);
        }
    }
}
