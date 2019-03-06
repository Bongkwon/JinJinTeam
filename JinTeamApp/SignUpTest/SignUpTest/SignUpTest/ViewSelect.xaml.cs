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
	public partial class ViewSelect : ContentPage
	{
		public ViewSelect ()
		{
			InitializeComponent ();
		}

        /// <summary>
        /// 진팀 뷰 버튼 이벤트 (스와이프 모드의 쇼핑몰 창이 켜짐)
        /// </summary>
        /// <param name="sender">진팀 뷰 버튼</param>
        /// <param name="e"></param>
        private void JinTeamView_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new SwipeTest() { BackgroundImage = "pastel.jpg" });
        }
        /// <summary>
        /// 클래식 뷰 버튼 이벤트 (클래식 모드의 쇼핑몰 창이 켜짐)
        /// </summary>
        /// <param name="sender">클래식 뷰 버튼</param>
        /// <param name="e"></param>
        private void ClassicView_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new CardViewGrid());
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