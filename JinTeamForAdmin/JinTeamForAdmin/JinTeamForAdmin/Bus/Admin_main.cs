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
        List<Customers_Vo> cus_lst;
        List<object> ob_lst;
        List<Seller_Vo> sell_lst;
        List<Products_Vo> pro_lst;
        bool switch_pro = false;
        List<TaxBill_Vo> tax_lst;
        bool tax_switch = false;

        string sp = "";
        string type_s = "";

        private bool temp;

        public bool Temp
        {
            get { return temp; }
            set { temp = value; }
        }

        public Admin_main()
        {
            InitializeComponent();
            cus_lst = new List<Customers_Vo>();
            ob_lst = new List<object>();
            sell_lst = new List<Seller_Vo>();
            pro_lst = new List<Products_Vo>();
            tax_lst = new List<TaxBill_Vo>();
            
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

        private void 결제정보세금계산서출력ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pay_changed();

        }

        private void Pay_changed()
        {
            gb_seller.Visible = false;
            gb_pro.Visible = false;
            gb_cus.Visible = false;
            tax_switch = true;

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

        private void pay_GV()
        {
            main_GV.DataSource = tax_lst;

            main_GV.Columns["pay_id"].HeaderText = "결제 번호";
            main_GV.Columns["stock_id"].HeaderText = "상품 이름";
            main_GV.Columns["seller_id"].HeaderText = "브랜드명";
            main_GV.Columns["seller_boss"].HeaderText = "대표";
            main_GV.Columns["corporate_registration_no"].HeaderText = "사업자 번호";

            main_GV.Columns["pay_price"].HeaderText = "결제 가격";
            main_GV.Columns["pay_count"].HeaderText = "결제 수량";
            main_GV.Columns["pay_date"].HeaderText = "결제 날짜";
            main_GV.Columns["seller_addr"].HeaderText = "주소";
            main_GV.Columns["seller_addr"].Visible = false;
            main_GV.Columns["output_date_tax"].HeaderText = "출력 날짜";

            main_GV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void cus_Changed(object sender, EventArgs e)
        {
            //dataGridView1.Columns["Cus_no"].HeaderText = "번호";
            //dataGridView1.Columns["cus_phone"].Visible = false;
            //MessageBox.Show(DateTime.Now.ToString());
            gb_seller.Visible = false;
            gb_pro.Visible = false;
            gb_cus.Visible = true;
            tax_switch = false;

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

        private void cus_GV()
        {
            main_GV.DataSource = cus_lst;

            main_GV.Columns["cus_pwd"].Visible = false;
            main_GV.Columns["cus_count"].Visible = false;
            main_GV.Columns["cus_nickname"].Visible = false;
            main_GV.Columns["cus_no"].HeaderText = "고객 번호";
            main_GV.Columns["cus_id"].HeaderText = "아이디";
            main_GV.Columns["cus_phone"].HeaderText = "전화번호";
            main_GV.Columns["cus_name"].HeaderText = "이름";
            main_GV.Columns["cus_gender"].HeaderText = "성별";
            main_GV.Columns["cus_age"].HeaderText = "나이";
            main_GV.Columns["cus_state"].HeaderText = "가입 상태";
            main_GV.Columns["withdrawal_date"].HeaderText = "탈퇴 날짜";
            main_GV.Columns["join_date"].HeaderText = "가입 날짜";

            main_GV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void pro_changed(object sender, EventArgs e)
        {
            gb_seller.Visible = false;
            gb_pro.Visible = true;
            gb_cus.Visible = false;
            tax_switch = false;

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

        private void pro_GV()
        {
            main_GV.DataSource = null;
            main_GV.DataSource = pro_lst;

            main_GV.Columns["cat_id"].Visible = false;
            main_GV.Columns["main_comment"].Visible = false;
            main_GV.Columns["sub_comment"].Visible = false;
            main_GV.Columns["main_image"].Visible = false;
            main_GV.Columns["pro_hits"].Visible = false;
            main_GV.Columns["pro_like"].HeaderText = "추천수";
            main_GV.Columns["pro_discount"].Visible = false;
            main_GV.Columns["pro_gender"].Visible = false;
            main_GV.Columns["pro_id"].HeaderText = "상품 번호";
            main_GV.Columns["seller_no"].HeaderText = "판매자 번호";
            main_GV.Columns["pro_name"].HeaderText = "상품 이름";
            main_GV.Columns["pro_price"].HeaderText = "상품 가격";
            main_GV.Columns["pro_state"].HeaderText = "상품 상태";
            main_GV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void seller_changed(object sender, EventArgs e)
        {
            gb_seller.Visible = true;
            gb_pro.Visible = false;
            gb_cus.Visible = false;
            tax_switch = false;

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
            main_GV.Columns["seller_name"].HeaderText = "브랜드명";
            main_GV.Columns["seller_boss"].HeaderText = "대표";
            main_GV.Columns["seller_phone"].HeaderText = "전화번호";
            main_GV.Columns["seller_email"].HeaderText = "e-mail";
            main_GV.Columns["seller_state"].HeaderText = "판매자 상태";
            main_GV.Columns["join_state"].HeaderText = "가입 상태";
            main_GV.Columns["corporate_registration_no"].HeaderText = "사업증 번호";

            main_GV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
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
            Temp = false;
            //MessageBox.Show(e.RowIndex.ToString());
            if (e.RowIndex == -1)
            {
                if (gb_pro.Visible)
                {              
                    //MessageBox.Show(dataGridView1.Columns[e.ColumnIndex].Index+"");
                    // 0 상품 번호 4 가격 2 판매자 번호 9 추천수
                    
                    if (main_GV.Columns[e.ColumnIndex].Index == 4)
                    {
                        main_GV.DataSource = null;
                        if (switch_pro)
                        {                          
                            pro_lst.Sort(delegate (Products_Vo A, Products_Vo b)
                            {
                                if (A.Pro_Price > b.Pro_Price) return -1;
                                else if (A.Pro_Price < b.Pro_Price) return 1;
                                return 0;
                            });
                            switch_pro = false;
                        }
                        else
                        {
                            pro_lst.Sort(delegate (Products_Vo A, Products_Vo b)
                            {
                                if (A.Pro_Price > b.Pro_Price) return 1;
                                else if (A.Pro_Price < b.Pro_Price) return -1;
                                return 0;
                            });
                            switch_pro = true;
                        }
                        pro_GV();
                    }
                    else if (main_GV.Columns[e.ColumnIndex].Index == 2)
                    {
                        main_GV.DataSource = null;
                        if (switch_pro)
                        {
                            pro_lst.Sort(delegate (Products_Vo A, Products_Vo b)
                            {
                                if (A.Seller_NO > b.Seller_NO) return -1;
                                else if (A.Seller_NO < b.Seller_NO) return 1;
                                return 0;
                            });
                            switch_pro = false;
                        }
                        else
                        {                           
                            pro_lst.Sort(delegate (Products_Vo A, Products_Vo b)
                            {
                                if (A.Seller_NO > b.Seller_NO) return 1;
                                else if (A.Seller_NO < b.Seller_NO) return -1;
                                return 0;
                            });
                            switch_pro = true;
                        }
                        pro_GV();
                        //MessageBox.Show(dataGridView1.Columns[e.ColumnIndex].HeaderText);
                    }
                    else if (main_GV.Columns[e.ColumnIndex].Index == 9)
                    {
                        main_GV.DataSource = null;
                        if (switch_pro)
                        {
                            pro_lst.Sort(delegate (Products_Vo A, Products_Vo b)
                            {
                                if (A.Pro_Like > b.Pro_Like) return -1;
                                else if (A.Pro_Like < b.Pro_Like) return 1;
                                return 0;
                            });
                            switch_pro = false;
                        }
                        else
                        {
                            pro_lst.Sort(delegate (Products_Vo A, Products_Vo b)
                            {
                                if (A.Pro_Like > b.Pro_Like) return 1;
                                else if (A.Pro_Like < b.Pro_Like) return -1;
                                return 0;
                            });
                            switch_pro = true;
                        }
                        pro_GV();
                    }
                }
                else if(gb_seller.Visible)
                {                  
                    // 0 번호
                    if (main_GV.Columns[e.ColumnIndex].Index == 0)
                    {
                        //MessageBox.Show(dataGridView1.Columns[e.ColumnIndex].Index + "");
                        main_GV.DataSource = null;
                        if (switch_pro)
                        {
                            sell_lst.Sort(delegate (Seller_Vo A, Seller_Vo b)
                            {
                                if (A.Seller_NO > b.Seller_NO) return -1;
                                else if (A.Seller_NO < b.Seller_NO) return 1;
                                return 0;
                            });
                            switch_pro = false;
                        }
                        else
                        {
                            sell_lst.Sort(delegate (Seller_Vo A, Seller_Vo b)
                            {
                                if (A.Seller_NO > b.Seller_NO) return 1;
                                else if (A.Seller_NO < b.Seller_NO) return -1;
                                return 0;
                            });
                            switch_pro = true;
                        }
                        sell_GV();
                    }
                }
                else if(gb_cus.Visible) // gb_cus.visible
                {
                    //MessageBox.Show(dataGridView1.Columns[e.ColumnIndex].Index + "");
                    // 0 번호 8 나이 
                    if (main_GV.Columns[e.ColumnIndex].Index == 0)
                    {
                        //MessageBox.Show(dataGridView1.Columns[e.ColumnIndex].Index + "");
                        main_GV.DataSource = null;
                        if (switch_pro)
                        {
                            cus_lst.Sort(delegate (Customers_Vo A, Customers_Vo b)
                            {
                                if (A.Cus_no > b.Cus_no) return -1;
                                else if (A.Cus_no < b.Cus_no) return 1;
                                return 0;
                            });
                            switch_pro = false;
                        }
                        else
                        {
                            cus_lst.Sort(delegate (Customers_Vo A, Customers_Vo b)
                            {
                                if (A.Cus_no > b.Cus_no) return 1;
                                else if (A.Cus_no < b.Cus_no) return -1;
                                return 0;
                            });
                            switch_pro = true;
                        }
                        cus_GV();
                    }
                    else if (main_GV.Columns[e.ColumnIndex].Index == 8)
                    {
                        main_GV.DataSource = null;
                        if (switch_pro)
                        {
                            cus_lst.Sort(delegate (Customers_Vo A, Customers_Vo b)
                            {
                                if (A.Cus_age > b.Cus_age) return -1;
                                else if (A.Cus_age < b.Cus_age) return 1;
                                return 0;
                            });
                            switch_pro = false;
                        }
                        else
                        {
                            cus_lst.Sort(delegate (Customers_Vo A, Customers_Vo b)
                            {
                                if (A.Cus_age > b.Cus_age) return 1;
                                else if (A.Cus_age < b.Cus_age) return -1;
                                return 0;
                            });
                            switch_pro = true;
                        }
                        cus_GV();
                    }
                }
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
                    Pro_Detail pd = new Pro_Detail(pro_lst[e.RowIndex],temp);
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

                if (Temp)
                {
                    btn_Refresh_Click(null, null);
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
        }

        
    }
}
