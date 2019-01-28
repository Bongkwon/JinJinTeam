using JinTeamForAdmin.Vo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JinTeamForAdmin.Bus
{
    public partial class pro_Detail : Form
    {
        private Products_Vo pv;

        public pro_Detail()
        {
            InitializeComponent();
        }

        public pro_Detail(object pv) : this()
        {
            this.pv = (Products_Vo)pv;
        }

        private void pro_Detail_Load(object sender, EventArgs e)
        {
            lbl_catID.Text = pv.Cat_ID.ToString();
            lbl_discount.Text = pv.Pro_Discount.ToString();
            lbl_gender.Text = pv.Pro_Gender.ToString();
            lbl_hits.Text = pv.Pro_Hits.ToString();
            lbl_like.Text = pv.Pro_Name.ToString();
            lbl_m_comment.Text = pv.Main_Comment.ToString();
            lbl_m_image.Text = pv.Main_Image.ToString();
            lbl_name.Text = pv.Pro_Name.ToString();
            lbl_price.Text = pv.Pro_Price.ToString();
            lbl_proID.Text = pv.Pro_ID.ToString();
            lbl_sellno.Text = pv.Seller_NO.ToString();
            lbl_state.Text = pv.Pro_State.ToString();
            lbl_s_comment.Text = pv.Sub_Comment.ToString();

            if (pv.Pro_State)
            {
                rdo_Activation.Checked = true;
            }
            else
            {

            }

        }
    }
}
