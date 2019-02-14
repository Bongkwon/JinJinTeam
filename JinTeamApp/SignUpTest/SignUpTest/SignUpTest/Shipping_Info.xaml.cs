﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SignUpTest
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Shipping_Info : ContentPage
	{
        string order_ID;
        string json = String.Empty;
        StreamReader sr;

        public Shipping_Info ()
		{
			InitializeComponent ();
            order_ID = Convert.ToString(Application.Current.Properties["order_ID"]);

            string url = "http://jinweb.azurewebsites.net/FrmUserShipInfo.aspx" + "?order_ID=" + order_ID;

            WebRequest myRequest = WebRequest.Create(url);
            WebResponse myResponse = myRequest.GetResponse();
            sr = new StreamReader(myResponse.GetResponseStream());

            json = sr.ReadToEnd();

            if (json == "800")
            {
                txtTitle.Text = "잘못된 경로입니다";    // ID없음 에러
            }
            else if (json == "801")
            {
                txtTitle.Text = "배송준비중 입니다";
            }
            else
            {
                var v = JsonConvert.DeserializeObject<UserShipInfo[]>(json);
                txtUserName.Text = "받는이 : "+ v[0].User_name;
                txtShipRequire.Text = "요구사항 : "+v[0].Ship_Require;
                txtUserAddr.Text = "배송지 : " +v[0].User_addr;
                txtPostalCode.Text = "우편번호 : " +v[0].Postal_Code;
                txtWayBillID.Text = "운송장 번호 : " + v[0].Waybill_ID;
                BindingContext = v;
            }

            Application.Current.Properties["order_ID"] = "";    // 비움;
        }
    }
}