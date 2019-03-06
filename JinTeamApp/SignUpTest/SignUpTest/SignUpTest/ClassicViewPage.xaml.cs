using App1.VO;
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
    public partial class ClassicViewPage : ContentPage
    {
        public static List<Product> products;
        Product[] f1;

        public ClassicViewPage()
        {
            InitializeComponent();

            if (App1.SwipeTest.products != null)
            {
                products = App1.SwipeTest.products;
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
                BindingContext = f1;
            }



            //gridLayout.RowDefinitions.Add(new RowDefinition());
            //gridLayout.RowDefinitions.Add(new RowDefinition());
            //gridLayout.ColumnDefinitions.Add(new ColumnDefinition());
            //gridLayout.ColumnDefinitions.Add(new ColumnDefinition());
            //gridLayout.ColumnDefinitions.Add(new ColumnDefinition());

            //var productIndex = 0;
            //for (int rowIndex = 0; rowIndex < 2; rowIndex++)
            //{
            //    for (int columnIndex = 0; columnIndex < 3; columnIndex++)
            //    {
            //        if (productIndex >= products.Count)
            //        {
            //            break;
            //        }
            //        var product = products[productIndex];
            //        productIndex += 1;

            //        var label2 = new Label
            //        {
            //            Text = "ㅎㅇ"
            //        };

            //        gridLayout.Children.Add(cd, columnIndex, rowIndex);
            //    }
            //}
        }

        private void OnItemTapped(object sender, ItemTappedEventArgs e)
        {

        }
    }
}



//private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
//{
//    // 클래식뷰에서 클릭했을 때 화면 ( 웹에서~~~~
//    DisplayAlert("상세정보창", "제품상세설명~~~", "OK");

//    CardView.CardView cd = new CardView.CardView();
//}

