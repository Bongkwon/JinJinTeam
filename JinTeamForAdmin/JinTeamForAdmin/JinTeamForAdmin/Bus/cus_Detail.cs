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
    public partial class cus_Detail : Form
    {
        private Customers_Vo cv;

        public cus_Detail()
        {
            InitializeComponent();
        }

        public cus_Detail(object cv) : this()
        {
            this.cv = cv as Customers_Vo;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cus_Detail_Load(object sender, EventArgs e)
        {
            lbl_addr.Text = cv.Cus_addr.ToString();
            lbl_count.Text = cv.Cus_count.ToString();

            //lbl_gender.Text = cv.Cus_gender.ToString();
            lbl_ID.Text = cv.Cus_ID.ToString();
            lbl_join.Text = cv.Join_date.ToString();

            lbl_name.Text = cv.Cus_name.ToString();
            lbl_Nickname.Text = cv.Cus_Nickname.ToString();
            lbl_no.Text = cv.Cus_no.ToString();
            lbl_phone.Text = cv.Cus_phone.ToString();
            //lbl_pwd.Text = cv.Cus_pwd.ToString();
            lbl_pwd.Text = "안보여줄꺼지롱~";

            //lbl_state.Text = cv.Cus_state.ToString();
            lbl_withdrawal.Text = cv.Withdrawal_date.ToString();

            if (cv.Cus_gender)
            {
                lbl_gender.Text = "남자";
            }
            else
            {
                lbl_gender.Text = "여자";
            }

            if (cv.Cus_state)
            {
                lbl_state.Text = "가입 상태";
            }
            else
            {
                lbl_state.Text = "탈퇴 상태";
            }
        }
    }
}
