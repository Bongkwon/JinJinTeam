using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JinTeamForSeller.Vo
{
    class CatVO
    {
        private string cat_ID;

        public string Cat_ID
        {
            get { return cat_ID; }
            set { cat_ID = value; }
        }
        private string cat_kind;

        public string Cat_Kind
        {
            get { return cat_kind; }
            set { cat_kind = value; }
        }

        public CatVO(string cat_ID, string cat_kind)
        {
            this.cat_ID = cat_ID ?? throw new ArgumentNullException(nameof(cat_ID));
            this.cat_kind = cat_kind ?? throw new ArgumentNullException(nameof(cat_kind));
        }
    }
}
