using JinTeamForAdmin.Bus;
using JinTeamForAdmin.Dao;
using JinTeamForAdmin.Vo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace JinTeamForAdmin.Bus
{
    public partial class Admin_main : Form
    {
        List<Sales_manager_Vo> sales_lst;
        List<Sales_manager_Vo> sales_sub_lst;
        List<Customers_Vo> cus_lst;
        List<object> ob_lst;
        List<Seller_Vo> sell_lst;
        List<Products_Vo> pro_lst;
        bool switch_pro = false;
        List<TaxBill_Vo> tax_lst;
        bool tax_switch = true;
        
        List<Inquire_Admin_Vo> inq_lst;
        List<Inquire_Admin_Vo> inq_lst_sub;
        Sales_Manager sm;

        string sp = "";
        string type_s = "";

        private bool pro_temp;

        public bool Pro_Temp
        {
            get { return pro_temp; }
            set { pro_temp = value; }
        }
        
        private bool sales_temp;

        public bool Sales_Temp
        {
            get { return sales_temp; }
            set { sales_temp = value; }
        }


        public Admin_main()
        {
            InitializeComponent();
            cus_lst = new List<Customers_Vo>();
            ob_lst = new List<object>();
            sell_lst = new List<Seller_Vo>();
            pro_lst = new List<Products_Vo>();
            tax_lst = new List<TaxBill_Vo>();
            inq_lst = new List<Inquire_Admin_Vo>();
            inq_lst_sub = new List<Inquire_Admin_Vo>();
            sales_lst = new List<Sales_manager_Vo>();
            sales_sub_lst = new List<Sales_manager_Vo>();
        }


        private void Admin_main_Load(object sender, EventArgs e)
        {           
            this.Location = new Point(100, 100);

            pl_main_Click(null, null);
            change_panel();

            pb_refresh.BackgroundImage = Image.FromFile(Application.StartupPath + "/Resources/refresh-arrow.png");
            pb_Exit.BackgroundImage = Image.FromFile(Application.StartupPath + "/Resources/cancel.png");
        }


        private void change_panel()
        {
            pn1.BackColor = Color.White;
            pn2.BackColor = Color.White;
            pn3.BackColor = Color.White;
            pn4.BackColor = Color.White;
            pn5.BackColor = Color.White;
            pn6.BackColor = Color.White;
            pn7.BackColor = Color.White;
            if (gb_main_GV.Visible)
            {
                if (gb_seller.Visible)
                {
                    pn1.BackColor = Color.Black;
                }
                else if (gb_cus.Visible)
                {
                    pn2.BackColor = Color.Black;
                }
                else if (gb_pro.Visible)
                {
                    pn3.BackColor = Color.Black;
                }
                else if (tax_switch)
                {
                    pn4.BackColor = Color.Black;
                }
                else if (gb_inq.Visible)
                {
                    pn5.BackColor = Color.Black;
                }
            }
            else if (gb_dashboard.Visible)
            {
                pn7.BackColor = Color.Black;
            }
            
            

            if (Sales_Temp)
            {
                pn6.BackColor = Color.Black;
            }
            else
            {
                pn6.BackColor = Color.White;
            }


        }

        private void pl_main_Click(object sender, EventArgs e)
        {
            gb_dashboard.Visible = true;
            gb_main_GV.Visible = false;
            
            if (gb_dashboard.Visible)
            {
                int inq=0, pay=0, pc=0, sc = 0;
                type_s = "dashboard";
                sp = "Select_T_Inq_count";
                ob_lst = new Admin_Dao().Select_ob(sp, type_s);
                foreach (int item in ob_lst)
                {
                    inq = item;
                }
                sp = "Select_T_pay_count";
                ob_lst = new Admin_Dao().Select_ob(sp, type_s);
                foreach (int item in ob_lst)
                {
                    pay = item;
                }
                sp = "Select_Sel_join_count";
                ob_lst = new Admin_Dao().Select_ob(sp, type_s);
                foreach (int item in ob_lst)
                {
                    sc = item;
                }
                sp = "Select_Pro_state_count";
                ob_lst = new Admin_Dao().Select_ob(sp, type_s);
                foreach (int item in ob_lst)
                {
                    pc = item;
                }
                lbl_T_inq.Text = inq + "건";
                lbl_T_pay.Text = pay + "건";
                lbl_pro_state.Text = pc + "개";
                lbl_sell_state.Text = sc + "명";


                change_panel();

                sales_lst.Clear();
                sales_sub_lst.Clear();

                ob_lst = new Admin_Dao().Select_ob("Select_sales", "sal");
                foreach (var item in ob_lst)
                {
                    sales_lst.Add((Sales_manager_Vo)item);
                }

                var result = from sales in sales_lst
                             orderby sales.Pay_date descending
                             group sales by sales.Pay_date;
                foreach (var itemG in result)
                {
                    int price = 0;
                    int count = 0;
                    string name = "";
                    int mm = 0;
                    //textBox1.Text += itemG.Key + " 금액 : ";

                    foreach (var itemK in itemG)
                    {
                        price += (itemK.Pay_price * itemK.Pay_count);
                        
                        count += 1;
                        name = itemK.Seller_ID;
                        mm = Int32.Parse(itemK.Pay_date_m);
                    }

                    if (sales_sub_lst.Count < 3)
                    {
                        sales_sub_lst.Add(new Sales_manager_Vo
                        {
                            Seller_ID = name,
                            Pay_price = price,
                            Pay_count = count,
                            Pay_date = itemG.Key.Substring(5),
                            Pay_date_m = mm.ToString()
                        });
                    }
                }

                sales_sub_lst.Reverse();

                chart_sales.Series[0].Points.DataBind(sales_sub_lst, "pay_date", "Pay_price", null);
                chart_sales.Series[0].Name = "액수";
            }
        }

        private void seller목록ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rdo_all_seller.Checked = true;
            seller_changed(null, null);
            change_panel();
        }

        private void products목록ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rdo_all_pro.Checked = true;
            pro_changed(null, null);
            change_panel();

            if (sm != null)
            {
                sm.Close();
            }
        }

        private void customer목록ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rdo_all_cus.Checked = true;
            cus_Changed(null, null);
            change_panel();
        }

        private void 결제정보세금계산서출력ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pay_changed();
            change_panel();
        }

        private void 문의내역ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rd_sel_inq.Checked = true;
            inq_changed(null, null);
            change_panel();
        }

        private void 매출관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //gb_seller.Visible = false;
            //gb_pro.Visible = false;
            //gb_cus.Visible = false;
            //tax_switch = false;
            //gb_inq.Visible = false;
            Sales_Temp = true;
            //MessageBox.Show(sales_temp.ToString());
            if (Sales_Temp)
            {
                change_panel();
            }

            //change_panel();

            Point p = new Point(this.Location.X + this.Size.Width, this.Location.Y);
            sm = new Sales_Manager(p);
            sm.Owner = this;

            //Sales_Manager sm = new Sales_Manager();
            sm.ShowDialog();

            //MessageBox.Show(Sales_Temp.ToString());
            if (!Sales_Temp)
            {               
                change_panel();
            }

        }


        private void cb_inquire_TextChanged(object sender, EventArgs e)
        {
            inq_lst_sub.Clear();

            string selectedItem = cb_inquire.SelectedItem.ToString();
            if (selectedItem == "전체보기")
            {
                main_GV.DataSource = null;
                main_GV.DataSource = inq_lst;
            }
            else
            {
                foreach (var item in inq_lst)
                {
                    if (item.Inquire_type == selectedItem)
                    {
                        inq_lst_sub.Add(item);
                    }
                }
                main_GV.DataSource = null;
                main_GV.DataSource = inq_lst_sub;
            }

            Inq_GV();

        }

        private void common_cb()
        {
            cb_inquire.Items.Clear();

            cb_inquire.Items.Add("전체보기");
            cb_inquire.Items.Add("회원문의");
            cb_inquire.Items.Add("사용문의");
            cb_inquire.Items.Add("시스템");
            cb_inquire.Items.Add("기타");
        }


        private void Pay_changed()
        {
            gb_main_GV.Visible = true;
            gb_dashboard.Visible = false;
            gb_inq.Visible = false;
            gb_seller.Visible = false;
            gb_pro.Visible = false;
            gb_cus.Visible = false;
            tax_switch = true;
            //sales_switch = false;

            ob_lst.Clear();
            tax_lst.Clear();
            main_GV.DataSource = null;
            type_s = "pay";
            sp = "select_taxBill";
            ob_lst = new Admin_Dao().Select_ob(sp, type_s);
            foreach (var item in ob_lst)
            {
                tax_lst.Add((TaxBill_Vo)item);
            }

            pay_GV();
        }

        private void inq_changed(object sender, EventArgs e)
        {
            gb_main_GV.Visible = true;
            gb_dashboard.Visible = false;
            ob_lst.Clear();
            inq_lst.Clear();
            main_GV.DataSource = null;
            type_s = "inq";

            gb_seller.Visible = false;
            gb_pro.Visible = false;
            gb_cus.Visible = false;
            tax_switch = false;
            gb_inq.Visible = true;
            //sales_switch = false;


            if (rd_cus_inq.Checked)
            {
                common_cb();
                cb_inquire.Items.Add("결제문의");
                sp = "select_cus_inq";
            }
            else if (rd_sel_inq.Checked)
            {
                common_cb();
                cb_inquire.Items.Add("피드백");

                sp = "select_sel_inq";


            }


            ob_lst = new Admin_Dao().Select_ob(sp, type_s);

            foreach (Inquire_Admin_Vo item in ob_lst)
            {
                inq_lst.Add(item);
            }

            //cb_inquire_TextChanged(null, null);

            main_GV.DataSource = inq_lst;

            Inq_GV();
            //rd_all_inq.Checked = true;
            cb_inquire.SelectedIndex = 0;

        }

        private void cus_Changed(object sender, EventArgs e)
        {
            gb_main_GV.Visible = true;
            gb_dashboard.Visible = false;
            //dataGridView1.Columns["Cus_no"].HeaderText = "번호";
            //dataGridView1.Columns["cus_phone"].Visible = false;
            //MessageBox.Show(DateTime.Now.ToString());
            gb_seller.Visible = false;
            gb_pro.Visible = false;
            gb_cus.Visible = true;
            tax_switch = false;
            gb_inq.Visible = false;
            //sales_switch = false;

            ob_lst.Clear();
            cus_lst.Clear();
            main_GV.DataSource = null;
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

            foreach (var item in ob_lst)
            {
                cus_lst.Add((Customers_Vo)item);
            }
            cus_GV();

        }

        private void pro_changed(object sender, EventArgs e)
        {
            gb_main_GV.Visible = true;
            gb_dashboard.Visible = false;
            gb_seller.Visible = false;
            gb_pro.Visible = true;
            gb_cus.Visible = false;
            tax_switch = false;
            gb_inq.Visible = false;
            //sales_switch = false;

            ob_lst.Clear();
            pro_lst.Clear();
            main_GV.DataSource = null;
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

            foreach (var item in ob_lst)
            {
                pro_lst.Add((Products_Vo)item);
            }
            pro_GV();

        }

        private void seller_changed(object sender, EventArgs e)
        {
            gb_main_GV.Visible = true;
            gb_dashboard.Visible = false;
            gb_seller.Visible = true;
            gb_pro.Visible = false;
            gb_cus.Visible = false;
            tax_switch = false;
            gb_inq.Visible = false;
            //sales_switch = false;

            main_GV.DataSource = null;
            ob_lst.Clear();
            sell_lst.Clear();
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

            foreach (var item in ob_lst)
            {
                sell_lst.Add((Seller_Vo)item);
            }

            sell_GV();

        }


        private void Inq_GV()
        {
            main_GV.Columns["inquire_image"].Visible = false;
            main_GV.Columns["inquire_body"].Visible = false;
            main_GV.Columns["inquire_email"].Visible = false;
            main_GV.Columns["cus_no"].HeaderText = "고객 번호";
            main_GV.Columns["seller_no"].HeaderText = "판매자 번호";
            if (rd_sel_inq.Checked)
            {
                main_GV.Columns["cus_no"].Visible = false;
                main_GV.Columns["seller_no"].Visible = true;
            }
            else
            {
                main_GV.Columns["cus_no"].Visible = true;
                main_GV.Columns["seller_no"].Visible = false;
            }

            //main_GV.Columns["inquire_id"].Visible = false;
            main_GV.Columns["re_body"].Visible = false;
            main_GV.Columns["cus_or_sell"].Visible = false;
            main_GV.Columns["inquire_no"].HeaderText = "문의 번호";
            main_GV.Columns["inquire_type"].HeaderText = "문의 타입";
            main_GV.Columns["inquire_name"].HeaderText = "문의자";
            main_GV.Columns["cus_or_sell"].HeaderText = "문의자 타입";
            main_GV.Columns["inquire_title"].HeaderText = "문의 제목";
            main_GV.Columns["re_date"].HeaderText = "답변 날짜";
            main_GV.Columns["inquire_date"].HeaderText = "문의 날짜";
            main_GV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void pay_GV()
        {
            main_GV.DataSource = tax_lst;

            main_GV.Columns["pay_id"].HeaderText = "결제 번호";
            main_GV.Columns["stock_id"].HeaderText = "상품 이름";
            main_GV.Columns["seller_id"].HeaderText = "브랜드명";
            main_GV.Columns["seller_boss"].HeaderText = "대표";
            main_GV.Columns["corporate_registration_no"].HeaderText = "사업자 번호";
            main_GV.Columns["stock_id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            main_GV.Columns["pay_price"].HeaderText = "상품 가격";
            main_GV.Columns["pay_count"].HeaderText = "결제 수량";
            main_GV.Columns["pay_date"].HeaderText = "결제 날짜";
            main_GV.Columns["seller_addr"].HeaderText = "주소";
            main_GV.Columns["seller_addr"].Visible = false;
            main_GV.Columns["output_date_tax"].HeaderText = "출력 날짜";

            main_GV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void cus_GV()
        {
            main_GV.DataSource = cus_lst;

            main_GV.Columns["cus_pwd"].Visible = false;
            main_GV.Columns["cus_count"].Visible = false;
            main_GV.Columns["cus_nickname"].Visible = false;
            main_GV.Columns["cus_addr"].Visible = false;
            main_GV.Columns["cus_no"].HeaderText = "고객 번호";
            main_GV.Columns["cus_id"].HeaderText = "아이디";
            main_GV.Columns["cus_id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            main_GV.Columns["cus_phone"].HeaderText = "전화번호";
            main_GV.Columns["cus_name"].HeaderText = "이름";
            main_GV.Columns["cus_gender"].HeaderText = "성별";
            main_GV.Columns["cus_age"].HeaderText = "나이";
            main_GV.Columns["cus_state"].HeaderText = "가입 상태";
            main_GV.Columns["withdrawal_date"].HeaderText = "탈퇴 날짜";
            main_GV.Columns["join_date"].HeaderText = "가입 날짜";

            main_GV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void pro_GV()
        {
            main_GV.DataSource = null;
            main_GV.DataSource = pro_lst;

            //main_GV.GridColor = Color.Pink;
            //main_GV.ForeColor = Color.PowderBlue;

            main_GV.Columns["cat_id"].Visible = false;
            main_GV.Columns["main_comment"].Visible = false;
            main_GV.Columns["sub_comment"].Visible = false;
            main_GV.Columns["main_image"].Visible = false;
            main_GV.Columns["pro_hits"].Visible = false;
            main_GV.Columns["pro_like"].HeaderText = "추천수";
            main_GV.Columns["pro_discount"].Visible = false;
            main_GV.Columns["pro_gender"].Visible = false;
            main_GV.Columns["pro_url"].Visible = false;
            main_GV.Columns["pro_id"].HeaderText = "상품 번호";
            main_GV.Columns["seller_no"].HeaderText = "판매자 번호";
            main_GV.Columns["seller_no"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            main_GV.Columns["pro_name"].HeaderText = "상품 이름";
            main_GV.Columns["pro_name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            main_GV.Columns["pro_price"].HeaderText = "상품 가격";
            main_GV.Columns["pro_state"].HeaderText = "상품 상태";
            main_GV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void sell_GV()
        {
            main_GV.DataSource = sell_lst;

            main_GV.Columns["Seller_pwd"].Visible = false;
            main_GV.Columns["Seller_addr"].Visible = false;
            main_GV.Columns["Seller_postal"].Visible = false;
            main_GV.Columns["Seller_fax"].Visible = false;
            main_GV.Columns["return_addr"].Visible = false;
            main_GV.Columns["seller_no"].HeaderText = "판매자 번호";
            main_GV.Columns["seller_id"].HeaderText = "아이디";
            main_GV.Columns["seller_id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            main_GV.Columns["seller_name"].HeaderText = "브랜드명";
            main_GV.Columns["seller_boss"].HeaderText = "대표";
            main_GV.Columns["seller_phone"].HeaderText = "전화번호";
            main_GV.Columns["seller_email"].HeaderText = "e-mail";
            main_GV.Columns["seller_email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            main_GV.Columns["seller_state"].HeaderText = "판매자 상태";
            main_GV.Columns["join_state"].HeaderText = "가입 상태";
            main_GV.Columns["corporate_registration_no"].HeaderText = "사업증 번호";

            main_GV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        /// <summary>
        /// 자동삭제
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Pro_Temp = false;
            //MessageBox.Show(e.RowIndex.ToString());
            if (e.ColumnIndex > -1)
            {
                if (e.RowIndex == -1)
                {
                    if (gb_pro.Visible)
                    {
                        // 0 상품 번호 4 가격 2 판매자 번호 9 추천수

                        if (main_GV.Columns[e.ColumnIndex].Index == 4)
                        {
                            main_GV.DataSource = null;
                            if (!switch_pro)
                            {

                                pro_lst.Sort(delegate (Products_Vo A, Products_Vo B)
                                {
                                    int a_value = Int32.Parse(A.Pro_Price.Replace(",", ""));
                                    int b_value = Int32.Parse(B.Pro_Price.Replace(",", ""));
                                    if (a_value > b_value) return -1;
                                    else if (a_value < b_value) return 1;
                                    return 0;
                                });
                                switch_pro = true;
                            }
                            else
                            {
                                pro_lst.Sort(delegate (Products_Vo A, Products_Vo B)
                                {
                                    int a_value = Int32.Parse(A.Pro_Price.Replace(",", ""));
                                    int b_value = Int32.Parse(B.Pro_Price.Replace(",", ""));
                                    if (a_value > b_value) return 1;
                                    else if (a_value < b_value) return -1;
                                    return 0;
                                });
                                switch_pro = false;
                            }
                            pro_GV();
                        }
                        else if (main_GV.Columns[e.ColumnIndex].Index == 2)
                        {
                            main_GV.DataSource = null;
                            if (!switch_pro)
                            {
                                pro_lst.Sort(delegate (Products_Vo A, Products_Vo B)
                                {
                                    if (A.Seller_NO > B.Seller_NO) return -1;
                                    else if (A.Seller_NO < B.Seller_NO) return 1;
                                    return 0;
                                });
                                switch_pro = true;
                            }
                            else
                            {
                                pro_lst.Sort(delegate (Products_Vo A, Products_Vo B)
                                {
                                    if (A.Seller_NO > B.Seller_NO) return 1;
                                    else if (A.Seller_NO < B.Seller_NO) return -1;
                                    return 0;
                                });
                                switch_pro = false;
                            }
                            pro_GV();
                            //MessageBox.Show(dataGridView1.Columns[e.ColumnIndex].HeaderText);
                        }
                        else if (main_GV.Columns[e.ColumnIndex].Index == 9)
                        {
                            main_GV.DataSource = null;
                            if (!switch_pro)
                            {
                                pro_lst.Sort(delegate (Products_Vo A, Products_Vo B)
                                {
                                    if (A.Pro_Like > B.Pro_Like) return -1;
                                    else if (A.Pro_Like < B.Pro_Like) return 1;
                                    return 0;
                                });
                                switch_pro = true;
                            }
                            else
                            {
                                pro_lst.Sort(delegate (Products_Vo A, Products_Vo B)
                                {
                                    if (A.Pro_Like > B.Pro_Like) return 1;
                                    else if (A.Pro_Like < B.Pro_Like) return -1;
                                    return 0;
                                });
                                switch_pro = false;
                            }
                            pro_GV();
                        }
                    }
                    else if (gb_seller.Visible)
                    {
                        // 0 번호
                        if (main_GV.Columns[e.ColumnIndex].Index == 0)
                        {
                            //MessageBox.Show(dataGridView1.Columns[e.ColumnIndex].Index + "");
                            main_GV.DataSource = null;
                            if (!switch_pro)
                            {
                                sell_lst.Sort(delegate (Seller_Vo A, Seller_Vo b)
                                {
                                    if (A.Seller_NO > b.Seller_NO) return -1;
                                    else if (A.Seller_NO < b.Seller_NO) return 1;
                                    return 0;
                                });
                                switch_pro = true;
                            }
                            else
                            {
                                sell_lst.Sort(delegate (Seller_Vo A, Seller_Vo b)
                                {
                                    if (A.Seller_NO > b.Seller_NO) return 1;
                                    else if (A.Seller_NO < b.Seller_NO) return -1;
                                    return 0;
                                });
                                switch_pro = false;
                            }
                            sell_GV();
                        }
                    }
                    else if (gb_cus.Visible) // gb_cus.visible
                    {
                        //MessageBox.Show(dataGridView1.Columns[e.ColumnIndex].Index + "");
                        // 0 번호 8 나이 
                        if (main_GV.Columns[e.ColumnIndex].Index == 0)
                        {
                            //MessageBox.Show(dataGridView1.Columns[e.ColumnIndex].Index + "");
                            main_GV.DataSource = null;
                            if (!switch_pro)
                            {
                                cus_lst.Sort(delegate (Customers_Vo A, Customers_Vo b)
                                {
                                    if (A.Cus_no > b.Cus_no) return -1;
                                    else if (A.Cus_no < b.Cus_no) return 1;
                                    return 0;
                                });
                                switch_pro = true;
                            }
                            else
                            {
                                cus_lst.Sort(delegate (Customers_Vo A, Customers_Vo b)
                                {
                                    if (A.Cus_no > b.Cus_no) return 1;
                                    else if (A.Cus_no < b.Cus_no) return -1;
                                    return 0;
                                });
                                switch_pro = false;
                            }
                            cus_GV();
                        }
                        else if (main_GV.Columns[e.ColumnIndex].Index == 8)
                        {
                            main_GV.DataSource = null;
                            if (!switch_pro)
                            {
                                cus_lst.Sort(delegate (Customers_Vo A, Customers_Vo b)
                                {
                                    if (A.Cus_age > b.Cus_age) return -1;
                                    else if (A.Cus_age < b.Cus_age) return 1;
                                    return 0;
                                });
                                switch_pro = true;
                            }
                            else
                            {
                                cus_lst.Sort(delegate (Customers_Vo A, Customers_Vo b)
                                {
                                    if (A.Cus_age > b.Cus_age) return 1;
                                    else if (A.Cus_age < b.Cus_age) return -1;
                                    return 0;
                                });
                                switch_pro = false;
                            }
                            cus_GV();
                        }
                    }
                    else if (tax_switch)
                    {
                        // 0 번호 5 가격 6 수량
                        if (main_GV.Columns[e.ColumnIndex].Index == 0)
                        {
                            main_GV.DataSource = null;
                            if (!switch_pro)
                            {
                                tax_lst.Sort(delegate (TaxBill_Vo A, TaxBill_Vo B)
                                {
                                    if (A.Pay_ID > B.Pay_ID) return -1;
                                    else if (A.Pay_ID < B.Pay_ID) return 1;
                                    return 0;
                                });
                                switch_pro = true;
                            }
                            else
                            {
                                tax_lst.Sort(delegate (TaxBill_Vo A, TaxBill_Vo B)
                                {
                                    if (A.Pay_ID > B.Pay_ID) return 1;
                                    else if (A.Pay_ID < B.Pay_ID) return -1;
                                    return 0;
                                });
                                switch_pro = false;
                            }
                            pay_GV();
                        }
                        else if (main_GV.Columns[e.ColumnIndex].Index == 5)
                        {
                            main_GV.DataSource = null;
                            if (!switch_pro)
                            {
                                tax_lst.Sort(delegate (TaxBill_Vo A, TaxBill_Vo B)
                                {
                                    var a_value = Int32.Parse(A.Pay_price.Replace(",", ""));
                                    var b_value = Int32.Parse(B.Pay_price.Replace(",", ""));
                                    if (a_value > b_value) return -1;
                                    else if (a_value < b_value) return 1;
                                    return 0;
                                });
                                switch_pro = true;
                            }
                            else
                            {
                                tax_lst.Sort(delegate (TaxBill_Vo A, TaxBill_Vo B)
                                {
                                    var a_value = Int32.Parse(A.Pay_price.Replace(",", ""));
                                    var b_value = Int32.Parse(B.Pay_price.Replace(",", ""));
                                    if (a_value > b_value) return 1;
                                    else if (a_value < b_value) return -1;
                                    return 0;
                                });
                                switch_pro = false;
                            }

                            pay_GV();
                        }
                        else if (main_GV.Columns[e.ColumnIndex].Index == 6)
                        {
                            main_GV.DataSource = null;
                            if (!switch_pro)
                            {
                                tax_lst.Sort(delegate (TaxBill_Vo A, TaxBill_Vo B)
                                {

                                    if (A.Pay_count > B.Pay_count) return -1;
                                    else if (A.Pay_count < B.Pay_count) return 1;
                                    return 0;
                                });
                                switch_pro = true;
                            }
                            else
                            {
                                tax_lst.Sort(delegate (TaxBill_Vo A, TaxBill_Vo B)
                                {

                                    if (A.Pay_count > B.Pay_count) return 1;
                                    else if (A.Pay_count < B.Pay_count) return -1;
                                    return 0;
                                });
                                switch_pro = false;
                            }

                            pay_GV();
                        }
                    }
                    else if (gb_inq.Visible) { }
                }
                else
                {
                    if (gb_seller.Visible)
                    {
                        Seller_Detail sd = new Seller_Detail(sell_lst[e.RowIndex]);
                        sd.Owner = this;
                        sd.ShowDialog();
                        //sell_GV();
                    }
                    else if (gb_pro.Visible)
                    {
                        Pro_Detail pd = new Pro_Detail(pro_lst[e.RowIndex], pro_temp);
                        pd.Owner = this;
                        pd.ShowDialog();
                        //dataGridView1.Columns["pro_state"].

                        //pro_GV();
                    }
                    else if (gb_cus.Visible)        // gb_cus.visible
                    {
                        Cus_Detail cd = new Cus_Detail(cus_lst[e.RowIndex]);
                        cd.ShowDialog();
                        //cus_GV();
                    }
                    else if (tax_switch)
                    {
                        Tax_Ex te = new Tax_Ex(tax_lst[e.RowIndex]);
                        te.Owner = this;
                        te.ShowDialog();
                    }
                    else if (gb_inq.Visible)
                    {
                        //main_GV.SelectedRows
                        Inquire_Admin_Detail iad = new Inquire_Admin_Detail(main_GV.SelectedRows);
                        iad.Owner = this;
                        iad.ShowDialog();
                        //MessageBox.Show("Test");
                    }

                    if (Pro_Temp)
                    {
                        btn_Refresh_Click(null, null);
                    }
                }
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            //switch_pro = false;
            if (gb_seller.Visible)
            {
                seller_changed(null, null);
            }
            else if (gb_pro.Visible)
            {
                pro_changed(null, null);
            }
            else if (gb_cus.Visible)        // gb_cus.visible
            {
                cus_Changed(null, null);
            }
            else if (tax_switch)
            {
                Pay_changed();
            }
            else if (gb_inq.Visible)
            {
                inq_changed(null, null);

            }
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

        private void pb_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point? previous = null;
        ToolTip myToolTip = new ToolTip();

        private void chart_sales_MouseMove(object sender, MouseEventArgs e)
        {
            Point nowPosition = e.Location;
            if (previous.HasValue && nowPosition == previous) // 마우스 움직임이 없을 때
            {
                return;
            }
            myToolTip.RemoveAll();
            previous = nowPosition;
            HitTestResult hit = chart_sales.HitTest(nowPosition.X, nowPosition.Y, ChartElementType.DataPoint);
            if (hit.ChartElementType == ChartElementType.DataPoint)
            {
                var name = sales_sub_lst[hit.PointIndex].Seller_ID;
                var price = sales_sub_lst[hit.PointIndex].Pay_price.ToString("#,##0") + "원";
                var count = sales_sub_lst[hit.PointIndex].Pay_count.ToString("#,##0") + "건";
                string date = "";
                date = sales_sub_lst[hit.PointIndex].Pay_date;

                myToolTip.Show(/*"회사 : " + name + Environment.NewLine +*/
                                        "매출 : " + price + Environment.NewLine +
                                       "건수 : " + count + Environment.NewLine +
                                       "날짜 : " + date
                                       , chart_sales, new Point(nowPosition.X + 10, nowPosition.Y + 15));
            }
        }
    }
}
