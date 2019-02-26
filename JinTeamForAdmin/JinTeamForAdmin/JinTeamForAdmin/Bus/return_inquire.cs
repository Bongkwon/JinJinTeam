using JinTeamForAdmin.Dao;
using JinTeamForAdmin.Vo;
using JinTeamForSeller.Bus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JinTeamForAdmin.Bus
{
    public partial class Return_inquire : Form
    {
        private DataGridViewSelectedRowCollection selectedRows;

        public Return_inquire()
        {
            InitializeComponent();
        }

        public Return_inquire(DataGridViewSelectedRowCollection selectedRows) : this()
        {
            this.selectedRows = selectedRows;
        }

        private void return_inquire_Load(object sender, EventArgs e)
        {
            pb_Exit.BackgroundImage = Image.FromFile(Application.StartupPath + "/Resources/cancel.png");
            var cells = selectedRows[0].Cells;
            lbl_email.Text = cells[3].Value.ToString();
            lbl_name.Text = cells[2].Value.ToString();
            lbl_title.Text = "[re]" + cells[6].Value.ToString();
            //MessageBox.Show(cells[0].Value.ToString());

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {

            var result = MessageBox.Show(lbl_email.Text + "로 보내시겠습니까?", "메일", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                // mail 보내기
                // 보내는 메일주소
                MailAddress fromAddr = new MailAddress("gss0053@naver.com", "'JinTeam'", Encoding.UTF8);

                // 받는 메일주소           
                var toAddr = new MailAddress("sjm0850@naver.com", lbl_name.Text, Encoding.UTF8);
                //var toAddr = new MailAddress(lbl_email.Text, lbl_name.Text, Encoding.UTF8);
                // 얘로 나중에 바꿔야함


                // smtp.naver.com
                // Smtp 프로토콜 객체 생성
                // 이메일 보내기 허용 프로토콜 SmtpClient
                SmtpClient smtp = new SmtpClient("smtp.naver.com", 587);
                smtp.EnableSsl = true;  // SSL(Secure Service Line) 

                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential("gss0053", "thwjdals0053");

                // 메일 메세지 객체 생성
                MailMessage msg = new MailMessage(fromAddr, toAddr);
                msg.Subject = lbl_title.Text;
                msg.Body = txt_body.Text;
                msg.BodyEncoding = Encoding.UTF8;
                msg.SubjectEncoding = Encoding.UTF8;

                // 메일 보내기
                smtp.Send(msg);


                // DB업데이트
                Inquire_Admin_Vo ia_sub = new Inquire_Admin_Vo()
                {
                    Inquire_no = Int32.Parse(selectedRows[0].Cells[0].Value.ToString()),
                    //Cus_or_sell = selectedRows[0].Cells[5].Value.ToString(),
                    Re_body = txt_body.Text
                };


                if (new Admin_Dao().Update_state_ob(ia_sub, "inq"))
                {
                    MessageBox.Show("메일 발송완료");
                    Inquire_Admin_Detail iad = (Inquire_Admin_Detail)Owner;
                    iad.Temp = true;
                }            
            }
            else
            {
                MessageBox.Show("취소 하셨습니다.");
            }
            Close();
        }

        private void pb_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        Point mousePoint;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X), this.Top - (mousePoint.Y - e.Y));
            }
        }
    }
}
