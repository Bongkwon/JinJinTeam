using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JinTeamForSeller.Vo
{
    class Transport_InfoVO
    {
        private int transport_ID;

        public int Transport_ID
        {
            get { return transport_ID; }
            set { transport_ID = value; }
        }
        private int seller_no;

        public int Seller_no
        {
            get { return seller_no; }
            set { seller_no = value; }
        }
        private string waybill_ID;

        public string Waybill_ID
        {
            get { return waybill_ID; }
            set { waybill_ID = value; }
        }
        private string transport_State;

        public string Transport_State
        {
            get { return transport_State; }
            set { transport_State = value; }
        }

        public Transport_InfoVO(int transport_ID, int seller_no, string waybill_ID, string transport_State) : this(seller_no, waybill_ID)
        {
            this.transport_ID = transport_ID;            
            this.transport_State = transport_State;
        }

        public Transport_InfoVO(int seller_no, string waybill_ID)
        {
            this.seller_no = seller_no;
            this.waybill_ID = waybill_ID;
        }

        public Transport_InfoVO(string waybill_ID, string transport_State)
        {
            this.waybill_ID = waybill_ID;
            this.transport_State = transport_State;
        }
    }
}
