using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JinTeamForServer
{
    public partial class FrmShowProStock : System.Web.UI.Page
    {
        StockDAO stockDao = new StockDAO();
        //List<Stock> stocks = new List<Stock>();

        protected void Page_Load(object sender, EventArgs e)
        {
            string json = string.Empty;
            string pro_id = string.Empty;
            if (Request.Params["pro_id"] != null)
            {
                pro_id = Request.Params["pro_id"].ToString();
                //stocks = stockDao.ShowStock(pro_id);
                json = JsonConvert.SerializeObject(stockDao.ShowStock(pro_id));
            }
            else
            {
                json = "111";
            }

            Response.Clear();
            Response.Write(json);
            Response.Flush();
            Response.End();
        }
    }
}