using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using JinTeamForSeller.Dao;
using JinTeamForSeller.Vo;

namespace JinTeamForSeller
{    
    public partial class Form1 : Form
    {
        public static int CompanyNo = 0;
        public static string CompanyName = "";
        List<WebPage> lstWeb = new List<WebPage>();
        List<Product> lstPro = new List<Product>();
        InquireDao idao = new InquireDao();
        public Form1()
        {
            InitializeComponent();
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - this.Size.Width / 2, Screen.PrimaryScreen.Bounds.Height / 2 - this.Size.Height / 2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            //string msg = idao.GetMsg();
            //if (!string.IsNullOrEmpty(msg))
            //{
            //    MessageBox.Show(msg);
            //}
        }

        private void ParsingDetail_Click(object sender, EventArgs e)
        {
            HtmlWeb web = new HtmlWeb();
            lstWeb.Clear();
            using (SqlConnection conn = new SqlConnection())
            {
                
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
                SqlCommand cmd = new SqlCommand();
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from webPages";

                var dr = cmd.ExecuteReader();
                
                while (dr.Read())
                {
                    lstWeb.Add(new WebPage(dr["webP"].ToString(), 1));
                }
                conn.Close();
            }

            foreach (var item in lstWeb)
            {
                string u = item.WebP;
                int proId = int.Parse(u.Substring(u.IndexOf("=") + 1, 4));
                var doc = web.Load(u);
                // textBox1.Text = doc.Text;

                // 대표 이미지
                string main_img = doc.DocumentNode.SelectNodes("//body/div/div/div/div/div/div/div/img").First().Attributes[0].Value;

                // 제품명
                string pro_Name = doc.DocumentNode.SelectNodes("//body/div/div/div/div/div/div/div/h2").First().InnerText;

                // 제품 가격
                int pro_Price = int.Parse(doc.DocumentNode.SelectNodes("//body/div/div/div/div/div/div/div/div/span").First().InnerText);

                lstPro.Add(new Product("CominFa_" + proId, pro_Name, pro_Price, main_img));

                // 사이즈
                //var docdet = doc.DocumentNode.SelectNodes("//optgroup/option");
                //foreach (var item in docdet)
                //{
                //    textBox1.Text += item.InnerText + "\r\n";
                //}

                //제품 이미지
                //var docImg = doc.DocumentNode.SelectNodes("//body/div/div/div/div/div/div/div/p/span/div/img");
                //foreach (var item in docImg)
                //{
                //    if (!item.Attributes[1].Value.Contains("유의"))
                //    {
                //        textBox1.Text += "http://www.comeintofashion.net" + item.Attributes[1].Value + "\r\n";
                //    }
                //}


                //textBox1.Text += doc3.First().Attributes[0].Value;

                //foreach (var item in lstWeb)
                //{
                //    string detailUrl = item.WebP;
                //    doc = web.Load(detailUrl);


                //}
            }
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
                SqlCommand cmd = new SqlCommand();
                foreach (var item in lstPro)
                {
                    cmd.Parameters.Clear();
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "insertProductsForTest";

                    cmd.Parameters.AddWithValue("pro_Id", item.Pro_ID);
                    cmd.Parameters.AddWithValue("pro_Name", item.Pro_Name);
                    cmd.Parameters.AddWithValue("pro_Price", item.Pro_Price);
                    cmd.Parameters.AddWithValue("main_Image", "http:" + item.Main_Image);
                    cmd.Parameters.AddWithValue("seller_no", 1);
                    cmd.Parameters.AddWithValue("cat_ID", "P05");
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                MessageBox.Show("저장 완료");
            }
        }
        private void ParsingWebPage_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(DateTime.Now.ToString().Remove(DateTime.Now.ToString().IndexOf('오'),2).Replace(" ","").Replace("-","").Replace(":",""));
            int cat = 71;            
            for (int i = 1; i < 4; i++)
            {


                string url = "http://www.comeintofashion.net/product/list.html?cate_no=" + cat + "&page=" + i;
                HtmlWeb web = new HtmlWeb();
                var doc = web.Load(url);
                //textBox1.Text = doc.Text;

                var doc2 = doc.DocumentNode.SelectNodes("//body/div/div/div/div/div/div");
                var doc3 = doc2[1].SelectNodes("//h6/a");



                foreach (var item in doc3)
                {
                    if (item.Attributes[0].Value.Contains("product"))
                    {
                        lstWeb.Add(new WebPage("http://www.comeintofashion.net" + item.Attributes[0].Value, cat));
                        //textBox1.Text += "http://www.comeintofashion.net" + item.Attributes[0].Value + "\r\n";
                    }
                }
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
                    SqlCommand cmd = new SqlCommand();
                    foreach (var item in lstWeb)
                    {
                        conn.Open();
                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "insert into webPages values('" + item.WebP + "'," + item.Category + ");";

                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }

                }
            }
            MessageBox.Show("Test");
        }

        private void button2_Click(object sender, EventArgs e) // 회원가입
        {
            new FrmInsertSeller().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection(ConfigurationManager.ConnectionStrings["azureCon"].ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sql;
            sql.Open();
            sql.Close();
        }

        private void button1_Click(object sender, EventArgs e) // 로그인
        {
            int a = 0;
            SellerInfo sInfo = new SellerInfo();
            SellerDAO seller = new SellerDAO();
            try
            {
                sInfo = seller.ChkLogin(txtId.Text, txtPwd.Text);                
            }
            catch (Exception)
            {
            }
            
            if (sInfo!=null)
            {
                CompanyNo = sInfo.Seller_No;
                CompanyName = sInfo.Seller_Name;
                new FrmDashBorad().Show();
                //new FrmMain().Show();
            }
            else
            {
                MessageBox.Show("비밀번호 또는 아이디가 틀립니다.");
            }
            //MessageBox.Show(CompanyName);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            List<Product> lstPro = new List<Product>();
            SqlConnection sql = new SqlConnection(ConfigurationManager.ConnectionStrings["azureCon"].ConnectionString);
            SqlCommand cmd = new SqlCommand();
            sql.Open();
            cmd.Connection = sql;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from dbo.products";
            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Product dc = new Product(dr["pro_ID"].ToString(), dr["cat_ID"].ToString(), int.Parse(dr["Seller_No"].ToString()), dr["pro_Name"].ToString(), int.Parse(dr["pro_Price"].ToString()), "", dr["Main_image"].ToString(), dr["pro_gender"].ToString(), (bool)dr["pro_state"]);
                dc.Sub_Comment = "";
                lstPro.Add(dc);
            }
            dr.Close();
            sql.Close();
            StockListDAO dao = new StockListDAO();
            foreach (var item in lstPro)
            {
                
                for (int i = 0; i < 5; i++)
                {
                    string stockSize = "";
                    switch (i)
                    {
                        case 0:
                            stockSize = "S";
                            break;
                        case 1:
                            stockSize = "M";
                            break;
                        case 2:
                            stockSize = "L";
                            break;
                        case 3:
                            stockSize = "XL";
                            break;
                        case 4:
                            stockSize = "XXL";
                            break;
                        default:
                            break;
                    }
                    dao.InsertStock(new Vo.StockVO(item.Pro_ID + "_" + stockSize, item.Pro_ID, item.Seller_NO, stockSize, 50));
                }
            }


            //SqlConnection insertConn = new SqlConnection(ConfigurationManager.ConnectionStrings["azureCon"].ConnectionString);
            //SqlCommand cmd2 = new SqlCommand();
            //cmd2.Connection = insertConn;
            //cmd2.CommandType = CommandType.StoredProcedure;
            //cmd2.CommandText = "insert_product";
            //foreach (var item in lstPro)
            //{
            //    cmd2.Parameters.Clear();
            //    insertConn.Open();
            //    SqlParameter[] sqlp =
            //        { (new SqlParameter("pro_id", item.Pro_ID)),
            //    (new SqlParameter("cat_id", item.Cat_ID)),
            //    (new SqlParameter("Seller_NO", item.Seller_NO)),
            //    (new SqlParameter("Pro_Name", item.Pro_Name)),
            //    (new SqlParameter("Pro_Price", item.Pro_Price)),
            //    (new SqlParameter("Main_Comment", item.Main_Comment)),
            //    (new SqlParameter("sub_comment", item.Sub_Comment)),
            //    (new SqlParameter("Main_Image", item.Main_Image)),
            //    (new SqlParameter("Pro_Gender", item.Pro_Gender))
            //    };
            //    cmd2.Parameters.AddRange(sqlp);
            //    cmd2.ExecuteNonQuery();
            //    insertConn.Close();
            //} 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmSearchID frm = new FrmSearchID();
            frm.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            List<Product> lstPro = new List<Product>();
            int i = 26;
            int page = 1;
            WebRequest req = WebRequest.Create("https://rollingus.com/category/top/" + i + "?page=" + page);
            WebResponse res = req.GetResponse();
            Stream stream = res.GetResponseStream();
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.Load(stream,Encoding.UTF8);
            HtmlNode root = doc.DocumentNode;


            var webNodes = root.SelectNodes("//body/div/div/div/div/div/div/ul/li/div/a");
            var imgNodes = root.SelectNodes("//body/div/div/div/div/div/div/ul/li/div/a/img");
            var nameNodes = root.SelectNodes("//body/div/div/div/div/div/div/ul/li/div/strong/a");
            var priceNodes = root.SelectNodes("//body/div/div/div/div/div/div/ul/li/div/ul");

            for (int j = 0; j < imgNodes.Count; j++)
            {
                string webUri = "https://rollingus.com" + webNodes[j].Attributes[0].Value;

                string proID = "Lollingu_" + webNodes[j].Attributes[1].Value.Substring(webNodes[j].Attributes[1].Value.LastIndexOf("_") + 1, 4);

                string mainImage = "http:" + imgNodes[j].Attributes[0].Value;

                string proName = nameNodes[j].ChildNodes[2].InnerText;

                int proPrice = int.Parse(priceNodes[j].ChildNodes[2].ChildNodes[3].InnerText.Replace(",", "").Remove(priceNodes[j].ChildNodes[2].ChildNodes[3].InnerText.LastIndexOf("w")-1).Trim());

                Product pro = new Product(proID, "T00", 21, proName, proPrice, "", "", mainImage, 0, 0, 0, "A", true, webUri);
                lstPro.Add(pro);                
            }
            ProductDAO pDao = new ProductDAO();
            foreach (var item in lstPro)
            {
                pDao.Insert_Product2(item);
            }            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            ProductDAO pdao = new ProductDAO();
            List<Product> lstpro = pdao.select_proEachSeller(2);
            foreach (var item in lstpro)
            {
                for (int i = 0; i < 5; i++)
                {
                    StockListDAO sDao = new StockListDAO();
                    switch (i)
                    {
                        case 0:                            
                            sDao.InsertStock(new StockVO(item.Pro_ID + "_" + "S", item.Pro_ID, 2, "S", 50));
                            break;
                        case 1:
                            sDao.InsertStock(new StockVO(item.Pro_ID + "_" + "M", item.Pro_ID, 2, "M", 50));
                            break;
                        case 2:
                            sDao.InsertStock(new StockVO(item.Pro_ID + "_" + "L", item.Pro_ID, 2, "L", 50));
                            break;
                        case 3:
                            sDao.InsertStock(new StockVO(item.Pro_ID + "_" + "XL", item.Pro_ID, 2, "XL", 50));
                            break;
                        case 4:
                            sDao.InsertStock(new StockVO(item.Pro_ID + "_" + "XXL", item.Pro_ID, 2, "XXL", 50));
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}