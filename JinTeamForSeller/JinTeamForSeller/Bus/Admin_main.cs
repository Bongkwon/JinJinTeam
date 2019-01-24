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
        public Admin_main()
        {
            InitializeComponent();
        }

        private void btn_seller_List_Click(object sender, EventArgs e)
        {
            rdo_all_seller.Visible = rdo_deactive_seller.Visible = true;
        }
    }
}
