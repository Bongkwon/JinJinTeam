using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JinTeamForSeller.Vo;
namespace JinTeamForSeller.Dao
{
    class PaymentInfoDAO
    {
        DBConnection con = new DBConnection();        
        public List<Payment_InfoVO> SelectPaymentInfo(int sellerNo)
        {
            List<object> lstobj = new List<object>();
            List<Payment_InfoVO> lstPayInfo = new List<Payment_InfoVO>();

            string query = "SelectPayInfo";
            SqlParameter[] sqlp = { new SqlParameter("sellerNo", sellerNo) };

            lstobj = con.SendReadQuery(query, sqlp);

            foreach (var item in lstobj)
            {
                lstPayInfo.Add((Payment_InfoVO)item);
            }

            return lstPayInfo;
        }
    }
}
