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
	public partial class ClassicViewPage : ContentPage
	{
		public ClassicViewPage ()
		{
			InitializeComponent ();


        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            // 클래식뷰에서 클릭했을 때 화면 ( 웹에서~~~~
            DisplayAlert("상세정보창", "제품상세설명~~~", "OK");

        }
    }
}