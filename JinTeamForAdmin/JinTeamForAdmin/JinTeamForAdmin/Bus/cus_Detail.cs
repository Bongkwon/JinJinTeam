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
    public partial class Cus_Detail : Form
    {
        private Customers_Vo cv;

        public Cus_Detail()
        {
            InitializeComponent();
        }

        public Cus_Detail(object cv) : this()
        {
            this.cv = cv as Customers_Vo;
        }

        /// <summary>
        /// 확인 버튼 클릭시 발생하는 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">버튼 클릭</param>
        private void btn_ok_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// 화면 로드시 발생하는 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Load</param>
        private void cus_Detail_Load(object sender, EventArgs e)
        {
            pb_Exit.BackgroundImage = Image.FromFile(Application.StartupPath + "/Resources/cancel.png");
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

        /// <summary>
        /// 종료 버튼 클릭시 발생하는 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">버튼 클릭</param>
        private void pb_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        Point mousePoint;
        /// <summary>
        /// 화면 이동을 위한 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        /// <summary>
        /// 화면 이동을 위한 이벤트2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X), this.Top - (mousePoint.Y - e.Y));
            }
        }
    }
}
