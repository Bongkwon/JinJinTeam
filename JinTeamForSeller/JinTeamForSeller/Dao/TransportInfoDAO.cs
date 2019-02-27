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
        public bool InsertTransport(Transport_InfoVO ti, int pay_ID)
        {
            string query = "InsertTransport";
            SqlParameter[] sqlp = 
                {
                new SqlParameter("seller_no", ti.Seller_no),
                new SqlParameter("waybill_ID", ti.Waybill_ID),
                new SqlParameter("pay_ID", pay_ID),
                new SqlParameter("transport_State", ti.Transport_State)
            };

            return con.SendExqueteQuery(query, sqlp);
        }
        public bool UpdateTransportState(Transport_InfoVO ti)
        {
            string query = "UpdateTransportState";
            SqlParameter[] sqlp = { new SqlParameter("transport_State", ti.Transport_State), new SqlParameter("waybill_ID", ti.Waybill_ID) };

            return con.SendExqueteQuery(query, sqlp);
        }

        internal bool UpdateTransportWaybill(Transport_InfoVO ti,string oldwaybillID, int pay_ID)
        {
            string query = "UpdateTransportWaybill";
            SqlParameter[] sqlp =
                {
                new SqlParameter("oldWaybill_ID", oldwaybillID),
                new SqlParameter("waybill_ID", ti.Waybill_ID),
                new SqlParameter("pay_ID",pay_ID),
                new SqlParameter("transport_State", ti.Transport_State)
            };
            return con.SendExqueteQuery(query, sqlp);
        }

        public int WaybillNotYet(int seller_No)
        {
            string qurey = "WaybillNotYet";
            SqlParameter[] sqlp = { new SqlParameter("seller_No", seller_No) };
            int rowCount = con.SendScalarReadQuery(qurey, sqlp);
            return rowCount;
        }

        public int NotShipping(int seller_No)
        {
            string qurey = "NotShipping";
            SqlParameter[] sqlp = { new SqlParameter("seller_No", seller_No) };
            int rowCount = con.SendScalarReadQuery(qurey, sqlp);
            return rowCount;
        }
        
        public int SumOfPayCount(int seller_No)
        {
            string qurey = "SumOfPayCount";
            SqlParameter[] sqlp = { new SqlParameter("seller_No", seller_No) };
            int rowCount = con.SendScalarReadQuery(qurey, sqlp);
            return rowCount;
        }
    }
}
