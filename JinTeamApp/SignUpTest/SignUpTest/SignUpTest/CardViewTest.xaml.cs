using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CardViewTest : ContentView
	{
		public CardViewTest ()
		{
			InitializeComponent ();
		}
        public CardViewTest(string pro_name, string main_image, int pro_price) : this()
        {
            this.pro_name.Text = pro_name;
            this.pro_price.Text = pro_price.ToString();
            this.main_image.Source = main_image;
        }
    }
}