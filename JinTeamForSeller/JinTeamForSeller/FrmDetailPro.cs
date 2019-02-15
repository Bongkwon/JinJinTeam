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
using JinTeamForSeller.Vo;
namespace JinTeamForSeller
{
    public partial class FrmDetailPro : Form
    {
        Product tempPro = new Product();
        ProductDAO pDao = new ProductDAO();
        List<CatVO> cat_kinds;
        CatDAO cat = new CatDAO();
        DataGridViewRow row;
        List<StockVO> lstStock = new List<StockVO>();
        StockListDAO stockDao = new StockListDAO();
        StockVO stock;
        string originFile;
        string pathFile;

        public FrmDetailPro()
        {
            InitializeComponent();
        }
        public FrmDetailPro(DataGridViewRow row) : this()
        {
            this.row = row;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            stock = null;
            Product pro = new Product();
            pro.Pro_ID = lblPro_No.Text;
            foreach (var item in cat_kinds)
            {
                if (item.Cat_Kind == cmbCatID.Text)
                {
                    pro.Cat_ID = item.Cat_ID;
                }
            }

            pro.Pro_Name = txtProName.Text;
            pro.Pro_Price = int.Parse(txtProPrice.Text);
            pro.Main_Comment = txtMainComment.Text;
            pro.Sub_Comment = txtSubComment.Text;
            if (proPic.Image != null)
            {
                pro.Main_Image = "https://jinweb.azurewebsites.net/img/" + pathFile;
            }
            else if (proPic.Image != null && !string.IsNullOrEmpty(row.Cells["main_image"].Value.ToString()))
            {
                pro.Main_Image = row.Cells["main_image"].Value.ToString();
            }
            else if (proPic.Image == null)
            {
                pro.Main_Image = "";
            }
            pro.Pro_Discount = int.Parse(txtDiscount.Text);
            pro.Pro_Gender = cmbGender.Text;

            foreach (var item in lstStock)
            {
                if (lblPro_No.Text + "_" + cmbSize.Text == item.Stock_ID)
                {
                    stock = item;
                    break;
                }
            }

            if (cmbSize.SelectedIndex > -1 && stock != null)
            {
                stock.Stock_Count = (int)numStockCount.Value;
            }

            if (string.IsNullOrEmpty(cmbSize.Text))
            {
                //try
                {
                    pDao.UpdateProduct(pro);
                    MessageBox.Show("수정 성공");
                }
                //catch (Exception)
                {
                    //MessageBox.Show("수정 실패");
                }
            }
            else
            {
                try
                {
                    if (pDao.UpdateProduct(pro))
                    {
                        if (stockDao.UpdateStock(stock))
                        {
                            UploadImgToFTP();

                            MessageBox.Show("수정 성공");
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("수정 실패");
                }
            }
            this.Close();
        }

        private void UploadImgToFTP()
        {
            // Get the object used to communicate with the server.                
            var request = (FtpWebRequest)WebRequest.Create(@"ftp://waws-prod-ps1-001.ftp.azurewebsites.windows.net/site/wwwroot/img/" + pathFile);
            request.Method = WebRequestMethods.Ftp.UploadFile;

            // This example assumes the FTP site uses anonymous logon.
            request.Credentials = new NetworkCredential(@"JinWeb\$JinWeb", "2SdrxPjgTjN0kJv6djRdLuYAJofn0B2pZAZPL1f081PigdFh9KcfadcCWBEw");

            // Copy the contents of the file to the request stream.
            byte[] fileContents;
            using (StreamReader sourceStream = new StreamReader(originFile))
            {
                fileContents = File.ReadAllBytes(originFile);
                //Encoding.UTF8.GetBytes(sourceStream.ReadToEnd());
            }


            request.ContentLength = fileContents.Length;

            using (Stream requestStream = request.GetRequestStream())
            {
                requestStream.Write(fileContents, 0, fileContents.Length);
            }
            FtpWebResponse resp = (FtpWebResponse)request.GetResponse();
        }

        private void FrmDetailPro_Load(object sender, EventArgs e)
        {
            cat_kinds = cat.SelectCategory();
            foreach (var item in cat_kinds)
            {
                cmbCatID.Items.Add(item.Cat_Kind);
            }
            string cat_kind = "";
            

            tempPro.Pro_ID = row.Cells["pro_ID"].Value.ToString();
            tempPro.Cat_ID = row.Cells["cat_ID"].Value.ToString();
            tempPro.Seller_NO = (int)row.Cells["seller_no"].Value;
            tempPro.Pro_Name = row.Cells["pro_name"].Value.ToString();
            tempPro.Pro_Price = (int)row.Cells["pro_price"].Value;
            tempPro.Main_Comment = row.Cells["main_comment"].Value.ToString();
            tempPro.Sub_Comment = row.Cells["sub_comment"].Value.ToString();
            tempPro.Main_Image = row.Cells["main_image"].Value.ToString();
            tempPro.Pro_Discount = (int)row.Cells["pro_discount"].Value;
            tempPro.Pro_Gender = row.Cells["pro_gender"].Value.ToString();            
            tempPro.Main_Image = row.Cells["main_image"].Value.ToString();
            foreach (var item in cat_kinds)
            {
                if(item.Cat_ID == tempPro.Cat_ID)
                {
                    cat_kind = item.Cat_Kind;
                }
            }

            lblPro_No.Text = tempPro.Pro_ID;
            txtDiscount.Text = tempPro.Pro_Discount.ToString();
            txtMainComment.Text = tempPro.Main_Comment;
            txtProName.Text = tempPro.Pro_Name;
            txtProPrice.Text = tempPro.Pro_Price.ToString();
            txtSubComment.Text = tempPro.Sub_Comment;
            cmbCatID.Text = cat_kind;
            cmbGender.Text = tempPro.Pro_Gender;


            if (string.IsNullOrEmpty(tempPro.Main_Image) == false) 
            {
                WebClient Downloader = new WebClient();

                Stream ImageStream = Downloader.OpenRead(tempPro.Main_Image);

                Bitmap DownloadImage = Bitmap.FromStream(ImageStream) as Bitmap;

                proPic.Image = DownloadImage;
            }
            lstStock = stockDao.Select_Stocks(lblPro_No.Text);
        }
        
        private void cmbSize_SelectedIndexChanged(object sender, EventArgs e)
        {            
            foreach (var item in lstStock)
            {
                if (item.Stock_ID == lblPro_No.Text + "_" + cmbSize.Text) 
                {
                    numStockCount.Value = item.Stock_Count;
                    //MessageBox.Show(item.Pro_Id + "_" + cmbSize.Text);
                    break;
                }
            }
        }

        private void btnInsertStock_Click(object sender, EventArgs e)
        {
            StockVO stock = new StockVO(lblPro_No.Text + "_" + cmbSize.Text, lblPro_No.Text, Form1.CompanyNo, cmbSize.Text, (int)numStockCount.Value);

            try
            {
                stockDao.InsertStock(stock);
                MessageBox.Show("사이즈 추가 성공!");
            }
            catch (Exception)
            {
                MessageBox.Show("이미 존재하는 사이즈 입니다.");
            }
        }

        private void btnImgInsert_Click(object sender, EventArgs e)
        {
            if (openImg.ShowDialog() == DialogResult.OK)
            {
                pathFile = openImg.SafeFileName;
                originFile = openImg.FileName;
                proPic.Image = Image.FromFile(originFile);
            }
        }
    }
}