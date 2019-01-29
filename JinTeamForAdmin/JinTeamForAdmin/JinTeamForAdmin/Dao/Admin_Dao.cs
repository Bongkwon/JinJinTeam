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

        public List<object> Select_ob(string sp, string type_s)
        {
            List<object> ob_lst = new List<object>();

            ob_lst = new DBCon_admin().Select_ob(sp,type_s);

            return ob_lst;
        }

        public bool Delete_Gv(string sp)
        {
            bool result = new DBCon_admin().ExecuteNonQuery_GV(sp);
            return result;
        }

        internal bool Update_ob(object ob_sub,string type_u)
        {
            SqlParameter[] sqlParameters = new SqlParameter[0];
            string sp = "";

            if (type_u == "seller")
            {
                Seller_Vo sv_sub = ob_sub as Seller_Vo;
                sp = "update_seller_join_state";

                //var con = new DBCon_admin();

                sqlParameters = new SqlParameter[3];
                sqlParameters[0] = new SqlParameter("seller_no", sv_sub.Seller_NO);
                sqlParameters[1] = new SqlParameter("join_state", sv_sub.Join_state);
                sqlParameters[2] = new SqlParameter("seller_state", sv_sub.Seller_state);
            }
            else if (type_u == "pro" )
            {
                Products_Vo pv_sub = ob_sub as Products_Vo;
                sp = "update_products_state";
                sqlParameters = new SqlParameter[2];
                sqlParameters[0] = new SqlParameter("@pro_ID",pv_sub.Pro_ID);
                sqlParameters[1] = new SqlParameter("@pro_state",pv_sub.Pro_State);
            }

            try
            {
                return new DBCon_admin().Update_ob(sp,sqlParameters);
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
