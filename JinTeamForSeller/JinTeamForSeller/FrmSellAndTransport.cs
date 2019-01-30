using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JinTeamForSeller.Vo;
using JinTeamForSeller.Dao;

namespace JinTeamForSeller
{
    public partial class FrmSellAndTransport : Form
    {
        PaymentInfoDAO pDao = new PaymentInfoDAO();
        public FrmSellAndTransport()
        {
            InitializeComponent();
        }

        private void FrmSellAndTransport_Load(object sender, EventArgs e)
        {
            List<Payment_InfoVO> lstPInfo = pDao.SelectPaymentInfo(Form1.CompanyNo);
            gViewPayInfo.DataSource = lstPInfo;
        }
    }
}
