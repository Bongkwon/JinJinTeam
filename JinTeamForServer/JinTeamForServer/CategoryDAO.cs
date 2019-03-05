using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace JinTeamForServer
{
    public class CategoryDAO
    {
        DBConnection con = new DBConnection();
        List<Category> categories = new List<Category>();

        public List<Category> Showcategory(string cat_id)
        {
            string query = "select_category";
            SqlParameter[] sqls =
            {
                new SqlParameter("cat_id",cat_id)
            };

            try
            {
                categories = con.ReadCategory(query, sqls);
            }
            catch (Exception)
            {
                throw;
            }
            return categories;
        }
    }
}