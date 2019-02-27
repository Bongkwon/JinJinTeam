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
    public partial class FrmInsertInqury : Form
    {
        DataGridViewRow dr;
        InquireDao iDao = new InquireDao();
        string imgPath = "";
        public FrmInsertInqury()
        {
            InitializeComponent();
        }
        public FrmInsertInqury(DataGridViewRow dr) : this()
        {
            this.dr = dr;
        }

        private void btnInsertImg_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {                
                picInquire.Image = Image.FromFile(openFileDialog1.FileName);
                imgPath = openFileDialog1.FileName;
            }
        }

        private void FrmInsertInqury_Load(object sender, EventArgs e)
        {
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - this.Size.Width / 2, Screen.PrimaryScreen.Bounds.Height / 2 - this.Size.Height / 2);
            if (dr != null)
            {
                //cmbInquireType.Text = dr.Cells[]
                cmbInquireType.Enabled = false;
                this.btnInsertInquire.Visible = false;
                this.btnClose.Visible = true;
                this.txt_Re_Body.Visible = true;
                lblReBody.Visible = true;
                lblReDate.Visible = true;
                lblRe_Date.Visible = true;
                cmbInquireType.Text = dr.Cells["Inquire_Type"].Value.ToString();
                lblInquireDate.Text = dr.Cells["InquireDate"].Value.ToString();
                txtInquireTitle.Text = dr.Cells["InquireTitle"].Value.ToString();
                txtInquireBody.Text = dr.Cells["InquireBody"].Value.ToString();
                lblRe_Date.Text = dr.Cells["ReDate"].Value.ToString();
                txt_Re_Body.Text = dr.Cells["ReBody"].Value.ToString();
            }
            else
            {
                this.Size = new Size(683, 390);
                
            }
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

        private void btnInsertInquire_Click(object sender, EventArgs e)
        {
            InquireVO iVo = new InquireVO(this.cmbInquireType.Text, this.txtInquireTitle.Text, this.txtInquireBody.Text, imgPath, Form1.CompanyNo);
            iDao.InsertInquire_Seller(iVo);
        }
    }
}
