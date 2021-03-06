﻿using JinTeamForAdmin.Dao;
using JinTeamForAdmin.Vo;
using JinTeamForAdmin.Bus;
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

        /// <summary>
        /// 화면 로드 시 발생하는 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Load</param>
        private void pro_Detail_Load(object sender, EventArgs e)
        {
            pb_Exit.BackgroundImage = Image.FromFile(Application.StartupPath + "/Resources/cancel.png");

            lbl_catID.Text = pv.Cat_ID.ToString();
            lbl_discount.Text = pv.Pro_Discount + "회";
            //lbl_gender.Text = pv.Pro_Gender.ToString();
            lbl_hits.Text = pv.Pro_Hits + "회";
            lbl_like.Text = pv.Pro_Like + "회";

            
            lbl_name.Text = pv.Pro_Name.ToString();
            lbl_price.Text = pv.Pro_Price.ToString();
            lbl_proID.Text = pv.Pro_ID.ToString();
            pictureBox1.ImageLocation = pv.Main_Image;

            lbl_sellno.Text = pv.Seller_NO.ToString();
            //lbl_state.Text = pv.Pro_State.ToString();

            if (pv.Sub_Comment.ToString() != "")
            {
                lbl_s_comment.Text = pv.Sub_Comment.ToString();
            }
            else
            {
                lbl_s_comment.Text = "작성한 내용이 없습니다.";
            }

            if (pv.Main_Comment.ToString() != "")
            {
                lbl_m_comment.Text = pv.Main_Comment.ToString();
            }
            else
            {
                lbl_m_comment.Text = "작성한 내용이 없습니다.";
            }
            

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

        /// <summary>
        /// 종료 버튼 클릭시 발생하는 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">버튼 클릭</param>
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// 확인 버튼 클릭시 발생하는 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">버튼 클릭</param>
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
                        ad.Pro_Temp = true;
                    }
                }
                else
                {
                    pro_Detail_Load(null, null);
                }
            }
            Close();

        }

        /// <summary>
        /// 상품 상태 변경 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">라디오 버튼 클릭</param>
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

        /// <summary>
        /// 픽쳐박스 클릭시 발생하는 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">픽쳐박스 클릭</param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {

            Process.Start(pv.Main_Image);
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
        /// 화면이동을 위한 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        /// <summary>
        /// 화면이동을 위한 이벤트 2
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
