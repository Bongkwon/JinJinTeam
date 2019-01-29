using JinTeamForAdmin.Bus;
using JinTeamForAdmin.Dao;
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

namespace JinTeamForSeller.Bus
{
    public partial class Admin_main : Form
    {
        //List<Customers_Vo> cus_lst;
        List<object> ob_lst;
        //List<Seller_Vo> sell_lst;

        string sp = "";
        string type_s = "";
        public Admin_main()
        {
            InitializeComponent();
            //cus_lst = new List<Customers_Vo>();
            ob_lst = new List<object>();
            //sell_lst = new List<Seller_Vo>();
        }


        private void seller목록ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rdo_all_seller.Checked = true;
            seller_changed(null, null);
        }

        private void products목록ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rdo_all_pro.Checked = true;
            pro_changed(null, null);
        }

        private void customer목록ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rdo_all_cus.Checked = true;
            cus_Changed(null, null);
        }

        private void cus_Changed(object sender, EventArgs e)
        {
            //dataGridView1.Columns["Cus_no"].HeaderText = "번호";
            //dataGridView1.Columns["cus_phone"].Visible = false;
            //MessageBox.Show(DateTime.Now.ToString());
            gb_seller.Visible = false;
            gb_pro.Visible = false;
            gb_cus.Visible = true;


            ob_lst.Clear();
            dataGridView1.DataSource = null;
            type_s = "cus";
            if (rdo_all_cus.Checked)
            {
                sp = "select_cus";
            }
            else
            {
                sp = "select_cus_withdrawal";
            }
            ob_lst = new Admin_Dao().Select_ob(sp, type_s);
            dataGridView1.DataSource = ob_lst;

            if (ob_lst.Count != 0)
            {
                dataGridView1.Columns["cus_pwd"].Visible = false;
                dataGridView1.Columns["cus_count"].Visible = false;
                dataGridView1.Columns["cus_nickname"].Visible = false;
                dataGridView1.Columns["cus_no"].HeaderText = "고객 번호";
                dataGridView1.Columns["cus_id"].HeaderText = "아이디";
                dataGridView1.Columns["cus_phone"].HeaderText = "전화번호";
                dataGridView1.Columns["cus_name"].HeaderText = "이름";
                dataGridView1.Columns["cus_gender"].HeaderText = "성별";
                dataGridView1.Columns["cus_age"].HeaderText = "나이";
                dataGridView1.Columns["cus_state"].HeaderText = "가입 상태";
                dataGridView1.Columns["withdrawal_date"].HeaderText = "탈퇴 날짜";
                dataGridView1.Columns["join_date"].HeaderText = "가입 날짜";



                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            }

        }

        private void pro_changed(object sender, EventArgs e)
        {
            gb_seller.Visible = false;
            gb_pro.Visible = true;
            gb_cus.Visible = false;


            ob_lst.Clear();
            dataGridView1.DataSource = null;
            type_s = "pro";
            if (rdo_all_pro.Checked)
            {
                sp = "select_pro";
            }
            else
            {
                sp = "select_pro_state_0";
            }

            ob_lst = new Admin_Dao().Select_ob(sp, type_s);
            dataGridView1.DataSource = ob_lst;

            if (ob_lst.Count != 0)
            {
                dataGridView1.Columns["cat_id"].Visible = false;
                dataGridView1.Columns["main_comment"].Visible = false;
                dataGridView1.Columns["sub_comment"].Visible = false;
                dataGridView1.Columns["main_image"].Visible = false;
                dataGridView1.Columns["pro_hits"].Visible = false;
                dataGridView1.Columns["pro_like"].HeaderText = "추천수";
                dataGridView1.Columns["pro_discount"].Visible = false;
                dataGridView1.Columns["pro_gender"].Visible = false;
                dataGridView1.Columns["pro_id"].HeaderText = "상품 번호";
                dataGridView1.Columns["seller_no"].HeaderText = "판매자 번호";
                dataGridView1.Columns["pro_name"].HeaderText = "상품 이름";
                dataGridView1.Columns["pro_price"].HeaderText = "상품 가격";
                dataGridView1.Columns["pro_state"].HeaderText = "상품 상태";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            }
        }

        private void seller_changed(object sender, EventArgs e)
        {
            gb_seller.Visible = true;
            gb_pro.Visible = false;
            gb_cus.Visible = false;

            dataGridView1.DataSource = null;
            ob_lst.Clear();
            type_s = "sel";
            if (rdo_all_seller.Checked)
            {
                sp = "select_seller";
            }
            else if (rdo_deactive_seller.Checked)
            {
                sp = "select_seller_join_0";
            }
            else
            {
                sp = "select_seller_state_0";
            }

            ob_lst = new Admin_Dao().Select_ob(sp, type_s);
            dataGridView1.DataSource = ob_lst;


            if (ob_lst.Count != 0)
            {
                dataGridView1.Columns["Seller_pwd"].Visible = false;
                dataGridView1.Columns["Seller_addr"].Visible = false;
                dataGridView1.Columns["Seller_postal"].Visible = false;
                dataGridView1.Columns["Seller_fax"].Visible = false;
                dataGridView1.Columns["return_addr"].Visible = false;
                dataGridView1.Columns["seller_no"].HeaderText = "판매자 번호";
                dataGridView1.Columns["seller_id"].HeaderText = "아이디";
                dataGridView1.Columns["seller_name"].HeaderText = "브랜드명";
                dataGridView1.Columns["seller_boss"].HeaderText = "대표";
                dataGridView1.Columns["seller_phone"].HeaderText = "전화번호";
                dataGridView1.Columns["seller_email"].HeaderText = "e-mail";
                dataGridView1.Columns["seller_state"].HeaderText = "판매자 상태";
                dataGridView1.Columns["join_state"].HeaderText = "가입 상태";
                dataGridView1.Columns["corporate_registration_no"].HeaderText = "사업증 번호";

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            }


            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sp = "delete_cus";
            if (new Admin_Dao().Delete_Gv(sp))
            {
                MessageBox.Show("정리 되었습니다");
                //Admin_main();
                cus_Changed(null, null);
            }
            else
            {
                MessageBox.Show("삭제 실패");
            }
        }

        private void Admin_main_Load(object sender, EventArgs e)
        {
            rdo_all_seller.Checked = true;
            seller_changed(null, null);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gb_seller.Visible)
            {
                seller_Detail sd = new seller_Detail(ob_lst[e.RowIndex]);
                sd.ShowDialog();
                //rdo_all_seller.Checked = true;
                seller_changed(null, null);
            }
            else if (gb_pro.Visible)
            {
                pro_Detail pd = new pro_Detail(ob_lst[e.RowIndex]);
                pd.ShowDialog();
                //rdo_all_pro.Checked = true;
                pro_changed(null, null);
            }
            else         // gb_cus.visible
            {
                cus_Detail cd = new cus_Detail(ob_lst[e.RowIndex]);
                cd.ShowDialog();
                //rdo_all_cus.Checked = true;
                cus_Changed(null, null);
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(colu);
        }
    }
}
