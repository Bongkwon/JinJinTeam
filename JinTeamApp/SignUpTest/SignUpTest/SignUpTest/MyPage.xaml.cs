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
		public MyPage ()
		{
			InitializeComponent ();
		}
        private void Set_Clicked(object sender, EventArgs e)
        {
            // 환경설정 구현
        }

        private void OrderHistory_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new OrderHistory());

        }

        private void ProfileSet_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Edit_Profile());
        }

        private void ReviewHistory_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new ReviewHistory());
        }

        private void QuestionHistory_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Inquire());
        }
    }
}