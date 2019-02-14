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

        public OrderHistory()
        {
            InitializeComponent();

            cus_no = Convert.ToString(Application.Current.Properties["cus_no"]);
            //DependencyService.Get<IMessage>().Longtime(cus_no);

            string url = "http://jinweb.azurewebsites.net/FrmOrderList.aspx" + "?cus_no=" + cus_no;

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
                BindingContext = v;



                //OrderHistoryView.ItemsSource = v;
            }
        }

        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null) return;

            var click = await DisplayAlert("주문 상세정보", (e.SelectedItem as Order).Order_Id.ToString() + "제품의 상세정보 내용...", "취소", "배송정보");
            Application.Current.Properties["order_ID"] = (e.SelectedItem as Order).Order_Id.ToString();


            if (click == false)
            {
                await Navigation.PushModalAsync(new Shipping_Info());
            }
            ((ListView)sender).SelectedItem = null;
        }

        private void Review_Clicked(object sender, EventArgs e)
        {

        }
    }
}