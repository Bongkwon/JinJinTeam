using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SignUpTest
{
    public partial class MainPage : ContentPage
    {
        string errCode;
        StreamReader sr;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Login_Clicked(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtID.Text) || String.IsNullOrEmpty(txtPassword.Text))
            {
                DisplayAlert("입력오류", "아이디와 비밀번호를 입력해주세요", "확인");
            }

            else
            {
                string url = "http://jinweb.azurewebsites.net/FrmLogin.aspx" + "?cus_ID=" + txtID.Text + "&cus_pwd=" + txtPassword.Text;

                WebRequest myRequest = WebRequest.Create(url);
                using (WebResponse myResponse = myRequest.GetResponse())
                {
                    sr = new StreamReader(myResponse.GetResponseStream());
                }


                errCode = sr.ReadToEnd();


                if (errCode == "600")
                {
                    DisplayAlert("Login failed", "아이디 혹은 비밀번호가 적절하지 않습니다", "확인");
                }
                else
                {
                    var v = JsonConvert.DeserializeObject<Customer[]>(errCode);
                    Application.Current.Properties["cus_no"] = v[0].Cus_no;

                    var mainTab = new TabbedPage();
                    mainTab.BarBackgroundColor = Color.LightGray;
                    mainTab.BarTextColor = Color.OrangeRed;

                    mainTab.Children.Add(new MyPage { BackgroundColor = Color.LightSlateGray, Title = "MyPage", Icon = "mypage3.png" });
                    mainTab.Children.Add(new JinteamView { BackgroundColor = Color.LightSlateGray, Title = "진팀뷰", Icon = "jinteamview.jpg" });
                    mainTab.Children.Add(new ClassicViewPage { BackgroundColor = Color.LightSlateGray, Title = "클래식뷰", Icon = "classicview.jpg" });
                    mainTab.Children.Add(new WishList { BackgroundColor = Color.LightSlateGray, Title = "장바구니", Icon = "WishCart.jpeg" });

                    Navigation.PushModalAsync(mainTab);
                }

            }
        }
        private void SignUp_Cliekced(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new SignUp());
        }
    }
}
