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
    public partial class FrmDetailPro : Form
    {
        Product tempPro = new Product();
        ProductDao pDao = new ProductDao();
        List<CatVO> cat_kinds;
        CatDAO cat = new CatDAO();
        DataGridViewRow row;
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
            Product pro = new Product();
            pro.Pro_ID = lblPro_No.Text;
            foreach (var item in cat_kinds)
            {
                if(item.Cat_Kind == cmbCatID.Text)
                {
                    pro.Cat_ID = item.Cat_ID;
                }
            }
            
            pro.Pro_Name = txtProName.Text;
            pro.Pro_Price = int.Parse(txtProPrice.Text);
            pro.Main_Comment = txtMainComment.Text;
            pro.Sub_Comment = txtSubComment.Text;
            pro.Main_Image = "";
            pro.Pro_Discount = int.Parse(txtDiscount.Text);
            pro.Pro_Gender = cmbGender.Text;

            //try
            //{
                if(pDao.UpdateProduct(pro))
                {
                    MessageBox.Show("수정 성공");
                }
                //else
                //{
                //    MessageBox.Show("수정 실패");
                //}
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("수정 실패");
            //}
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
        }
    }
}