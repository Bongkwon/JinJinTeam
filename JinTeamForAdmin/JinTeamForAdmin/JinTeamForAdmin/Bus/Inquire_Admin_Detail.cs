using JinTeamForAdmin.Vo;
using JinTeamForAdmin.Bus;
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
    public partial class Inquire_Admin_Detail : Form
    {

        private bool temp;

        public bool Temp
        {
            get { return temp; }
            set { temp = value; }
        }

        private DataGridViewSelectedRowCollection selectedRows;

        public Inquire_Admin_Detail()
        {
            InitializeComponent();
        }

        public Inquire_Admin_Detail(DataGridViewSelectedRowCollection selectedRows) : this()
        {
            this.selectedRows = selectedRows;
        }

        /// <summary>
        /// 화면 로드 될시 발생하는 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Load</param>
        private void Inquire_Admin_Detail_Load(object sender, EventArgs e)
        {
            pb_Exit.BackgroundImage = Image.FromFile(Application.StartupPath + "/Resources/cancel.png");
            //Inquire_Admin_Vo ia = selectedRows as Inquire_Admin_Vo;
            var cells = selectedRows[0].Cells;
            txt_body.Text = selectedRows[0].Cells[7].Value.ToString();  // 본문
            txt_date.Text = selectedRows[0].Cells[8].Value.ToString();  // 날짜
            //txt_date.Text = DateTime.Parse(txt_date.Text).ToShortDateString();
            //txt_date.Text = txt_date.Text.Substring(txt_date.Text.IndexOf("-") + 1); // 02-07
            //txt_date.Text = txt_date.Text.Substring(txt_date.Text.IndexOf("-") + 1,2); // 01
            txt_name.Text = selectedRows[0].Cells[2].Value.ToString();
            txt_title.Text = selectedRows[0].Cells[6].Value.ToString();
            txt_type.Text = selectedRows[0].Cells[1].Value.ToString();
            lbl_inq_no.Text = cells[0].Value.ToString();
            txt_email.Text = cells[3].Value.ToString();
            if (cells[10].Value.ToString() == "")
            {
                lbl_redate.Text = "답변안한 글입니다.";
            }
            else
            {
                lbl_redate.Text = cells[11].Value.ToString();
            }
            
        }

        /// <summary>
        /// 종료 버튼 클릭시 발생하는 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">버튼 클릭</param>
        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// 답글 달기 버튼 클릭시 발생하는 이벤트 답글폼 출력
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">버튼 클릭</param>
        private void btn_return_Click(object sender, EventArgs e)
        {
            Return_inquire ri = new Return_inquire(selectedRows);
            ri.Owner = this;         
            ri.ShowDialog();

            Admin_main ad = (Admin_main)Owner;
            ad.Pro_Temp = this.temp;

            if (temp)
            {
                Close();
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
        /// <param name="e">버튼 클릭</param>
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        /// <summary>
        /// 화면 이동을 위한 이벤트2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">버튼 클릭</param>
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X), this.Top - (mousePoint.Y - e.Y));
            }
        }
    }
}
