using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JinTeamForServer
{
    public partial class FrmInsertCust : System.Web.UI.Page
    {
        string errCode;

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
            if (Request.Params["cus_ID"] != null && Request.Params["cus_pwd"] == null)
            {
                cus_ID = Request.Params["cus_ID"];
                if (cust.chkID(cus_ID))
                {
                    errCode = "202";    // ID 중복 에러
                    Response.Write(errCode);
                    Response.Flush();
                    return;
                }
                else
                {
                    // 이메일 보내기
                    return;
                }
            }

            if (Request.Params["cus_phone"] != null)
            {
                cus_phone = Request.Params["cus_phone"];
                if (cust.ChkPhone(cus_phone))
                {
                    errCode = "201";    // phone 유니크 에러
                    Response.Write(errCode);
                    Response.Flush();
                    return;
                }
            }

            //cus_ID, pwdencrypt(cus_pwd), cus_phone, cus_addr, cus_name, cus_Nickname, cus_gender, cus_age
            if (Request.Params["cus_ID"] != null && Request.Params["cus_pwd"] != null && Request.Params["cus_phone"] != null && Request.Params["cus_addr"] != null && Request.Params["cus_name"] != null && Request.Params["cus_Nickname"] != null && Request.Params["cus_gender"] != null && Request.Params["cus_age"] != null)
            {
                cus_ID = Request.Params["cus_ID"];
                cus_pwd = Request.Params["cus_pwd"];
                cus_phone = Request.Params["cus_phone"];
                cus_addr = Request.Params["cus_addr"];
                cus_name = Request.Params["cus_name"];
                cus_Nickname = Request.Params["cus_Nickname"];
                cus_gender = int.Parse(Request.Params["cus_gender"]);
                cus_age = int.Parse(Request.Params["cus_age"]);

                try
                {
                    cust.InsertCustomer(new Customer(cus_ID, cus_pwd, cus_phone, cus_addr, cus_name, cus_Nickname, cus_gender, cus_age));
                    errCode = "100";    // 회원가입 성공
                }
                catch (Exception se)
                {
                    Response.Clear();
                    Response.Write(se.Message);
                }
            }
            else
            {
                errCode = "300";    // 값 입력이 되지않음
            }
            //Customer cust = new Customer();
            
            Response.Write(errCode);
        }
    }
}