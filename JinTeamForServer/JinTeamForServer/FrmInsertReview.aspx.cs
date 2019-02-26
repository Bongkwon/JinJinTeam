using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JinTeamForServer
{
    public partial class FrmInsertReview : System.Web.UI.Page
    {
        ReviewVO review;
        ReviewDao rvDao = new ReviewDao();
        string json = string.Empty;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Params["cus_ID"] != null && Request.Params["stock_ID"] != null &&
               Request.Params["re_text"] != null)
            {
                review = new ReviewVO()
                {
                    Cus_no = int.Parse(Request.Params["cus_ID"]),
                    Stock_ID = Request.Params["stock_ID"],
                    Re_txt = Request.Params["re_text"]
                };

                try
                {
                    rvDao.InsertWishList(review);
                    json = "500";
                }
                catch (Exception)
                {
                    json = "501";
                }

            }
            else
            {
                json = "502";
            }


            Response.Clear();
            Response.ContentType = "application/json, charset=utf-8";
            Response.Write(json);
            Response.Flush();
            Response.End();
        }
    }
}