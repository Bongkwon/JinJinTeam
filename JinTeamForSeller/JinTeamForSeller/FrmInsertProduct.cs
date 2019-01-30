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
    public partial class FrmInsertProduct : Form
    {
        CatDAO cat = new CatDAO();
        List<CatVO> cat_kinds;
        ProductDao pDao = new ProductDao();
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
                string imgPath = openImg.FileName;
                Image img = Image.FromFile(imgPath);
                imgLst.Images.Add(img);
                proPic.Image = imgLst.Images[imgIndex];
                lblImgNo.Text = imgIndex + 1 + " / " + imgLst.Images.Count;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txtProID.Text) && string.IsNullOrEmpty(txtProName.Text) && string.IsNullOrEmpty(txtProPrice.Text) && string.IsNullOrEmpty(cmbCatID.Text) && string.IsNullOrEmpty(cmbGender.Text) && string.IsNullOrEmpty(txtMainComment.Text) && string.IsNullOrEmpty(txtSubComment.Text)))
            {
                string catId = "";
                foreach (var item in cat_kinds)
                {
                    if (item.Cat_Kind == cmbCatID.Text)
                    {
                        catId = item.Cat_ID;
                    }
                }
                Product pro = new Product(Form1.CompanyName + "_" + txtProID.Text, catId, Form1.CompanyNo, txtProName.Text, int.Parse(txtProPrice.Text), txtMainComment.Text, txtSubComment.Text, "", 0, 0, 0, cmbGender.Text, false);

                if (pDao.Insert_Product(pro))
                {
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
