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
    public partial class FrmSearchID : Form
    {
        SellerDAO sDao = new SellerDAO();
        public FrmSearchID()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCorpRegiNo.Text) == false)
            {
                SellerVO sellerWithCorp = new SellerVO();
                SellerVO sellerWithID = new SellerVO();
                sellerWithCorp.Corporate_registration_no = txtCorpRegiNo.Text;
                try
                {
                    sellerWithID = sDao.SearchSellerID(sellerWithCorp);
                }
                catch (Exception)
                {
                    MessageBox.Show("해당하는 ID가 없습니다.");
                }
                if(string.IsNullOrEmpty(sellerWithID.Seller_ID) == false)
                {
                    txtID.Visible = true;
                    txtID.Text = sellerWithID.Seller_ID;
                }
                else
                {
                    //MessageBox.Show("해당하는 ID가 없습니다.");
                }
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

        private void FrmSearchID_Load(object sender, EventArgs e)
        {
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - this.Size.Width / 2, Screen.PrimaryScreen.Bounds.Height / 2 - this.Size.Height / 2);
        }
    }
}
