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
    }
}
