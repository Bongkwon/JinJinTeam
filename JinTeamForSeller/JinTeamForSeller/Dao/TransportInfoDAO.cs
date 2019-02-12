using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JinTeamForSeller.Vo;

namespace JinTeamForSeller.Dao
{
    class TransportInfoDAO
    {
        DBConnection con = new DBConnection();
        public bool InsertTransport(Transport_InfoVO ti)
        {
            string query = "InsertTransport";
            SqlParameter[] sqlp = { new SqlParameter("seller_no", ti.Seller_no), new SqlParameter("waybill_ID", ti.Waybill_ID) };

            return con.SendExqueteQuery(query, sqlp);
        }
        public bool UpdateTransportState(Transport_InfoVO ti)
        {
            string query = "UpdateTransportState";
            SqlParameter[] sqlp = { new SqlParameter("transport_State", ti.Transport_State), new SqlParameter("waybill_ID", ti.Waybill_ID) };

            return con.SendExqueteQuery(query, sqlp);
        }

        internal bool UpdateTransportWaybill(string oldwaybillID, string waybill_ID)
        {
            string query = "UpdateTransportWaybill";
            SqlParameter[] sqlp = { new SqlParameter("oldWaybill_ID", oldwaybillID), new SqlParameter("waybill_ID", waybill_ID) };
            return con.SendExqueteQuery(query, sqlp);
        }
    }
}
