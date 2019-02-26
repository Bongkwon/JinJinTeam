﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JinTeamForServer
{
    // 파라메타 정상적으로 다 보냈었지만 인식하지 못함 수정 해야함
    public partial class ChangeCustInfo : System.Web.UI.Page
    {
        string errCode;

        int cus_no;
        string cus_ID;
        string cus_pwd;
        string cus_Nickname;
        string cus_addr;
        string cus_name;
        string cus_phone;
        int cus_age;
        int cus_count;
        int cus_state;
        string withdrawal_date;
        string join_date;
        int cus_gender;

        Customer customer;
        CustomerDAO custDao = new CustomerDAO();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Params["cus_no"] != null)
            {
                cus_no = int.Parse(Request.Params["cus_no"].ToString());

                customer = custDao.ReadTable(cus_no);
            }

            if (Request.Params["cus_gender"] != null)
            {
                customer.Cus_gender = int.Parse(Request.Params["cus_gender"]);

                customer.Cus_state = int.Parse(Request.Params["cus_state"]);
            }
            else
            {
                // bool 측에서 에러 확인용
                errCode = "900";
            }

            if (Request.Params["cus_pwd"] != null && Request.Params["cus_Nickname"] != null && Request.Params["cus_addr"] != null && Request.Params["cus_name"] != null &&
                Request.Params["cus_phone"] != null && Request.Params["cus_gender"] != null && Request.Params["cus_age"] != null)
            {
                customer.Cus_pwd = Request.Params["cus_pwd"];
                customer.Cus_Nickname = Request.Params["cus_Nickname"];
                customer.Cus_addr = Request.Params["cus_addr"];
                customer.Cus_name = Request.Params["cus_name"];
                customer.Cus_phone = Request.Params["cus_phone"];
                customer.Cus_age = int.Parse(Request.Params["cus_age"]);

                if (UpdateCust())
                {
                    // 성공
                    errCode = "100";
                }
                else
                {
                    // 실패
                    errCode = "1000";
                }
            }
            else
            {
                // 파라메터 확인
                errCode = "999";
            }

            Response.Clear();
            Response.Write(errCode);
            Response.Flush();
            Response.End();
        }

        private bool UpdateCust()
        {
            DBConnection connection = new DBConnection();
            string sp = "update_cus";
            SqlParameter[] sqls =
            {
                new SqlParameter("cus_no",customer.Cus_no),
                new SqlParameter("cus_ID",customer.Cus_ID),
                new SqlParameter("cus_pwd",customer.Cus_pwd),
                new SqlParameter("cus_phone",customer.Cus_phone),
                new SqlParameter("cus_addr",customer.Cus_addr),
                new SqlParameter("cus_name",customer.Cus_name),
                new SqlParameter("cus_Nickname",customer.Cus_Nickname),
                new SqlParameter("cus_gender",customer.Cus_gender),
                new SqlParameter("cus_age",customer.Cus_age),
                new SqlParameter("cus_state",customer.Cus_state),
                new SqlParameter("cus_count",customer.Cus_count),
                new SqlParameter("withdrawal_date",customer.Withdrawal_date),
                new SqlParameter("join_date",customer.Join_date)
            };

            try
            {
                return connection.UpdateQuery(sp, sqls);
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}