using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JinTeamForSeller
{
    class Juso
    {
        private string roadAddr;

        public string RoadAddr
        {
            get { return roadAddr; }
            set { roadAddr = value; }
        }
        private string jibunAddr;

        public string JibunAddr
        {
            get { return jibunAddr; }
            set { jibunAddr = value; }
        }
        private string zipNo;

        public string ZipNo
        {
            get { return zipNo; }
            set { zipNo = value; }
        }

        public Juso(string roadAddr, string jibunAddr, string zipNo)
        {
            this.roadAddr = roadAddr;
            this.jibunAddr = jibunAddr;
            this.zipNo = zipNo;
        }
    }
}
