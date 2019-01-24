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
        public List<Customers_Vo> Select_cus_all()
        {
            List<Customers_Vo> cuslst = new List<Customers_Vo>();
            string sp = "select_cus";

            SqlDataReader sdr = new DBCon_admin().Select_GV(sp);
            while (sdr.Read())
            {
                cuslst.Add(new Customers_Vo()
                {
                    Cus_no = Int32.Parse(sdr["cus_no"].ToString()),
                    Cus_ID = sdr["cus_id"].ToString(),
                    Cus_pwd = sdr["cus_pwd"].ToString(),
                    Cus_phone = sdr["cus_phone"].ToString(),
                    Cus_addr = sdr["cus_addr"].ToString(),
                    Cus_name = sdr["cus_name"].ToString(),
                    Cus_Nickname = sdr["cus_nickname"].ToString(),
                    Cus_gender = bool.Parse(sdr["cus_gender"].ToString()),
                    Cus_state = bool.Parse(sdr["cus_state"].ToString()),
                    Cus_count = Int32.Parse(sdr["cus_count"].ToString()),
                    Cus_age = Int32.Parse(sdr["cus_age"].ToString()),
                    Join_date = DateTime.Parse(sdr["join_date"].ToString()),
                    Withdrawal_date = sdr["Withdrawal_date"].ToString()
                    //(sdr["Withdrawal_date"].ToString() =="") ? "" :  DateTime.Parse(sdr["Withdrawal_date"].ToString())
                });
            }
            return cuslst;
        }


    }
}
