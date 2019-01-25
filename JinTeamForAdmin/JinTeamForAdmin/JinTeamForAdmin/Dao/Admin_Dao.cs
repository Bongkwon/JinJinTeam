using JinTeamForAdmin.Vo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JinTeamForAdmin.Dao
{
    class Admin_Dao
    {

        public List<object> Select_ob(string sp, string type_p)
        {
            List<object> ob_lst = new List<object>();

            ob_lst = new DBCon_admin().Select_ob(sp,type_p);

            return ob_lst;
        }

        public bool Delete_Gv(string sp)
        {
            bool result = new DBCon_admin().ExecuteNonQuery_GV(sp);
            return result;
        }

        internal bool Update_Sel(Seller_Vo sv_sub)
        {
            string sp = "update_seller_join_state";

            //var con = new DBCon_admin();

            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("seller_no",sv_sub.Seller_NO);
            sqlParameters[1] = new SqlParameter("join_state",sv_sub.Join_state);
            sqlParameters[2] = new SqlParameter("seller_state",sv_sub.Seller_state);

            try
            {
                return new DBCon_admin().Update_Sel(sp,sqlParameters);
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
