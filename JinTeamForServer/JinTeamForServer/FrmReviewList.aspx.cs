using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JinTeamForServer
{
    public partial class FrmReviewList : System.Web.UI.Page
    {
        ReviewDao reDao = new ReviewDao();
        string json = string.Empty;

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Request.Params["stock_ID"] != null)
                {
                    json = reDao.SelReviewByStock(Request.Params["stock_ID"]);

                }
                else if (Request.Params["cus_no"] != null)
                {
                    json = reDao.SelReviewByCusno(int.Parse(Request.Params["cus_no"]));
                }
            }
            catch (Exception)
            {
                json = "701"; // DB 오류
            }

            if (json.Equals("[]"))
            {
                json = "702"; // 데이터 없음
            }
            else if (string.IsNullOrEmpty(json))
            {
                json = "702"; // 데이터 없음
            }

            Response.Clear();
            Response.Write(json);
            Response.Flush();
            Response.End();
        }
    }
}