using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JinTeamForServer
{
    public class Customer
    {
        private string cus_ID;
        private string cus_pwd;
        private string cus_phone;
        private string cus_addr;
        private string cus_name;
        private string cus_Nickname;
        private bool cus_gender;
        private int cus_age;
        private int cus_no;
        private string withdrawal_date;
        private string join_date;
        private int cus_count;
        private bool cus_state;
        private string cus_guid;

        public string Cus_guid
        {
            get { return cus_guid; }
            set { cus_guid = value; }
        }


        public bool Cus_state
        {
            get { return cus_state; }
            set { cus_state = value; }
        }


        public int Cus_count
        {
            get { return cus_count; }
            set { cus_count = value; }
        }

        public string Join_date
        {
            get { return join_date; }
            set { join_date = value; }
        }

        public string Withdrawal_date
        {
            get { return withdrawal_date; }
            set { withdrawal_date = value; }
        }

        public int Cus_no
        {
            get { return cus_no; }
            set { cus_no = value; }
        }

        public string Cus_ID
        {
            get { return cus_ID; }
            set { cus_ID = value; }
        }

        public string Cus_pwd
        {
            get { return cus_pwd; }
            set { cus_pwd = value; }
        }
        public string Cus_phone
        {
            get { return cus_phone; }
            set { cus_phone = value; }
        }
        public string Cus_addr
        {
            get { return cus_addr; }
            set { cus_addr = value; }
        }
        public string Cus_name
        {
            get { return cus_name; }
            set { cus_name = value; }
        }
        public string Cus_Nickname
        {
            get { return cus_Nickname; }
            set { cus_Nickname = value; }
        }

        public bool Cus_gender
        {
            get { return cus_gender; }
            set { cus_gender = value; }
        }

        public int Cus_age
        {
            get { return cus_age; }
            set { cus_age = value; }
        }

        public Customer(string cus_ID, string cus_pwd, string cus_phone, string cus_addr, string cus_name, string cus_Nickname, bool cus_gender, int cus_age)
        {
            this.cus_ID = cus_ID ?? throw new ArgumentNullException(nameof(cus_ID));
            this.cus_pwd = cus_pwd ?? throw new ArgumentNullException(nameof(cus_pwd));
            this.cus_phone = cus_phone ?? throw new ArgumentNullException(nameof(cus_phone));
            this.cus_addr = cus_addr ?? throw new ArgumentNullException(nameof(cus_addr));
            this.cus_name = cus_name ?? throw new ArgumentNullException(nameof(cus_name));
            this.cus_Nickname = cus_Nickname ?? throw new ArgumentNullException(nameof(cus_Nickname));
            this.cus_gender = cus_gender;
            this.cus_age = cus_age;
        }

        public Customer()
        {
        }
    }
}