using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JinTeamForSeller.Vo
{
    class SellerVO
    {
        private int seller_No;

        public int Seller_NO
        {
            get { return seller_No; }
            set { seller_No = value; }
        }
        private string seller_Id;

        public string Seller_ID
        {
            get { return seller_Id; }
            set { seller_Id = value; }
        }
        private string seller_pwd;

        public string Seller_pwd
        {
            get { return seller_pwd; }
            set { seller_pwd = value; }
        }
        private string seller_name;

        public string Seller_name
        {
            get { return seller_name; }
            set { seller_name = value; }
        }

        private string seller_addr;

        public string Seller_addr
        {
            get { return seller_addr; }
            set { seller_addr = value; }
        }
        private string seller_boss;

        public string Seller_boss
        {
            get { return seller_boss; }
            set { seller_boss = value; }
        }

        private string seller_phone;

        public string Seller_phone
        {
            get { return seller_phone; }
            set { seller_phone = value; }
        }

        private string seller_postal;

        public string Seller_postal
        {
            get { return seller_postal; }
            set { seller_postal = value; }
        }

        private string seller_email;

        public string Seller_email
        {
            get { return seller_email; }
            set { seller_email = value; }
        }

        private string seller_fax;

        public string Seller_fax
        {
            get { return seller_fax; }
            set { seller_fax = value; }
        }

        private string return_addr;

        public string Return_addr
        {
            get { return return_addr; }
            set { return_addr = value; }
        }

        private bool seller_state;

        public bool Seller_state
        {
            get { return seller_state; }
            set { seller_state = value; }
        }

        private string corporate_registration_no;

        public string Corporate_registration_no
        {
            get { return corporate_registration_no; }
            set { corporate_registration_no = value; }
        }

        private bool join_state;

        public bool Join_state
        {
            get { return join_state; }
            set { join_state = value; }
        }

        public SellerVO(string seller_Id, string seller_pwd, string seller_name, string seller_addr, string seller_boss, string seller_phone, string seller_postal, string seller_email, string seller_fax, string return_addr, string corporate_registration_no)
        {
            this.seller_Id = seller_Id;
            this.seller_pwd = seller_pwd;
            this.seller_name = seller_name;
            this.seller_addr = seller_addr;
            this.seller_boss = seller_boss;
            this.seller_phone = seller_phone;
            this.seller_postal = seller_postal;
            this.seller_email = seller_email;
            this.seller_fax = seller_fax;
            this.return_addr = return_addr;
            this.corporate_registration_no = corporate_registration_no;
        }
    }
}
