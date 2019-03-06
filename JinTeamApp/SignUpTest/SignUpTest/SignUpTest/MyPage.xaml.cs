using App1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SignUpTest
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyPage : ContentPage
    {
        public MyPage()
        {
            InitializeComponent();
        }

        private void SetShipInfo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new AddressSetting());
        }

        private void OrderHistory_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new OrderHistory());

        }

        private void ProfileSet_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new InfoChange(MainPage.customers[0]));
            //    new Customer()
            //{
            //    Cus_no = Int32.Parse(Convert.ToString(Application.Current.Properties["cus_no"])),
            //    Cus_name = Convert.ToString(Application.Current.Properties["cus_name"]),
            //    Cus_Nickname = Convert.ToString(Application.Current.Properties["cus_Nickname"]),
            //    Cus_gender = bool.Parse(Convert.ToString(Application.Current.Properties["cus_gender"])),
            //    Cus_phone = Convert.ToString(Application.Current.Properties["cus_phone"]),
            //    Cus_pwd = Convert.ToString(Application.Current.Properties["cus_pwd"]),
            //    Cus_addr = Convert.ToString(Application.Current.Properties["cus_addr"])
            //}));
        }

        private void ReviewHistory_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new ListReview(MainPage.customers[0].Cus_no));
        }

        private async void QuestionHistory_Clicked(object sender, EventArgs e)
        {
            var flag = await DisplayActionSheet("선택해주세요", "취소", null, "문의하기", "문의내역조회");
            if (flag == null)
            {
                return;
            }
            else if (flag.Equals("문의하기"))
            {
                await Navigation.PushModalAsync(new Inquire());
            }
            else if (flag.Equals("문의내역조회"))
            {
                await Navigation.PushModalAsync(new InquireShow());
            }
        }

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


        private void Logout_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new MainPage();
        }

        private void Cancel_Clicked(object sender, EventArgs e)
        {
            AppCloseOption.IsVisible = false;
        }


    }
}