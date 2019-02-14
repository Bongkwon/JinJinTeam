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
        static public string zipNo = "";
        static public string roadAddr = "";
        FrmInsertSeller frm;
        List<Juso> lstJuso = new List<Juso>();
        Label[] lblZipCode;
        Label[] lblJibJuso;
        Label[] lblRoadJuso;
        TextBox[] txtSangse;
        bool canSubmit = false;

        int i = 1;
        public FrmSearchAddr()
        {
            InitializeComponent();
        }
        public FrmSearchAddr(FrmInsertSeller frm): this()
        {
            this.frm = frm;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {            
            lstJuso.Clear();
            if (lblZipCode != null)
            {
                for (int i = 0; i < 6; i++)
                {
                    lblZipCode[i].Text = "";
                    lblJibJuso[i].Text = "";
                    lblRoadJuso[i].Text = "";
                }
            }
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
                    lstJuso.Add(new Juso(item.SelectSingleNode("roadAddr").InnerText, item.SelectSingleNode("jibunAddr").InnerText, item.SelectSingleNode("zipNo").InnerText));
                }
            }
            res.Close();
            
            lblZipCode = new Label[] { lblPostalCode1, lblPostalCode2, lblPostalCode3, lblPostalCode4, lblPostalCode5, lblPostalCode6 };
            lblJibJuso = new Label[] { lblJibunAddr1, lblJibunAddr2, lblJibunAddr3, lblJibunAddr4, lblJibunAddr5, lblJibunAddr6 };
            lblRoadJuso = new Label[] { lblRoadAddr1, lblRoadAddr2, lblRoadAddr3, lblRoadAddr4, lblRoadAddr5, lblRoadAddr6 };
            txtSangse = new TextBox[] { txtsangseAddr1, txtsangseAddr2, txtsangseAddr3, txtsangseAddr4, txtsangseAddr5, txtsangseAddr6 };
            try
            {
                for (int i = 0; i < 6; i++)
                {
                    lblZipCode[i].Text = lstJuso[i].ZipNo;
                    lblJibJuso[i].Text = lstJuso[i].JibunAddr;
                    lblRoadJuso[i].Text = lstJuso[i].RoadAddr;
                }
                canSubmit = true;
            }
            catch (Exception)
            {
                //MessageBox.Show("없는 주소 입니다. 다시 검색 해 주세요.");
            }

        }
        
        private void Submit(int index)
        {
            if (!string.IsNullOrEmpty(lblZipCode[index].Text))
            {
                zipNo = lblZipCode[index].Text;
                roadAddr = lblRoadJuso[index].Text;
                roadAddr += "\r\n" + txtSangse[index].Text;
                this.Close();
            }
        }

        #region 판넬 이벤트 등록용
        private void panel1_DoubleClick(object sender, EventArgs e)
        {
            if (canSubmit)
            {
                Submit(0);
            }
        }
        private void panel2_DoubleClick(object sender, EventArgs e)
        {
            if (canSubmit)
            {
                Submit(1);
            }
        }

        private void panel3_DoubleClick(object sender, EventArgs e)
        {
            if (canSubmit)
            {
                Submit(2);
            }
        }

        private void panel4_DoubleClick(object sender, EventArgs e)
        {
            if (canSubmit)
            {
                Submit(3);
            }
        }

        private void panel5_DoubleClick(object sender, EventArgs e)
        {
            if (canSubmit)
            {
                Submit(4);
            }
        }

        private void panel6_DoubleClick(object sender, EventArgs e)
        {
            if (canSubmit)
            {
                Submit(5);
            }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }    
}
