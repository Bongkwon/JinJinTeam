using JinTeamForAdmin.Vo;
using JinTeamForSeller.Bus;
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

        private void Inquire_Admin_Detail_Load(object sender, EventArgs e)
        {
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
                lbl_redate.Text = cells[10].Value.ToString();
            }
            
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            Return_inquire ri = new Return_inquire(selectedRows);
            ri.Owner = this;         
            ri.Show();

            Admin_main ad = (Admin_main)Owner;
            ad.Temp = this.temp;

            if (temp)
            {
                Close();
            }
            
        }
    }
}
