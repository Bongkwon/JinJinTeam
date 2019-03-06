using App1;
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
        public static TabbedPage mainTab;
        string errCode;
        StreamReader sr;
        public static Customer[] customers;
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
                string url = "http://jinweb2.azurewebsites.net/FrmLogin.aspx" + "?cus_ID=" + txtID.Text + "&cus_pwd=" + txtPassword.Text;

                WebRequest myRequest = WebRequest.Create(url);
                using (WebResponse myResponse = myRequest.GetResponse())
                {
                    sr = new StreamReader(myResponse.GetResponseStream());
                }


                try
                {
                    errCode = sr.ReadToEnd();
                }
                catch (WebException)
                {
                    DisplayAlert("Login failed", "다시 시도해 주세요", "확인");
                    return;
                }


                if (errCode == "600")
                {
                    DisplayAlert("Login failed", "아이디 혹은 비밀번호가 적절하지 않습니다", "확인");
                }
                else
                {
                    customers = JsonConvert.DeserializeObject<Customer[]>(errCode);
                    customers[0].Cus_pwd = txtPassword.Text;
                    Application.Current.Properties["cus_no"] = customers[0].Cus_no;
                    //Application.Current.Properties["cus_pwd"] = customers[0].Cus_pwd;
                    //Application.Current.Properties["cus_name"] = customers[0].Cus_name;
                    //Application.Current.Properties["cus_Ninkname"] = customers[0].Cus_Nickname;
                    //Application.Current.Properties["cus_addr"] = customers[0].Cus_addr;
                    //Application.Current.Properties["cus_phone"] = customers[0].Cus_phone;
                    //Application.Current.Properties["cus_gender"] = customers[0].Cus_gender;


                    mainTab = new TabbedPage();
                    mainTab.BarBackgroundColor = Color.LightGray;
                    mainTab.BarTextColor = Color.OrangeRed;

                    mainTab.Children.Add(new MyPage { BackgroundColor = Color.LightSlateGray, Title = "마이 페이지", Icon = "mypage3.png" });
                    mainTab.Children.Add(new ViewSelect { BackgroundColor = Color.LightSlateGray, Title = "쇼핑하기", Icon = "shopping.jpg" });
                    //mainTab.Children.Add(new SwipeTest { BackgroundColor = Color.LightSlateGray, Title = "진팀뷰", Icon = "jinteamview.jpg" });
                    //mainTab.Children.Add(new ClassicViewPage { BackgroundColor = Color.LightSlateGray, Title = "클래식뷰", Icon = "classicview.jpg" });
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
