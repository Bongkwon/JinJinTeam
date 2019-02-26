using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JinTeamForServer
{
    public partial class FrmInquireRecieve : System.Web.UI.Page
    {
        Inquire_DAO idao = new Inquire_DAO();
        int inquire_Id;
        string json;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Params["inquire_Id"] != null)
            {
                inquire_Id = Int32.Parse(Request.Params["inquire_Id"]);

                json = idao.SelectInquire(inquire_Id);
                if (json == "<Categories><DataCount>0</DataCount></Categories>")
                {
                    json = "1202"; // 문의 내역이 없음 에러
                }
            }
            else
            {
                json = "1201";   // ID입력 없음 에러
            }

            Response.Clear();
            Response.ContentType = "application/json, charset=utf-8";
            Response.Write(json);
            Response.Flush();
            Response.End();
        }
    }
}