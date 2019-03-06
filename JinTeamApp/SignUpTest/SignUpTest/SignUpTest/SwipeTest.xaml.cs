using App1.VO;
using Newtonsoft.Json;
using SignUpTest;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SwipeTest : ContentPage
    {
        public static List<Product> products;
        List<Product> topP;
        List<Product> midP;
        List<Product> botP;
        Product[] f1;

        int topIndex = 0;
        int midIndex = 0;
        int botIndex = 0;

        Stock[] stockArr;
        Category[] cateArr;
        string stock_id = string.Empty;
        int stock_price = 0;
        int index = 0;

        public SwipeTest()
        {
            InitializeComponent();

            topP = new List<Product>();
            midP = new List<Product>();
            botP = new List<Product>();

            var metrics = DeviceDisplay.MainDisplayInfo;

            TopImage.HeightRequest = metrics.Height / 12;
            MidImage.HeightRequest = metrics.Height / 12;
            BotImage.HeightRequest = metrics.Height / 12;

            if (CardViewGrid.products != null)
            {
                products = CardViewGrid.products;
            }
            else
            {
                products = new List<Product>();

                string url = "http://jinweb2.azurewebsites.net/FrmShowProducts.aspx";

                WebRequest myRequest = WebRequest.Create(url);
                WebResponse myResponse = myRequest.GetResponse();
                StreamReader sr = new StreamReader(myResponse.GetResponseStream());
                var str = sr.ReadToEnd();

                f1 = JsonConvert.DeserializeObject<Product[]>(str);

                foreach (var item in f1)
                {
                    products.Add(item);
                }
            }

            foreach (var item in products)
            {
                if (item.Cat_ID.Contains("T"))
                {
                    topP.Add(item);
                }
                else if (item.Cat_ID.Contains("P"))
                {
                    midP.Add(item);
                }
                else if (item.Cat_ID.Contains("S"))
                {
                    botP.Add(item);
                }
            }

            topIndex = SwipeImage(new SwipedEventArgs(null, SwipeDirection.Left), TopImage, topIndex, topP);
            midIndex = SwipeImage(new SwipedEventArgs(null, SwipeDirection.Left), MidImage, midIndex, midP);
            botIndex = SwipeImage(new SwipedEventArgs(null, SwipeDirection.Left), BotImage, botIndex, botP);
        }

        /// <summary>
        /// 스와이프 이벤트
        /// </summary>
        /// <param name="sender">SwipeContainer</param>
        /// <param name="e"></param>
        private void SwipeGestureRecognizer_Swiped(object sender, SwipedEventArgs e)
        {
            var sc = sender as SwipeContainer;

            if (sc == top)
            {
                topIndex = SwipeImage(e, TopImage, topIndex, topP);
            }
            else if (sc == mid)
            {
                midIndex = SwipeImage(e, MidImage, midIndex, midP);
            }
            else if (sc == bot)
            {
                botIndex = SwipeImage(e, BotImage, botIndex, botP);
            }
        }
        /// <summary>
        /// 스와이프 되었을 시 이미지 처리
        /// </summary>
        /// <param name="e">스와이프 방향</param>
        /// <param name="image">부위 별 이미지</param>
        /// <param name="index">부위 별 index</param>
        /// <param name="images">부위 별 상품 목록</param>
        /// <returns></returns>
        private int SwipeImage(SwipedEventArgs e, Image image, int index, List<Product> images)
        {
            if (!(images.Count == 0) || image == null)
            {
                if (e.Direction.ToString().Equals("Left"))
                {
                    if (index == images.Count - 1)
                    {
                        index = 0;
                        image.Source = images[index].Main_Image;
                    }
                    else
                    {
                        index++;
                        image.Source = images[index].Main_Image;
                    }
                }
                else if (e.Direction.ToString().Equals("Right"))
                {
                    if (index == 0)
                    {
                        index = images.Count - 1;
                        image.Source = images[index].Main_Image;
                    }
                    else
                    {
                        index--;
                        image.Source = images[index].Main_Image;
                    }
                }
            }
            else
            {
                index = 0;
            }
            return index;
        }
        /// <summary>
        /// 이미지 클릭 이벤트 ( 장바구니 담기, 상세보기)
        /// </summary>
        /// <param name="sender">Image</param>
        /// <param name="e"></param>
        private async void ClickGestureRecognizer_Clicked(object sender, EventArgs e)
        {
            var sc = sender as Image;

            var sel = await DisplayActionSheet("상세기능", "Cancel", null, "상세보기", "장바구니담기");
            if (sel == null)
            {
                return;
            }
            else if (sel.Equals("상세보기"))
            {
                if (sc == TopImage)
                {
                    await Navigation.PushModalAsync(new WebViewTest(topP[topIndex].Pro_url));
                }
                else if (sc == MidImage)
                {
                    await Navigation.PushModalAsync(new WebViewTest(midP[midIndex].Pro_url));
                }
                else if (sc == BotImage)
                {
                    await Navigation.PushModalAsync(new WebViewTest(botP[botIndex].Pro_url));
                }
            }
            else if (sel.Equals("장바구니담기"))
            {
                // 사이즈, 수량 파악 | 재고번호 파악 => 장바구니에 담을 수 있음
                string url = string.Empty;

                if (sc == TopImage)
                {
                    url = "http://jinweb2.azurewebsites.net/FrmShowProStock.aspx?pro_id=" + topP[topIndex].Pro_ID; // 상품번호를 전달 + ;
                    stock_price = topP[topIndex].Pro_Price;
                }
                else if (sc == MidImage)
                {
                    url = "http://jinweb2.azurewebsites.net/FrmShowProStock.aspx?pro_id=" + midP[midIndex].Pro_ID; // 상품번호를 전달 + ;
                    stock_price = midP[midIndex].Pro_Price;
                }
                else if (sc == BotImage)
                {
                    url = "http://jinweb2.azurewebsites.net/FrmShowProStock.aspx?pro_id=" + botP[botIndex].Pro_ID; // 상품번호를 전달 + ;
                    stock_price = botP[botIndex].Pro_Price;
                }

                WebRequest myRequest = WebRequest.Create(url);
                WebResponse myResponse = myRequest.GetResponse();
                StreamReader sr = new StreamReader(myResponse.GetResponseStream());
                var str = sr.ReadToEnd();

                stockArr = JsonConvert.DeserializeObject<Stock[]>(str);

                foreach (var item in stockArr)
                {
                    if (item.Stock_count > 0)
                    {
                        SizePicker.Items.Add(item.Stock_size);
                    }
                }

                overlay.IsVisible = true;
            }
        }

        /// <summary>
        /// (콘텐트 뷰) 취소 버튼
        /// </summary>
        /// <param name="sender">취소 버튼</param>
        /// <param name="e"></param>
        private void Button_Clicked_1(object sender, EventArgs e)   // cancel
        {
            overlay.IsVisible = false;
            Quantity.IsEnabled = false;
            twoTap.IsVisible = false;

            SizePicker.Items.Clear();
            Quantity.Items.Clear();
            catePicker.Items.Clear();
            search.Text = string.Empty;
        }

        /// <summary>
        /// (콘텐트 뷰) 확인 버튼 (해당 상품 사이즈,수량 등을 웹 통신을 통한 저장)
        /// </summary>
        /// <param name="sender">확인 버튼</param>
        /// <param name="e"></param>
        private void Button_Clicked(object sender, EventArgs e) // ok
        {
            DateTime dt = DateTime.Now;
            string date = "_" + dt.Year + dt.Month + dt.Day + dt.Hour + dt.Minute + dt.Second;
            WishLists wish = new WishLists()
            {
                Wish_ID = Application.Current.Properties["cus_no"] + date,
                Cus_No = int.Parse(Application.Current.Properties["cus_no"].ToString()),
                Stock_ID = stock_id,
                Wish_count = int.Parse(Quantity.SelectedItem.ToString()),
                Wish_price = stock_price * int.Parse(Quantity.SelectedItem.ToString())
            };

            string json = JsonConvert.SerializeObject(wish);
            string url = "http://jinweb2.azurewebsites.net/FrmInstWishList.aspx?wish_id=" + wish.Wish_ID + "&cus_no=" + wish.Cus_No + "&stock_id=" + wish.Stock_ID + "&wish_count=" +
                wish.Wish_count + "&wish_price=" + wish.Wish_price;

            WebRequest myRequest = WebRequest.Create(url);
            WebResponse myResponse = myRequest.GetResponse();
            StreamReader sr = new StreamReader(myResponse.GetResponseStream());
            var str = sr.ReadToEnd();

            if (str.Equals("1"))
            {
                DependencyService.Get<IMessage>().Longtime("장바구니에 담겼습니다.");
            }
            else
            {
                DependencyService.Get<IMessage>().Longtime("오류 : 장바구니에 담기지 못했습니다.");
            }
            //using(HttpClient client = new HttpClient())
            //{
            //    StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
            //    var request = new HttpRequestMessage()
            //    {
            //        RequestUri = new Uri(url),
            //        Method = HttpMethod.Post,
            //        Content = content
            //    };
            //    var response = client.SendAsync(request);

            //    //string dataResult = response.Content.ReadAsStringAsync().Result;
            //    //YOUR_RESULT_ENTITY result = JsonConvert.DeserializeObject<YOUR_RESULT_ENTITY>(dataResult);
            //    //return result;
            //}

            overlay.IsVisible = false;
            Quantity.IsEnabled = false;

            //SizePicker.SelectedItem = null;
            //Quantity.SelectedItem = null;

            SizePicker.Items.Clear();
            Quantity.Items.Clear();
        }
        /// <summary>
        /// 사이즈 선택 변경 이벤트
        /// 변경 시 수량 Picker에 수량이 담김, 수량 Picker 선택 가능
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SizePicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in stockArr)
            {
                try
                {
                    if (SizePicker.SelectedItem.ToString().Equals(item.Stock_size.ToString()))
                    {
                        stock_id = item.Stock_id.ToString();
                        for (int i = 1; i <= item.Stock_count; i++)
                        {
                            Quantity.Items.Add(i.ToString());
                        }
                    }
                }
                catch (Exception)
                {
                    break;
                }
            }

            Quantity.IsEnabled = true;
        }


        // 핸드폰 뒤로가기 버튼
        /// <summary>
        /// OnBackButtonPressed 오버라이딩
        /// 진팀 뷰 에서 나올 시에 화면 초기화
        /// </summary>
        /// <returns></returns>
        protected override bool OnBackButtonPressed()
        {
            // 뒤로 갈때 모든 폼을 다시 생성해야 함.
            MainPage.mainTab.Children.Clear();
            MainPage.mainTab.Children.Add(new MyPage { BackgroundColor = Color.LightSlateGray, Title = "마이 페이지", Icon = "mypage3.png" });
            MainPage.mainTab.Children.Add(new ViewSelect { BackgroundColor = Color.LightSlateGray, Title = "쇼핑하기", Icon = "shopping.jpg" });
            MainPage.mainTab.Children.Add(new WishList { BackgroundColor = Color.LightSlateGray, Title = "장바구니", Icon = "WishCart.jpeg" });

            return base.OnBackButtonPressed();
        }

        /// <summary>
        /// 상품 탭 이벤트
        /// 상품 선택 시 웹 통신을 통해 DB에 접속 후 해당 재고 사이즈, 수량을 가져옴
        /// </summary>
        /// <param name="sender">Image</param>
        /// <param name="e"></param>
        private void TapGestureRecongizer_Tapped(object sender, EventArgs e)
        {
            string url = string.Empty;
            var sc = (sender as Image);
            if (sc == TopImage)
            {
                index = 1;
                url = "http://jinweb2.azurewebsites.net/FrmShowProStock.aspx?cat_id=" + topP[topIndex].Cat_ID; // 상품 카테고리 번호를 전달 + ;
            }
            else if (sc == MidImage)
            {
                index = 2;
                url = "http://jinweb2.azurewebsites.net/FrmShowProStock.aspx?cat_id=" + midP[midIndex].Cat_ID; // 상품 카테고리 번호를 전달 + ;
            }
            else if (sc == BotImage)
            {
                index = 3;
                url = "http://jinweb2.azurewebsites.net/FrmShowProStock.aspx?cat_id=" + botP[botIndex].Cat_ID; // 상품 카테고리 번호를 전달 + ;
            }

            WebRequest myRequest = WebRequest.Create(url);
            WebResponse myResponse = myRequest.GetResponse();
            StreamReader sr = new StreamReader(myResponse.GetResponseStream());
            var str = sr.ReadToEnd();

            try
            {
                cateArr = JsonConvert.DeserializeObject<Category[]>(str);
            }
            catch (Exception)
            {
                DependencyService.Get<IMessage>().Longtime("서버 오류");
                return;
            }

            foreach (var item in cateArr)
            {
                catePicker.Items.Add(item.Cat_kind);
            }

            twoTap.IsVisible = true;
        }

        /// <summary>
        /// (컨텐트 뷰) 확인 버튼 이벤트
        /// 해당 검색어, 카테고리 찾기
        /// </summary>
        /// <param name="sender">확인 버튼</param>
        /// <param name="e"></param>
        private void FinishBtn_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(search.Text) && catePicker.SelectedItem != null)
            {
                // 검색, 카테고리 선택
                switch (index)
                {
                    case 1:
                        SearchProduct(topIndex, TopImage, topP);
                        break;
                    case 2:
                        SearchProduct(midIndex, MidImage, midP);
                        break;
                    case 3:
                        SearchProduct(botIndex, BotImage, botP);
                        break;
                }

                catPickSel(index);
            }
            else if (!string.IsNullOrEmpty(search.Text))
            {
                // 검색
                switch (index)
                {
                    case 1:
                        SearchProduct(topIndex, TopImage, topP);
                        break;
                    case 2:
                        SearchProduct(midIndex, MidImage, midP);
                        break;
                    case 3:
                        SearchProduct(botIndex, BotImage, botP);
                        break;
                }
            }
            else if (catePicker.SelectedItem != null)
            {
                // 카테고리 선택
                catPickSel(index);
            }

            twoTap.IsVisible = false;
        }

        /// <summary>
        /// 해당 검색어 찾기
        /// </summary>
        /// <param name="index">부위 별 index</param>
        /// <param name="image">부위 별 Image</param>
        /// <param name="products">부위 별 상품 목록</param>
        private void SearchProduct(int index, Image image, List<Product> products)
        {
            index = 0;
            image.Source = "";
            Product[] selectP = products.ToArray();
            products.Clear();
            foreach (var item in selectP)
            {
                if (item.Pro_Name.Contains(search.Text))
                {
                    products.Add(item);
                }
            }

            if (products.Count > 0)
            {
                image.Source = products[index++].Pro_url;
            }
            else
            {
                image.Source = "https://cdn.pixabay.com/photo/2012/04/12/20/12/x-30465_960_720.png";
            }
        }

        /// <summary>
        /// 카테고리 선택
        /// </summary>
        /// <param name="index">부위 별 index</param>
        private void catPickSel(int index)
        {
            string cat = string.Empty;

            foreach (var item in cateArr)
            {
                if (item.Cat_kind.Equals(catePicker.SelectedItem.ToString()))
                {
                    cat = item.Cat_ID;
                    break;
                }
            }

            switch (index)
            {
                case 1:
                    ChangeProducts(cat, topIndex, TopImage, topP);
                    break;
                case 2:
                    ChangeProducts(cat, midIndex, MidImage, midP);
                    break;
                case 3:
                    ChangeProducts(cat, botIndex, BotImage, botP);
                    break;
            }
        }

        /// <summary>
        /// 카테고리, 검색어 검색 시 해당 부위 초기화
        /// </summary>
        /// <param name="cat">카테고리 분류</param>
        /// <param name="Index">부위 별 index</param>
        /// <param name="image">부위 별 Image</param>
        /// <param name="products">부위 별 상품목록</param>
        private void ChangeProducts(string cat, int Index, Image image, List<Product> products)
        {
            Index = 0;
            image.Source = "";
            Product[] selectP = products.ToArray();
            products.Clear();
            foreach (var item in selectP)
            {
                if (item.Cat_ID.Equals(cat))
                {
                    products.Add(item);
                }
                else if (cat.Contains("00"))
                {
                    products.Add(item);
                }
            }

            if (products.Count > 0)
            {
                image.Source = products[Index++].Pro_url;
            }
            else
            {
                image.Source = "https://cdn.pixabay.com/photo/2012/04/12/20/12/x-30465_960_720.png";
            }
        }

        /// <summary>
        /// 수량 목록 선택 시 이벤트
        /// 확인 버튼 사용 가능
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Quantity_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_OK.IsEnabled = true;
        }
    }
}