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
using Xamarin.Forms.Xaml;

namespace SignUpTest
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WishList : ContentPage
    {
        string json;
        WishLists[] v;
        WebRequest myRequest;
        WebResponse myResponse;
        StreamReader sr;

        int cus_No = Convert.ToInt32(Application.Current.Properties["cus_no"]);

        public WishList()
        {
            InitializeComponent();

            string url = "http://jinweb2.azurewebsites.net/FrmShowWishList.aspx" + "?cus_No=" + cus_No;

            myRequest = WebRequest.Create(url);
            myResponse = myRequest.GetResponse();
            sr = new StreamReader(myResponse.GetResponseStream());

            json = sr.ReadToEnd();

            if (json == "1301")
            {
                //txtTitle.Text = "잘못된 경로입니다";    // No없음 에러 (나올수 없음)
            }
            else if (json == "1302")
            {
                //txtTitle.Text = "장바구니 추가내역이 없습니다";
            }
            else
            {
                v = JsonConvert.DeserializeObject<WishLists[]>(json);
                wishListView.BindingContext = v;
            }
        }

        /// <summary>
        /// 리스트 탭 이벤트 (목록 선택 시 해당 품목에 대한 기능 선택)
        /// </summary>
        /// <param name="sender">리스트 선택 아이템</param>
        /// <param name="e">ItemTappedEventArgs</param>
        private async void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            var flag = await DisplayActionSheet(null, "취소", null, "상세보기", "리뷰보기", "장바구니 삭제");
            if (flag == null)
            {
                return;
            }
            else if (flag.Equals("상세보기"))
            {
                await Navigation.PushModalAsync(new WebViewTest((e.Item as WishLists).Pro_url));
            }
            else if (flag.Equals("리뷰보기"))
            {
                await Navigation.PushModalAsync(new ListReview((e.Item as WishLists).Stock_ID, (e.Item as WishLists).Pro_name, (e.Item as WishLists).Main_image));
            }
            else if (flag.Equals("장바구니 삭제"))
            {
                string url = "http://jinweb2.azurewebsites.net/FrmDeleteWishList.aspx" + "?wish_ID=" + (e.Item as WishLists).Wish_ID;

                myRequest = WebRequest.Create(url);
                myResponse = myRequest.GetResponse();
                sr = new StreamReader(myResponse.GetResponseStream());
                json = sr.ReadToEnd();

                if (json == "2101")
                {
                    DependencyService.Get<IMessage>().Longtime("장바구니 상품삭제 완료");

                    //모든 폼을 다시 생성해야 함.
                    MainPage.mainTab.Children.Clear();
                    MainPage.mainTab.Children.Add(new MyPage { BackgroundColor = Color.LightSlateGray, Title = "마이 페이지", Icon = "mypage3.png" });
                    MainPage.mainTab.Children.Add(new ViewSelect { BackgroundColor = Color.LightSlateGray, Title = "쇼핑하기", Icon = "shopping.jpg" });
                    MainPage.mainTab.Children.Add(new WishList { BackgroundColor = Color.LightSlateGray, Title = "장바구니", Icon = "WishCart.jpeg" });

                    MainPage.mainTab.CurrentPage = MainPage.mainTab.Children[2];
                }
            }
            else
            {
                DependencyService.Get<IMessage>().Longtime("서버오류");
                // 알 수 없는 에러
            }
        }
        /// <summary>
        /// 구매 버튼 이벤트 (장바구니에 담긴 모든 상품을 구매)
        /// </summary>
        /// <param name="v">고객의 장바구니 목록</param>
        /// <param name="sender">구매 버튼</param>
        /// <param name="e"></param>
        private void WishListBuyAll_Clicked(object sender, EventArgs e)
        {
            if (v==null)
            {
                DependencyService.Get<IMessage>().Longtime("장바구니에 상품을 추가해주세요");
            }
            else
            {
                Navigation.PushModalAsync(new PaymentPage());
            }
        }
        /// <summary>
        /// 바구니 비우기 버튼 이벤트 ( 장바구니에 담긴 모든 상품 비우기)
        /// </summary>
        /// <param name="sender">비우기 버튼</param>
        /// <param name="e"></param>
        private async void WishListClear_Clicked(object sender, EventArgs e)
        {
            var flag = await DisplayAlert(null, "장바구니를 모두 비우시겠습니까?", "예", "아니오");
            if (flag)
            {
                if (v == null)
                {
                    DependencyService.Get<IMessage>().Longtime("장바구니가 비어있습니다");
                }
                else
                {
                    string url = "http://jinweb2.azurewebsites.net/FrmDeleteWishList.aspx" + "?cus_No=" + cus_No;

                    myRequest = WebRequest.Create(url);
                    myResponse = myRequest.GetResponse();
                    sr = new StreamReader(myResponse.GetResponseStream());
                    json = sr.ReadToEnd();

                    if (json == "2100")
                    {
                        DependencyService.Get<IMessage>().Longtime("장바구니를 비웠습니다");

                        //모든 폼을 다시 생성해야 함.
                        MainPage.mainTab.Children.Clear();
                        MainPage.mainTab.Children.Add(new MyPage { BackgroundColor = Color.LightSlateGray, Title = "마이 페이지", Icon = "mypage3.png" });
                        MainPage.mainTab.Children.Add(new ViewSelect { BackgroundColor = Color.LightSlateGray, Title = "쇼핑하기", Icon = "shopping.jpg" });
                        MainPage.mainTab.Children.Add(new WishList { BackgroundColor = Color.LightSlateGray, Title = "장바구니", Icon = "WishCart.jpeg" });

                        MainPage.mainTab.CurrentPage = MainPage.mainTab.Children[2];
                    }
                }
            }
        }
        /// <summary>
        /// OnBackButtonPressed 오버라이딩(콘텐트뷰 보이기)
        /// </summary>
        /// <returns>bool</returns>
        protected override bool OnBackButtonPressed()
        {
            if (AppCloseOption.IsVisible)
            {
                AppCloseOption.IsVisible = false;
            }
            else
            {
                AppCloseOption.IsVisible = true;
            }
            return true;
        }
        /// <summary>
        /// (콘텐트 뷰) 로그아웃 버튼 이벤트
        /// </summary>
        /// <param name="sender">로그아웃 버튼</param>
        /// <param name="e"></param>
        private void Logout_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new MainPage();
        }
        /// <summary>
        /// (콘텐트 뷰) 취소 버튼 이벤트
        /// </summary>
        /// <param name="sender">취소 버튼</param>
        /// <param name="e"></param>
        private void Cancel_Clicked(object sender, EventArgs e)
        {
            AppCloseOption.IsVisible = false;
        }
    }
}