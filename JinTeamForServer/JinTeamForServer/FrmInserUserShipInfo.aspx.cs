using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JinTeamForServer
{
    public partial class FrmInserUserShipInfo : System.Web.UI.Page
    {
        int cus_no;
        string user_name;
        string user_addr;
        string postal_code;
        string ship_require;
        string json;
        UserShipInfo_DAO usid = new UserShipInfo_DAO();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Params["cus_no"] != null && Request.Params["user_name"] != null && Request.Params["user_addr"] != null && Request.Params["postal_code"] != null)
            {
                cus_no = Int32.Parse(Request.Params["cus_no"]);
                user_name = Request.Params["user_name"];
                user_addr = Request.Params["user_addr"];
                postal_code = Request.Params["postal_code"];

                if (String.IsNullOrEmpty(Request.Params["ship_require"]))
                {
                    ship_require = "없음";
                }
                else
                {
                    ship_require = Request.Params["ship_require"];
                }
                usid.InsertUserShipInfo(new UserShipInfo_VO(cus_no, user_name, user_addr, postal_code, ship_require));
                json = "2500";  // 배송지 정보 저장 완료
            }
            else
            {
                json = "2501";  // 배송지 정보 저장에 필요한 데이터가 충족되지 않음
            }

            Response.Clear();
            Response.ContentType = "application/json, charset=utf-8";
            Response.Write(json);
            Response.Flush();
            Response.End();
        }
    }
}