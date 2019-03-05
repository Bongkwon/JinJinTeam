using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JinTeamForServer
{
    public partial class FrmSavedUserShipInfo : System.Web.UI.Page
    {
        UserShipInfo_DAO usid = new UserShipInfo_DAO();
        protected void Page_Load(object sender, EventArgs e)
        {
            string cus_no = null;
            string json = null;
            //user_ship_Id

            if (String.IsNullOrEmpty(Request.Params["cus_no"]))
            {
                json = "2200";    // cus_no 입력 없음
            }
            else
            {
                cus_no = Request.Params["cus_no"].ToString();
                json = usid.SelectSavedShipInfo(cus_no);
                if (json == "<Categories><DataCount>0</DataCount></Categories>")
                {
                    json = "2201";   // 배송지정보 내역이 없기 때문에 정보가 없음
                }
            }

            Response.Clear();
            Response.ContentType = "application/json, charset=utf-8";
            Response.Write(json);
            Response.Flush();
            Response.End();
        }
    }
}