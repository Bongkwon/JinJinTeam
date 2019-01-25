using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JinTeamForServer
{
    public partial class FrmInsert_cus : System.Web.UI.Page
    {
        string cus_ID;
        string cus_pwd;
        string cus_phone;
        string cus_addr;
        string cus_name;
        string cus_Nickname;
        int cus_gender;
        string cus_age;

        protected void Page_Load(object sender, EventArgs e)
        {
            //cus_ID, pwdencrypt(cus_pwd), cus_phone, cus_addr, cus_name, cus_Nickname, cus_gender, cus_age
            if(Request.Params["cus_ID"] !=null && Request.Params["cus_pwd"] !=null && Request.Params["cus_phone"] != null && Request.Params["cus_addr"] != null && Request.Params["cus_name"] != null && Request.Params["cus_Nickname"] != null && Request.Params["cus_gender"] != null && Request.Params["cus_age"] != null)
            {
                cus_ID = Request.Params["cus_ID"];
                cus_pwd = Request.Params["cus_ID"];
                cus_phone = Request.Params["cus_ID"];
                cus_addr = Request.Params["cus_ID"];
                cus_name = Request.Params["cus_ID"];
                cus_Nickname = Request.Params["cus_ID"];
                cus_gender = int.Parse(Request.Params["cus_ID"]);
                cus_age = Request.Params["cus_ID"];
            }
        }
    }
}