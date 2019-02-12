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
    public partial class FrmInsertInqury : Form
    {
        DataGridViewRow dr;
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
            }
        }

        private void FrmInsertInqury_Load(object sender, EventArgs e)
        {
            if (dr != null)
            {
                //cmbInquireType.Text = dr.Cells[]
                cmbInquireType.Enabled = false;
                this.btnInsertInquire.Visible = false;
                this.btnClose.Visible = true;
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
                this.Size = new Size(693, 343);
                
            }
        }
    }
}
