using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JinTeamForSeller.Vo;

namespace JinTeamForSeller.Dao
{
    class CatDAO
    {
        DBConnection conn = new DBConnection();

        public List<CatVO> SelectCategory()
        {
            List<object> lstObj = new List<object>();
            List<CatVO> lstCat = new List<CatVO>();
            string query = "SelectCategory";
            SqlParameter[] sqlp = null;
            lstObj = conn.SendReadQuery(query, sqlp);

            foreach (var item in lstObj)
            {
                lstCat.Add((CatVO)item);
            }

            return lstCat;
        }


    }
}
