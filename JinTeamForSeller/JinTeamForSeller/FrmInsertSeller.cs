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
    public partial class FrmInsertSeller : Form
    {
        Dao.SellerDAO seller = new Dao.SellerDAO();
        public FrmInsertSeller()
        {
            InitializeComponent();
        }

        private void btnInsertPic_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imgRegistration.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnCheckOverlap_Click(object sender, EventArgs e)
        {
            bool result = false;
            result = seller.ChkOverLap(txtId.Text);
            if (result == true)
            {
                MessageBox.Show("중복되는 ID 입니다.");
            }
            else
            {
                MessageBox.Show("사용가능한 ID 입니다.");
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            seller.InsertSeller(new Vo.SellerVO(txtId.Text, txtPass.Text, txtComName.Text, txtAddr.Text, txtBossName.Text, txtPhone.Text, txtPostal.Text, txtEmail.Text, txtFax.Text, txtReturnAddr.Text, txtCorpRegistrationNo.Text));
        }
    }
}
