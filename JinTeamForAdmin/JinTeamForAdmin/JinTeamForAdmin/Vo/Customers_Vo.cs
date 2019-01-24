using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JinTeamForAdmin.Vo
{
    class Customers_Vo
    {
        private int cus_no;

        public int Cus_no
        {
            get { return cus_no; }
            set { cus_no = value; }
        }
        private string cus_ID;

        public string Cus_ID
        {
            get { return cus_ID; }
            set { cus_ID = value; }
        }

        private string cus_pwd;

        public string Cus_pwd
        {
            get { return cus_pwd; }
            set { cus_pwd = value; }
        }

        private string cus_phone;

        public string Cus_phone
        {
            get { return cus_phone; }
            set { cus_phone = value; }
        }

        private string cus_addr;

        public string Cus_addr
        {
            get { return cus_addr; }
            set { cus_addr = value; }
        }

        private string cus_name;

        public string Cus_name
        {
            get { return cus_name; }
            set { cus_name = value; }
        }

        private string cus_Nickname;

        public string Cus_Nickname
        {
            get { return cus_Nickname; }
            set { cus_Nickname = value; }
        }

        private bool cus_gender;

        public bool Cus_gender
        {
            get { return cus_gender; }
            set { cus_gender = value; }
        }

        private int cus_age;

        public int Cus_age
        {
            get { return cus_age; }
            set { cus_age = value; }
        }

        private bool cus_state;

        public bool Cus_state
        {
            get { return cus_state; }
            set { cus_state = value; }
        }

        private int cus_count;

        public int Cus_count
        {
            get { return cus_count; }
            set { cus_count = value; }
        }

        private string withdrawal_date;

        public string Withdrawal_date
        {
            get { return withdrawal_date; }
            set { withdrawal_date = value; }
        }

        private DateTime join_date;

        public DateTime Join_date
        {
            get { return join_date; }
            set { join_date = value; }
        }


    }
}
