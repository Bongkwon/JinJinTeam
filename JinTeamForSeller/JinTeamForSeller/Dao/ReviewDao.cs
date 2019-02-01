using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JinTeamForSeller.Vo;

namespace JinTeamForSeller.Dao
{    
    class ReviewDAO
    {
        DBConnection con = new DBConnection();
        public List<ReviewVO> SelectReviewForSeller(int seller_No)
        {
            List<object> lstobj = new List<object>();
            List<ReviewVO> lstReview = new List<ReviewVO>();
            string query = "SelectReviewForSeller";
            SqlParameter[] sqlp = { new SqlParameter("seller_No", seller_No) };
            lstobj = con.SendReadQuery(query, sqlp);
            foreach (var item in lstobj)
            {
                lstReview.Add((ReviewVO)item);
            }
            return lstReview;
        }


    }
}
