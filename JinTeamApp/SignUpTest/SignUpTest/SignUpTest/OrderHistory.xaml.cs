using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
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
    public partial class OrderHistory : ContentPage
    {
        string json = String.Empty;
        StreamReader sr;
        string cus_no;
        string stock_Id;

        public OrderHistory()
        {
            InitializeComponent();

            cus_no = Convert.ToString(Application.Current.Properties["cus_no"]);
            //DependencyService.Get<IMessage>().Longtime(cus_no);

            string url = "http://jinweb2.azurewebsites.net/FrmOrderList.aspx" + "?cus_no=" + cus_no;

            WebRequest myRequest = WebRequest.Create(url);
            WebResponse myResponse = myRequest.GetResponse();
            sr = new StreamReader(myResponse.GetResponseStream());

            json = sr.ReadToEnd();

            if (json == "700")
            {
                DisplayAlert("주문내역 오류", "잘못된 경로 입니다.", "확인");
            }
            else if (json == "701")
            {
                txtHI.Text = "주문하신 내역이 없습니다";
            }
            else
            {
                var v = JsonConvert.DeserializeObject<Order[]>(json);
                OrderHistoryView.BindingContext = v;



                //OrderHistoryView.ItemsSource = v;
            }
        }
        private void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            
            if (e.Item == null) return;

            Application.Current.Properties["order_ID"] = (e.Item as Order).Order_Id.ToString();
            stock_Id = (e.Item as Order).Stock_Id;
            DetailOption.IsVisible = true;
            
        }


        protected override bool OnBackButtonPressed()
        {
            if (DetailOption.IsVisible)
            {
                DetailOption.IsVisible = false;
                return true;
            }
            else
            {
                return base.OnBackButtonPressed();
            }
        }

        private void ShipInfo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Shipping_Info());
            DetailOption.IsVisible = false;
        }

        private void InsertReview_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new InsertReview(stock_Id));
            DetailOption.IsVisible = false;
        }

        private void Cancel_Clicked(object sender, EventArgs e)
        {
            DetailOption.IsVisible = false;
        }
    }
}