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
    public partial class Inquire_Admin_Detail : Form
    {
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
            textBox1.Text = selectedRows[0].Cells[5].Value.ToString();
        }
    }
}
