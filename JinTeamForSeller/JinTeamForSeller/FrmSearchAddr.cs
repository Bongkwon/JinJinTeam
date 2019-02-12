using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace JinTeamForSeller
{
    public partial class FrmSearchAddr : Form
    {
        List<Juso> lstJuso = new List<Juso>();
        int i = 1;
        public FrmSearchAddr()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string uri = "http://www.juso.go.kr/addrlink/addrLinkApi.do?confmKey=U01TX0FVVEgyMDE5MDIxMjE2MjA1MzEwODUwMjU=&currentPage=" + i + "&countPerPage=6&keyword=" + txtSearch.Text;
            //ConfigurationManager.AppSettings["key"].ToString();
            var req = (HttpWebRequest)WebRequest.Create(uri);
            var res = (HttpWebResponse)req.GetResponse();

            var statusCode = res.StatusCode.ToString();
            if(statusCode == "OK")
            {
                var stream = res.GetResponseStream();
                var sr = new StreamReader(stream, Encoding.UTF8);
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(sr.ReadToEnd());
                XmlNodeList lstxml = doc.DocumentElement.SelectNodes("/results/juso");
                foreach (XmlNode item in lstxml)
                {
                    lstJuso.Add(new Juso(item.SelectSingleNode("roadAddr").Value, item.SelectSingleNode("jibunAddr").InnerText, item.SelectSingleNode("zipNo").InnerText));
                }
            }
            res.Close();
            foreach (var item in lstJuso)
            {
                
            }
            Label[] lb = new Label[4];
            Controls.AddRange(lb);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            i++;

        }
    }
}
