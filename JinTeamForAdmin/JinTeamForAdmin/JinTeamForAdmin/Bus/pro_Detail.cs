using JinTeamForAdmin.Dao;
using JinTeamForAdmin.Vo;
using JinTeamForSeller.Bus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JinTeamForAdmin.Bus
{
    public partial class Pro_Detail : Form
    {
        private Products_Vo pv;
        bool p_s;

        public Pro_Detail()
        {
            InitializeComponent();
        }

        public Pro_Detail(object pv,bool temp) : this()
        {
            this.pv = (Products_Vo)pv;

        }

        private void pro_Detail_Load(object sender, EventArgs e)
        {
            lbl_catID.Text = pv.Cat_ID.ToString();
            lbl_discount.Text = pv.Pro_Discount.ToString();
            //lbl_gender.Text = pv.Pro_Gender.ToString();
            lbl_hits.Text = pv.Pro_Hits.ToString();
            lbl_like.Text = pv.Pro_Like.ToString();

            lbl_m_comment.Text = pv.Main_Comment.ToString();
            lbl_name.Text = pv.Pro_Name.ToString();
            lbl_price.Text = pv.Pro_Price.ToString();
            lbl_proID.Text = pv.Pro_ID.ToString();
            pictureBox1.ImageLocation = pv.Main_Image;

            lbl_sellno.Text = pv.Seller_NO.ToString();
            //lbl_state.Text = pv.Pro_State.ToString();
            lbl_s_comment.Text = pv.Sub_Comment.ToString();

            if (pv.Pro_Gender == "A")
            {
                lbl_gender.Text = "혼복";
            }
            else if (pv.Pro_Gender == "M")
            {
                lbl_gender.Text = "남성복";
            }
            else
            {
                lbl_gender.Text = "여성복";
            }

            if (pv.Pro_State)
            {
                rdo_Activation.Checked = true;
                p_s = true;
            }
            else
            {
                rdo_Disabled.Checked = true;                
                p_s = false;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            string type_u = "pro";
            //temp = true;

            Products_Vo pv_sub = new Products_Vo()
            {
                Pro_ID = lbl_proID.Text,
                Pro_State = p_s
            };

            if (!pv.Equals(pv_sub))
            {
                var result = MessageBox.Show("수정 하시겠습니까?", "수정", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    if (new Admin_Dao().Update_state_ob(pv_sub, type_u))
                    {
                        MessageBox.Show("수정 성공");

                        Admin_main ad = (Admin_main)Owner;
                        ad.Temp = true;
                    }
                }
                else
                {
                    pro_Detail_Load(null, null);
                }
            }
            Close();

        }

        private void p_state_changed(object sender, EventArgs e)
        {
            
            if (rdo_Activation.Checked)
            {
                p_s = true;
                
            }
            else
            {
                
                p_s = false;
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

            Process.Start(pv.Main_Image);
        }
    }
}
