using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JinTeamForServer
{
    public partial class FrmInquireSend : System.Web.UI.Page
    {
        string inquire_type;
        int inquire_id;
        string cus_or_sell = "C";
        string inquire_title;
        string inquire_body;

        string errCode;

        Inquire_DAO idao = new Inquire_DAO();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Params["inquire_type"] != null && Request.Params["inquire_id"] != null && Request.Params["inquire_title"] != null && Request.Params["inquire_body"] != null)
            {
                inquire_type = Request.Params["inquire_type"];
                inquire_id = Int32.Parse(Request.Params["inquire_id"]);
                inquire_title = Request.Params["inquire_title"];
                inquire_body = Request.Params["inquire_body"];

                try
                {
                    idao.InsertInquire(new Inquire_VO(inquire_type,inquire_id,cus_or_sell,inquire_title,inquire_body));
                    errCode = "1100";    // 문의 성공
                }
                catch (Exception se)
                {
                    Response.Clear();
                    Response.Write(se.Message);
                }
            }
            else
            {
                errCode = "1101";   // 값이 없음 나올 수 없는 에러임 (테스트)
            }
            Response.Write(errCode);
        }
    }
}
