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
        InquireDao iDao = new InquireDao();
        public FrmInquiry()
        {
            InitializeComponent();
        }

        private void rdoInquireToSys_CheckedChanged(object sender, EventArgs e)
        {
            gViewInquiry.DataSource = null;
            btnInsertInquiry.Visible = true;
            gViewInquiry.DataSource = iDao.SelectInquireAdminForSeller(Form1.CompanyNo);
            gViewInquiry.Columns["inquireImage"].Visible = false;
            gViewInquiry.Columns["MainImage"].Visible = false;
            gViewInquiry.Columns["InquireID"].Visible = false;
            gViewInquiry.Columns["CusNO"].Visible = false;
            gViewInquiry.Columns["stockID"].Visible = false;
            gViewInquiry.Columns["CusName"].Visible = false;

            gViewInquiry.Columns["InquireNo"].HeaderText = "문의 번호";
            gViewInquiry.Columns["Inquire_type"].HeaderText = "구분";
            gViewInquiry.Columns["InquireTitle"].HeaderText = "문의 제목";
            gViewInquiry.Columns["InquireBody"].HeaderText = "문의 내용";
            gViewInquiry.Columns["InquireDate"].HeaderText = "문의일";
            gViewInquiry.Columns["ReBody"].HeaderText = "답변";
            gViewInquiry.Columns["ReDate"].HeaderText = "답변 날짜";
        }

        private void rdoReviewForPro_CheckedChanged(object sender, EventArgs e)
        {
            gViewInquiry.DataSource = null;
            btnInsertInquiry.Visible = false;
            gViewInquiry.DataSource = rDAO.SelectReviewForSeller(Form1.CompanyNo);
            gViewInquiry.Columns["re_like"].Visible = false;
            gViewInquiry.Columns["re_ID"].Visible = false;
            gViewInquiry.Columns["re_image"].Visible = false;
            gViewInquiry.Columns["MainImage"].Visible = false;
            gViewInquiry.Columns["Cus_no"].Visible = false;
            //gViewInquiry.Columns["mainImage"].Visible = false;
            gViewInquiry.Columns["CusName"].HeaderText = "구매자명";
            gViewInquiry.Columns["Pro_ID"].HeaderText = "상품명";
            gViewInquiry.Columns["Re_Txt"].HeaderText = "리뷰 내용";
            gViewInquiry.Columns["Re_Date"].HeaderText = "리뷰 남긴날";
            gViewInquiry.Columns["Re_Comment"].HeaderText = "답변";
            gViewInquiry.Columns["Re_Commnet_Date"].HeaderText = "답변일";
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
            gViewInquiry.Columns["InquireID"].Visible = false;

            gViewInquiry.Columns["Inquire_type"].HeaderText = "문의 구분";
            gViewInquiry.Columns["InquireID"].Visible = false;
            gViewInquiry.Columns["CusName"].HeaderText = "문의자";
            gViewInquiry.Columns["StockId"].HeaderText = "재고번호";
            gViewInquiry.Columns["InquireTitle"].HeaderText = "문의 제목";
            gViewInquiry.Columns["InquireBody"].HeaderText = "문의 내용";
            gViewInquiry.Columns["InquireDate"].HeaderText = "문의 날짜";
            gViewInquiry.Columns["ReBody"].HeaderText = "답글";
            gViewInquiry.Columns["ReDate"].HeaderText = "답글 날짜";
        }

        private void FrmInquiry_Load(object sender, EventArgs e)
        {
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - this.Size.Width / 2, Screen.PrimaryScreen.Bounds.Height / 2 - this.Size.Height / 2);
            gViewInquiry.DataSource = null;
            gViewInquiry.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //gViewInquiry.DataSource = iDao.SelectInquireForSeller(Form1.CompanyNo);
            //gViewInquiry.Columns["cusNo"].Visible = false;
            //gViewInquiry.Columns["inquireNo"].Visible = false;
            //gViewInquiry.Columns["inquireImage"].Visible = false;
            //gViewInquiry.Columns["MainImage"].Visible = false;
            rdoInquryOfProduct_CheckedChanged(null, null);
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.BackColor = Color.FromArgb(143, 145, 147);
            //style.
            gViewInquiry.DefaultCellStyle = style;
            gViewInquiry.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(143, 145, 147);
            gViewInquiry.EnableHeadersVisualStyles = false;
        }

        private void btnInsertInquiry_Click(object sender, EventArgs e)
        {
            FrmInsertInqury frm = new FrmInsertInqury();
            frm.ShowDialog();            
            this.OnLoad(null);
            rdoInquryOfProduct.Checked = true;
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
