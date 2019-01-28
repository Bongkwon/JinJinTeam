﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JinTeamForServer
{
    public partial class FrmInsertCust : System.Web.UI.Page
    {
        string cus_ID;
        string cus_pwd;
        string cus_phone;
        string cus_addr;
        string cus_name;
        string cus_Nickname;
        int cus_gender;
        int cus_age;
        CustomerDAO cust = new CustomerDAO();
        protected void Page_Load(object sender, EventArgs e)
        {
            //cus_ID, pwdencrypt(cus_pwd), cus_phone, cus_addr, cus_name, cus_Nickname, cus_gender, cus_age
            if (Request.Params["cus_ID"] != null && Request.Params["cus_pwd"] != null && Request.Params["cus_phone"] != null && Request.Params["cus_addr"] != null && Request.Params["cus_name"] != null && Request.Params["cus_Nickname"] != null && Request.Params["cus_gender"] != null && Request.Params["cus_age"] != null)
            {
                cus_ID = Request.Params["cus_ID"];
                cus_pwd = Request.Params["cus_ID"];
                cus_phone = Request.Params["cus_ID"];
                cus_addr = Request.Params["cus_ID"];
                cus_name = Request.Params["cus_ID"];
                cus_Nickname = Request.Params["cus_ID"];
                cus_gender = int.Parse(Request.Params["cus_ID"]);
                cus_age = int.Parse(Request.Params["cus_ID"]);
            }
            else
            {
                cus_ID = "kyk12345";
                cus_pwd = "qwer1234";
                cus_phone = "010-2312-4598";
                cus_addr = "저세상끝까지";
                cus_name = "김영규";
                cus_Nickname = "영규 짱짱맨";
                cus_gender = 0;
                cus_age = 256;
            }
            //Customer cust = new Customer();
            cust.InsertCustomer(new Customer(cus_ID, cus_pwd, cus_phone, cus_addr, cus_name, cus_Nickname, cus_gender, cus_age));
        }
    }
}