using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JinTeamForServer
{
    public class Category
    {
        private string cat_ID;

        public string Cat_ID
        {
            get { return cat_ID; }
            set { cat_ID = value; }
        }
        private string cat_kind;

        public string Cat_kind
        {
            get { return cat_kind; }
            set { cat_kind = value; }
        }
    }
}