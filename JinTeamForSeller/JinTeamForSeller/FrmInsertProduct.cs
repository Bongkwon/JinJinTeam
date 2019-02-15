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
    public partial class FrmInsertProduct : Form
    {
        CatDAO cat = new CatDAO();
        List<CatVO> cat_kinds;
        ProductDAO pDao = new ProductDAO();
        StockListDAO sDao = new StockListDAO();
        string originFile;
        string pathFile;
        Product pro;
        //Product pro = new Product();
        int imgIndex = 0;
        public FrmInsertProduct()
        {
            InitializeComponent();
        }

        private void FrmInsertProduct_Load(object sender, EventArgs e)
        {
            cat_kinds = cat.SelectCategory();
            foreach (var item in cat_kinds)
            {
                cmbCatID.Items.Add(item.Cat_Kind);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(openImg.ShowDialog() == DialogResult.OK)
            {
                pathFile = openImg.SafeFileName;
                originFile = openImg.FileName;
                proPic.Image = Image.FromFile(originFile);
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (!(string.IsNullOrEmpty(txtProID.Text) && string.IsNullOrEmpty(txtProName.Text) && string.IsNullOrEmpty(txtProPrice.Text) && string.IsNullOrEmpty(cmbCatID.Text) && string.IsNullOrEmpty(cmbGender.Text) && string.IsNullOrEmpty(txtMainComment.Text) && string.IsNullOrEmpty(txtSubComment.Text)))
            {
                string catId = "";
                string proname = Form1.CompanyName + "_" + txtProID.Text;
                foreach (var item in cat_kinds)
                {
                    if (item.Cat_Kind == cmbCatID.Text)
                    {
                        catId = item.Cat_ID;
                    }
                }
                if (string.IsNullOrEmpty(originFile))
                {
                    pro = new Product(proname, catId, Form1.CompanyNo, txtProName.Text, int.Parse(txtProPrice.Text), txtMainComment.Text, txtSubComment.Text, "", 0, 0, 0, cmbGender.Text, false);
                }
                else
                {
                    pro = new Product(proname, catId, Form1.CompanyNo, txtProName.Text, int.Parse(txtProPrice.Text), txtMainComment.Text, txtSubComment.Text, "https://jinweb.azurewebsites.net/img/" + pathFile, 0, 0, 0, cmbGender.Text, false);
                }
                if (chkSizeS.Checked)
                {
                    StockVO stock = new StockVO(Form1.CompanyName + "_" + txtProID.Text + "_" + "S", Form1.CompanyName + "_" + txtProID.Text, Form1.CompanyNo, "S", (int)numStockCount.Value);
                    sDao.InsertStock(stock);
                }
                if (chkSizeM.Checked)
                {
                    StockVO stock = new StockVO(Form1.CompanyName + "_" + txtProID.Text + "_" + "M", Form1.CompanyName + "_" + txtProID.Text, Form1.CompanyNo, "M", (int)numStockCount.Value);
                    sDao.InsertStock(stock);
                }
                if (chkSizeL.Checked)
                {
                    StockVO stock = new StockVO(Form1.CompanyName + "_" + txtProID.Text + "_" + "L", Form1.CompanyName + "_" + txtProID.Text, Form1.CompanyNo, "L", (int)numStockCount.Value);
                    sDao.InsertStock(stock);
                }
                if (chkSizeXL.Checked)
                {
                    StockVO stock = new StockVO(Form1.CompanyName + "_" + txtProID.Text + "_" + "XL", Form1.CompanyName + "_" + txtProID.Text, Form1.CompanyNo, "XL", (int)numStockCount.Value);
                    sDao.InsertStock(stock);
                }
                if (chkSizeXXL.Checked)
                {
                    StockVO stock = new StockVO(Form1.CompanyName + "_" + txtProID.Text + "_" + "XXL", Form1.CompanyName + "_" + txtProID.Text, Form1.CompanyNo, "XXL", (int)numStockCount.Value);
                    sDao.InsertStock(stock);
                }

                if (pDao.Insert_Product(pro))
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
                    MessageBox.Show("저장 성공 !");
                    this.Close();                    
                }
                else
                {
                    MessageBox.Show("저장 실패");
                }
            }
            else
            {
                MessageBox.Show("빈칸이 있으면 안됩니다.");
            }
        }
    }
}
