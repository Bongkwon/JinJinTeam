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
    public partial class InsertReview : ContentPage
    {
        StreamReader sr;
        string json = string.Empty;
        int cus_ID;
        string stock_ID = string.Empty;

        public InsertReview()
        {
            InitializeComponent();
        }
        public InsertReview(string stock_ID) : this()
        {
            this.stock_ID = stock_ID;
            this.cus_ID = MainPage.customers[0].Cus_no;
        }

        private void ReviewSend_Clicked(object sender, EventArgs e)
        {
            string url = "http://jinweb2.azurewebsites.net/FrmInsertReview.aspx?" + "cus_ID=" + cus_ID + "&stock_ID=" + stock_ID + "&re_text=" + reviewBody.Text;

            WebRequest myRequest = WebRequest.Create(url);
            WebResponse myResponse = myRequest.GetResponse();
            sr = new StreamReader(myResponse.GetResponseStream());

            json = sr.ReadToEnd();

            if (json.Equals("500"))
            {
                DependencyService.Get<IMessage>().Longtime("등록되었습니다.");

                OnBackButtonPressed();
            }
            else if (json.Equals("501"))
            {
                DependencyService.Get<IMessage>().Longtime("해당 오류가 발생하였습니다. 다시 시도해주십시오.");
            }
            else
            {
                DependencyService.Get<IMessage>().Longtime("errCode:" + json + "발생");
            }
        }

        private void Cancel_Clicked(object sender, EventArgs e)
        {
            OnBackButtonPressed();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            Stream stream = await DependencyService.Get<IPicturePicker>().GetImageStreamAsync();

            if (stream != null)
            {
                reviewImage.Source = ImageSource.FromStream(() => stream);
                reviewImage.IsVisible = true;
            }
        }
    }
}