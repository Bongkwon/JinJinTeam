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
    public partial class FrmInquiry : Form
    {
        ReviewDAO rDAO = new ReviewDAO();
        public FrmInquiry()
        {
            InitializeComponent();
        }

        private void rdoInquireToSys_CheckedChanged(object sender, EventArgs e)
        {
            gViewInquiry.DataSource = null;
            btnInsertInquiry.Visible = true;
        }

        private void rdoReviewForPro_CheckedChanged(object sender, EventArgs e)
        {
            gViewInquiry.DataSource = null;
            btnInsertInquiry.Visible = false;
            gViewInquiry.DataSource = rDAO.SelectReviewForSeller(Form1.CompanyNo);
            gViewInquiry.Columns["re_like"].Visible = false;
            gViewInquiry.Columns["re_ID"].Visible = false;
            gViewInquiry.Columns["re_image"].Visible = false;            
        }

        private void rdoInquryOfProduct_CheckedChanged(object sender, EventArgs e)
        {
            gViewInquiry.DataSource = null;
            btnInsertInquiry.Visible = false;
            
        }

        private void FrmInquiry_Load(object sender, EventArgs e)
        {
            gViewInquiry.DataSource = null;
            gViewInquiry.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnInsertInquiry_Click(object sender, EventArgs e)
        {
            FrmInsertInqury frm = new FrmInsertInqury();
            frm.Show();
        }
    }
}
