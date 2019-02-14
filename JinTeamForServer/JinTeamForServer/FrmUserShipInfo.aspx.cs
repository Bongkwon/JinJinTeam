using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JinTeamForServer
{
    public partial class FrmUserShipInfo : System.Web.UI.Page
    {
        UserShipInfo_DAO usid = new UserShipInfo_DAO();
        protected void Page_Load(object sender, EventArgs e)
        {
            string order_ID = null;
            string json = null;

            if (String.IsNullOrEmpty(Request.Params["order_ID"]))
            {
                json = "800";    // order_ID 입력 없음
            }
            else
            {
                order_ID = Request.Params["order_ID"].ToString();
                json = usid.ShipInfoReadTable(order_ID);
                if (json == "<Categories><DataCount>0</DataCount></Categories>")
                {
                    json = "801";   // 구매내역이 없기 때문에 배송정보가 없음 ( 나올수 없는 에러지만 테스트 )
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