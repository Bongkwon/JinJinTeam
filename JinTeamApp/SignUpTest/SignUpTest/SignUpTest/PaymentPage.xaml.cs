using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SignUpTest
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaymentPage : ContentPage
    {
        string json;
        List<string> jsonArr = new List<string>();
        StreamReader sr;
        WebRequest myRequest;
        WebResponse myResponse;
        string cus_no = Convert.ToString(Application.Current.Properties["cus_no"]);
        List<Juso> lstJuso = new List<Juso>();
        WishLists[] paymentList;
        string user_ship_ID;

        public PaymentPage()
        {
            InitializeComponent();

            string url = "http://jinweb2.azurewebsites.net/FrmShowWishList.aspx" + "?cus_No=" + cus_no;

            myRequest = WebRequest.Create(url);
            myResponse = myRequest.GetResponse();
            sr = new StreamReader(myResponse.GetResponseStream());

            json = sr.ReadToEnd();

            if (json == "1301")
            {
                // No없음 에러 (나올수 없음)
            }
            else if (json == "1302")
            {
                //장바구니 내역이 없음;  (앞에서 장바구니 내역이 없으면 폼을 못 열게 만들어서 미리 처리함)
            }
            else
            {
                paymentList = JsonConvert.DeserializeObject<WishLists[]>(json);
                wishListView.BindingContext = paymentList;
            }
        }

        /// <summary>
        /// 내 주소 불러오기 버튼 이벤트
        /// 내 주소 목록에 저장되어있는 주소들을 불러온다
        /// </summary>
        /// <param name="sender">불러오기 버튼</param>
        /// <param name="e"></param>
        private void OpenMyAddr_Clicked(object sender, EventArgs e)
        {
            if (OpenAddr.IsVisible)
            {
                OpenAddr.IsVisible = false;
            }
            else
            {
                OpenAddr.IsVisible = true;


                string url = "http://jinweb2.azurewebsites.net/FrmSavedUserShipInfo.aspx" + "?cus_no=" + cus_no;

                myRequest = WebRequest.Create(url);
                myResponse = myRequest.GetResponse();
                sr = new StreamReader(myResponse.GetResponseStream());

                json = sr.ReadToEnd();

                if (json == "2200")
                {
                    DisplayAlert("오류", "잘못된 경로 입니다.", "확인");    // cus_no 입력이 없는에러 (일어날 수 없음)
                }
                else if (json == "2201")
                {
                    txtMyAddr.Text = "저장하신 배송지가 없습니다";
                }
                else
                {
                    var v2 = JsonConvert.DeserializeObject<UserShipInfo[]>(json);
                    SavedAddr.ItemsSource = v2;
                }
            }
        }

        /// <summary>
        /// 주소 추가 이벤트
        /// 내 목록에 해당하는 주소중 선택한 주소를 불러옴
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void AddrTapped(object sender, ItemTappedEventArgs e)
        {
            var answer = await DisplayAlert("주소확인", "선택하신 주소를 불러오시겠습니까?", "예", "아니오");
            if (answer)
            {
                user_ship_ID = (e.Item as UserShipInfo).User_Ship_Id;
                txtUser_Name.Text = (e.Item as UserShipInfo).User_name;
                txtPostal_Code.Text = (e.Item as UserShipInfo).Postal_Code;
                txtUser_Addr.Text = (e.Item as UserShipInfo).User_addr;
                txtShip_Require.Text = (e.Item as UserShipInfo).Ship_Require;

                OpenAddr.IsVisible = false;
            }
            else
            {
                OpenAddr.IsVisible = false;
            }
        }

        /// <summary>
        /// 결제 완료 이벤트
        /// 모든 유효성 검사를 마친 뒤
        /// 결제가 정상적으로 완료되는 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PaymentComplete_Clicked(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUser_Name.Text))
            {
                DependencyService.Get<IMessage>().Longtime("받으시는분 성함을 입력해주세요");
            }
            else if (String.IsNullOrEmpty(txtUser_Addr.Text))
            {
                DependencyService.Get<IMessage>().Longtime("배송받을 주소를 입력해주세요");
            }
            else
            {
                for (int i = 0; i < paymentList.Length; i++)
                {
                    DateTime dt = DateTime.Now;
                    string url = "http://jinweb2.azurewebsites.net/FrmPayment.aspx" + "?order_ID=" + cus_no + dt.Year + dt.Month + dt.Day + dt.Hour + dt.Minute + dt.Second + i + "&cus_no=" + cus_no + "&stock_ID=" + paymentList[i].Stock_ID + "&order_count=" + paymentList[i].Wish_count + "&order_price=" + paymentList[i].Wish_price + "&ship_require=" + txtShip_Require.Text + "&user_ship_ID=" + user_ship_ID + "&wish_ID=" + paymentList[i].Wish_ID;

                    myRequest = WebRequest.Create(url);
                    myResponse = myRequest.GetResponse();
                    sr = new StreamReader(myResponse.GetResponseStream());

                    jsonArr.Add(sr.ReadToEnd());
                }

                string errItem = "";
                for (int i = 0; i < jsonArr.Count; i++)
                {
                    if (jsonArr[i].Equals("3000"))
                    {
                        // 주문 성공
                    }
                    else
                    {
                        errItem += paymentList[i].Pro_name + " ,";
                        errItem.Replace(" ,", "");
                    }
                }
                if (String.IsNullOrEmpty(errItem))
                {
                    DependencyService.Get<IMessage>().Longtime("결제가 완료되었습니다");

                    MainPage.mainTab.Children.Clear();
                    MainPage.mainTab.Children.Add(new MyPage { BackgroundColor = Color.LightSlateGray, Title = "마이 페이지", Icon = "mypage3.png" });
                    MainPage.mainTab.Children.Add(new ViewSelect { BackgroundColor = Color.LightSlateGray, Title = "쇼핑하기", Icon = "shopping.jpg" });
                    MainPage.mainTab.Children.Add(new WishList { BackgroundColor = Color.LightSlateGray, Title = "장바구니", Icon = "WishCart.jpeg" });

                    OnBackButtonPressed();
                }
                else
                {
                    DisplayAlert("실패", errItem + " 상품에 대해 결제 오류가 발생하였습니다", "확인");
                }
            }
        }

        private void Cancel_Clicked(object sender, EventArgs e)
        {
            OnBackButtonPressed();
        }

        private void NewAddr_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new AddressSetting());
        }
    }
}