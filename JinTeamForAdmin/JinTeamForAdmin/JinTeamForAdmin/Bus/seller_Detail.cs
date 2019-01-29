using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JinTeamForAdmin.Dao;
using JinTeamForAdmin.Vo;

namespace JinTeamForAdmin.Bus
{
    public partial class seller_Detail : Form
    {
        private Seller_Vo sv;
        bool s_s;
        bool j_s;
        public seller_Detail()
        {
            InitializeComponent();
        }

        public seller_Detail(object sv) : this()
        {
            this.sv = (Seller_Vo)sv;
        }

        private void seller_Detail_Load(object sender, EventArgs e)
        {
            lbl_No.Text = sv.Seller_NO.ToString();
            lbl_addr.Text = sv.Seller_addr.ToString();
            lbl_boss.Text = sv.Seller_boss.ToString();
            lbl_corporate.Text = sv.Corporate_registration_no.ToString();
            lbl_email.Text = sv.Seller_email.ToString();

            lbl_fax.Text = sv.Seller_fax.ToString();
            lbl_ID.Text = sv.Seller_ID.ToString();         
            lbl_name.Text = sv.Seller_name.ToString();
            lbl_postal.Text = sv.Seller_postal.ToString();
            lbl_pwd.Text = sv.Seller_pwd.ToString();

            lbl_return.Text = sv.Return_addr.ToString();
            lbl_phone.Text = sv.Seller_phone.ToString();

            //lbl_state.Text = sv.Seller_state.ToString();
            //lbl_join.Text = sv.Join_state.ToString();

            if (sv.Seller_state)
            {
                rdo_on.Checked = true;
                s_s = true;
            }
            else
            {
                rdo_off.Checked = true;
                s_s = false;
            }

            if (sv.Join_state)
            {
                rdo_receive.Checked = true;
                j_s = true;
            }
            else
            {
                rdo_unreceive.Checked = true;
                j_s = false;
            }

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {

            Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            string type_u = "seller";
            Seller_Vo sv_sub = new Seller_Vo()
            {
                Seller_NO = Int32.Parse(lbl_No.Text),
                Seller_state = s_s,
                Join_state = j_s
            };
            if (!sv.Equals(sv_sub))
            {
                var result = MessageBox.Show("수정 하시겠습니까?","수정",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    if (new Admin_Dao().Update_ob(sv_sub,type_u))
                    {
                        MessageBox.Show("수정 성공");
                    }
                }
                else
                {
                    seller_Detail_Load(null, null);
                }
            }
            Close();
        }

        private void s_state_changed(object sender, EventArgs e)
        {
            if (rdo_on.Checked)
            {
                s_s = true;
            }
            else
            {
                s_s = false;
            }
        }

        private void j_state_changed(object sender, EventArgs e)
        {
            if (rdo_receive.Checked)
            {
                j_s = true;
            }
            else
            {
                j_s = false;
            }
        }
    }
}
