using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JinTeamForSeller.Dao;

namespace JinTeamForSeller
{
    public partial class FrmReviewDetail : Form
    {
        ReviewDAO rDao = new ReviewDAO();
        DataGridViewRow dr;
        public FrmReviewDetail()
        {
            InitializeComponent();
        }
        public FrmReviewDetail(DataGridViewRow dr) : this()
        {
            this.dr = dr;
        }

        private void FrmReviewDetail_Load(object sender, EventArgs e)
        {
            lblReviewCusName.Text = dr.Cells["CusName"].Value.ToString();
            lblReviewDate.Text = dr.Cells["Re_Date"].Value.ToString();
            lblReviewStockId.Text = dr.Cells["Pro_ID"].Value.ToString();
            txtReviewBody.Text = dr.Cells["re_txt"].Value.ToString();
            if (string.IsNullOrEmpty(dr.Cells["re_image"].Value.ToString()) == true)
            {
                ShowImg(dr.Cells["MainImage"].Value.ToString());
            }
            else
            {
                ShowImg(dr.Cells["re_image"].Value.ToString());
            }
            txtReBody.Text = dr.Cells["Re_Comment"].Value.ToString();
        }

        private void ShowImg(string imgPath)
        {
            WebClient Downloader = new WebClient();

            Stream ImageStream = Downloader.OpenRead(imgPath);

            Bitmap DownloadImage = Bitmap.FromStream(ImageStream) as Bitmap;

            picInquireImg.Image = DownloadImage;
        }

        private void btnUpdateReview_Click(object sender, EventArgs e)
        {
            if (!txtReBody.Text.Equals(dr.Cells["Re_Comment"].Value.ToString()))
            {
                if (rDao.UpdateReview((int)dr.Cells["re_ID"].Value, txtReBody.Text))
                {
                    MessageBox.Show("답글 달기에 성공 했습니다.");
                    this.Close();
                }
            }
        }
    }
}
