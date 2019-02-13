using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JinTeamForSeller.Vo;
namespace JinTeamForSeller.Dao
{
    class SalesManagementDAO
    {
        DBConnection conn = new DBConnection();

        public List<SalesManagementVO> selectSalesManagementForSeller(int seller_No)
        {
            List<object> lstObj = new List<object>();
            List<SalesManagementVO> lstManage = new List<SalesManagementVO>();
            string query = "selectSalesManagementForSeller";
            SqlParameter[] sqlp = { new SqlParameter("seller_no", seller_No) };
            lstObj = conn.SendReadQuery(query, sqlp);

            foreach (var item in lstObj)
            {
                lstManage.Add((SalesManagementVO)item);
            }

            return lstManage;
        }
    }
}
