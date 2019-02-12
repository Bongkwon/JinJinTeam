﻿using System;
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
        InquireDao iDao = new InquireDao();
        public FrmInquiry()
        {
            InitializeComponent();
        }

        private void rdoInquireToSys_CheckedChanged(object sender, EventArgs e)
        {
            gViewInquiry.DataSource = null;
            btnInsertInquiry.Visible = true;
            gViewInquiry.DataSource = iDao.SelectInquireAdminForSeller(Form1.CompanyNo, "S");
        }

        private void rdoReviewForPro_CheckedChanged(object sender, EventArgs e)
        {
            gViewInquiry.DataSource = null;
            btnInsertInquiry.Visible = false;
            gViewInquiry.DataSource = rDAO.SelectReviewForSeller(Form1.CompanyNo);
            gViewInquiry.Columns["re_like"].Visible = false;
            gViewInquiry.Columns["re_ID"].Visible = false;
            gViewInquiry.Columns["re_image"].Visible = false;
            //gViewInquiry.Columns["mainImage"].Visible = false;
        }

        private void rdoInquryOfProduct_CheckedChanged(object sender, EventArgs e)
        {
            gViewInquiry.DataSource = null;
            btnInsertInquiry.Visible = false;
            gViewInquiry.DataSource = iDao.SelectInquireForSeller(Form1.CompanyNo);
            gViewInquiry.Columns["cusNo"].Visible = false;
            gViewInquiry.Columns["inquireNo"].Visible = false;
            gViewInquiry.Columns["inquireImage"].Visible = false;
            gViewInquiry.Columns["MainImage"].Visible = false;
        }

        private void FrmInquiry_Load(object sender, EventArgs e)
        {
            gViewInquiry.DataSource = null;
            gViewInquiry.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gViewInquiry.DataSource = iDao.SelectInquireForSeller(Form1.CompanyNo);
            gViewInquiry.Columns["cusNo"].Visible = false;
            gViewInquiry.Columns["inquireNo"].Visible = false;
            gViewInquiry.Columns["inquireImage"].Visible = false;
            gViewInquiry.Columns["MainImage"].Visible = false;
        }

        private void btnInsertInquiry_Click(object sender, EventArgs e)
        {
            FrmInsertInqury frm = new FrmInsertInqury();
            frm.ShowDialog();            
            this.OnLoad(null);
        }

        private void gViewInquiry_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex<gViewInquiry.Rows.Count)
            {
                if(rdoInquryOfProduct.Checked == true)
                {
                    FrmInquireDetail frm = new FrmInquireDetail(gViewInquiry.Rows[e.RowIndex]);
                    frm.ShowDialog();
                    this.OnLoad(null);
                }
                else if(rdoReviewForPro.Checked == true)
                {
                    FrmReviewDetail frm = new FrmReviewDetail(gViewInquiry.Rows[e.RowIndex]);
                    frm.ShowDialog();
                    rdoReviewForPro_CheckedChanged(null, null);                    
                }
                else if(rdoInquireToSys.Checked == true)
                {
                    FrmInsertInqury frm = new FrmInsertInqury(gViewInquiry.Rows[e.RowIndex]);
                    frm.ShowDialog();
                    rdoInquireToSys_CheckedChanged(null, null);
                }
            }
        }
    }
}
