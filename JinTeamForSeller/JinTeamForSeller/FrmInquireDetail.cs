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
    public partial class FrmInquireDetail : Form
    {
        InquireDao iDao = new InquireDao();
        DataGridViewRow dr;
        public FrmInquireDetail()
        {
            InitializeComponent();
        }
        public FrmInquireDetail(DataGridViewRow dr) : this()
        {
            this.dr = dr;
        }

        private void FrmInquireDetail_Load(object sender, EventArgs e)
        {
            lblInquireType.Text = dr.Cells["Inquire_type"].Value.ToString();
            lblInquireCusName.Text = dr.Cells["CusName"].Value.ToString();
            lblInquireStockId.Text = dr.Cells["StockID"].Value.ToString();
            lblInquireDate.Text = dr.Cells["InquireDate"].Value.ToString();
            lblInquireTitle.Text = dr.Cells["InquireTitle"].Value.ToString();
            //lblInquireBody.Text = dr.Cells["InquireBody"].Value.ToString();
            txtInquireBody.Text = dr.Cells["InquireBody"].Value.ToString();
            if (string.IsNullOrEmpty(dr.Cells["inquireImage"].Value.ToString()) == true)
            {
                ShowImg(dr.Cells["MainImage"].Value.ToString());
            }
            else
            {
                ShowImg(dr.Cells["inquireImage"].Value.ToString());                
            }
            txtReBody.Text = dr.Cells["Rebody"].Value.ToString();
        }

        private void ShowImg(string imgPath)
        {
            WebClient Downloader = new WebClient();

            Stream ImageStream = Downloader.OpenRead(imgPath);

            Bitmap DownloadImage = Bitmap.FromStream(ImageStream) as Bitmap;

            picInquireImg.Image = DownloadImage;
        }

        private void btnUpdateInquire_Click(object sender, EventArgs e)
        {
            if (!txtReBody.Text.Equals(dr.Cells["reBody"].Value.ToString()))
            {
                if (iDao.UpdateInquire_Seller((int)dr.Cells["inquireNo"].Value, txtReBody.Text))
                {
                    MessageBox.Show("답글 달기에 성공 했습니다.");
                    this.Close();
                }
            }
        }
    }
}
