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
        //bool canInsert = false;
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
            int result = 0;
            if (!string.IsNullOrEmpty(txtId.Text))
            {
                try
                {
                    result = seller.ChkOverLap(txtId.Text);
                    if (result == 0)
                    {
                        MessageBox.Show("사용 할 수 없는 ID 입니다.");
                        btnSubmit.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("중복되는 ID 입니다.");
                        btnSubmit.Enabled = false;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("사용 할 수 있는 ID 입니다.");
                    btnSubmit.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("ID가 비어있을 수 없습니다.");
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtId.Text) && !string.IsNullOrEmpty(txtPass.Text) && !string.IsNullOrEmpty(txtChkPass.Text) && !string.IsNullOrEmpty(txtComName.Text) && !string.IsNullOrEmpty(txtBossName.Text) && !string.IsNullOrEmpty(txtPhone.Text) && !string.IsNullOrEmpty(txtPostal.Text) && !string.IsNullOrEmpty(txtAddr.Text) && !string.IsNullOrEmpty(txtEmail.Text) && !string.IsNullOrEmpty(txtFax.Text) && !string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(txtReturnAddr.Text) && !string.IsNullOrEmpty(txtCorpRegistrationNo.Text))
            {
                try
                {
                    seller.InsertSeller(new Vo.SellerVO(txtId.Text, txtPass.Text, txtComName.Text, txtAddr.Text, txtBossName.Text, txtPhone.Text, txtPostal.Text, txtEmail.Text, txtFax.Text, txtReturnAddr.Text, txtCorpRegistrationNo.Text));
                    MessageBox.Show("가입 완료!");
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("가입 실패.");
                }
            }
            else
            {
                MessageBox.Show("빈칸이 있으면 안됩니다.");
            }
        }

        private void txtChkPass_TextChanged(object sender, EventArgs e)
        {
            if (txtChkPass.Text != txtPass.Text)
            {
                lblchkPass.ForeColor = Color.Red;
                txtChkPass.ForeColor = Color.Red;
            }
            else
            {
                lblchkPass.ForeColor = Color.Black;
                txtChkPass.ForeColor = Color.Black;
            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            if(txtId.Text.Contains(" "))
            {
                MessageBox.Show("공백은 사용 할 수 없습니다.");
                txtId.Clear();
            }
        }

        private void btnSearchAddr_Click(object sender, EventArgs e)
        {
            //string uri = "http://www.juso.go.kr/addrlink/addrLinkApi.do" + "?query="
            FrmSearchAddr frm = new FrmSearchAddr();
            frm.ShowDialog();
            txtAddr.Text = FrmSearchAddr.roadAddr;
            txtPostal.Text = FrmSearchAddr.zipNo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
