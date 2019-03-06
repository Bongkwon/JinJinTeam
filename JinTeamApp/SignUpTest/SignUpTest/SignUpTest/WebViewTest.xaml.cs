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
	public partial class WebViewTest : ContentPage
	{
        string url = string.Empty;

		public WebViewTest ()
		{
            InitializeComponent ();
		}
        /// <summary>
        /// 웹뷰 생성자
        /// </summary>
        /// <param name="url">웹에서 켜질 Url</param>
        public WebViewTest(string url) : this()
        {
            this.url = url;

            Web.Source = this.url;
            Web.Reload();
        }
    }
}