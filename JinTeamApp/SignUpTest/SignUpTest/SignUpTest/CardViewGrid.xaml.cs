using App1.VO;
using Newtonsoft.Json;
using SignUpTest;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CardViewGrid : ContentPage
    {
        List<CardViewTest> cards = new List<CardViewTest>();
        public static List<Product> products;
        int productIndex = 0;
        int rowIndex = 0;
        int columnIndex = 0;
        int rowVariable = 3;
        const int columnConst = 3;

        public CardViewGrid()
        {
            InitializeComponent();

            if (SwipeTest.products == null)
            {
                products = new List<Product>();

                string url = "http://jinweb2.azurewebsites.net/FrmShowProducts.aspx";

                WebRequest myRequest = WebRequest.Create(url);
                WebResponse myResponse = myRequest.GetResponse();
                StreamReader sr = new StreamReader(myResponse.GetResponseStream());
                var str = sr.ReadToEnd();

                products = JsonConvert.DeserializeObject<Product[]>(str).ToList();
            }
            else
            {
                products = SwipeTest.products;
            }

            foreach (var item in products)
            {
                CardViewTest cardview = new CardViewTest(item.Pro_Name, item.Main_Image, item.Pro_Price);

                cards.Add(cardview);
            }
            
            gridLayout.ColumnDefinitions.Add(new ColumnDefinition());
            gridLayout.ColumnDefinitions.Add(new ColumnDefinition());
            gridLayout.ColumnDefinitions.Add(new ColumnDefinition());

            Loading_scroll();
        }

        private void Loading_scroll()
        {
            if (productIndex >= cards.Count)
            {
                return;
            }
            gridLayout.RowDefinitions.Add(new RowDefinition());
            gridLayout.RowDefinitions.Add(new RowDefinition());
            gridLayout.RowDefinitions.Add(new RowDefinition());

            for (; rowIndex < rowVariable; rowIndex++)
            {
                for (columnIndex = 0; columnIndex < columnConst; columnIndex++)
                {
                    if (productIndex >= cards.Count)
                    {
                        break;
                    }
                    var product = cards[productIndex];
                    productIndex += 1;

                    gridLayout.Children.Add(product, columnIndex, rowIndex);
                }
            }
            rowVariable += 3;
        }

        private void ScrollView_Scrolled(object sender, ScrolledEventArgs e)
        {
            var item = sender as ScrollView;
            if (item == null)
            {
                return;
            }

            var scrollingSpace = item.ContentSize.Height - item.Height;
            if (scrollingSpace <= e.ScrollY)
            {
                if (productIndex == cards.Count)
                {
                    return;
                }

                DependencyService.Get<IMessage>().Shorttime("Loading...");
                Loading_scroll();
            }
        }

        private void Search_Clicked(object sender, EventArgs e)
        {
            cards.Clear();
            gridLayout.RowDefinitions.Clear();
            gridLayout.ColumnDefinitions.Clear();
            gridLayout.Children.Clear();

            foreach (var item in products)
            {
                if (item.Pro_Name.Contains(txt_search.Text))
                {
                    CardViewTest cardview = new CardViewTest(item.Pro_Name, item.Main_Image, item.Pro_Price);

                    cards.Add(cardview);
                }
            }

            productIndex = 0;
            rowIndex = 0;
            rowVariable = 3;

            gridLayout.ColumnDefinitions.Add(new ColumnDefinition());
            gridLayout.ColumnDefinitions.Add(new ColumnDefinition());
            gridLayout.ColumnDefinitions.Add(new ColumnDefinition());

            Loading_scroll();
        }
    }
}