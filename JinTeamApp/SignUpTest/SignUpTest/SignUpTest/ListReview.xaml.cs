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
	public partial class ListReview : ContentPage
	{
        StreamReader sr;
        List<Review> reviews;
        string json = string.Empty;

		public ListReview ()
		{
			InitializeComponent ();
		}
        public ListReview(string stock_ID, string pro_name, string pro_image):this()
        {
            this.pro_image.Source = pro_image;
            this.pro_name.Text = pro_name;

            string url = "http://jinweb2.azurewebsites.net/FrmReviewList.aspx" + "?stock_ID=" + stock_ID;
            try
            {
                BindingContext = View_Review(url);
            }
            catch (Exception)
            {
                if (json.Equals("701"))
                {
                    DependencyService.Get<IMessage>().Longtime("서버 오류");
                }else if (json.Equals("702"))
                {
                    this.txt.Text = "리뷰 내역이 없습니다.";
                }
            }
        }
        public ListReview(int cus_no) :this()
        {
            //this.pro_image.Source = pro_image;
            //this.pro_name.Text = pro_name;

            string url = "http://jinweb2.azurewebsites.net/FrmReviewList.aspx" + "?cus_no=" + cus_no;
            try
            {
                BindingContext = View_Review(url);
            }
            catch (Exception)
            {
                if (json.Equals("701"))
                {
                    DependencyService.Get<IMessage>().Longtime("서버 오류");
                }
                else if (json.Equals("702"))
                {
                    this.txt.Text = "리뷰 내역이 없습니다.";
                }
            }
        }

        private List<Review> View_Review(string url)
        {
            WebRequest myRequest = WebRequest.Create(url);
            WebResponse myResponse = myRequest.GetResponse();
            sr = new StreamReader(myResponse.GetResponseStream());

            json = sr.ReadToEnd();

            reviews = JsonConvert.DeserializeObject<Review[]>(json).ToList();

            foreach (var item in reviews)
            {
                if (!string.IsNullOrEmpty(item.Re_command))
                {
                    item.Recommand = "답글 1";
                }
                else
                {
                    item.Recommand = "답글 0";
                }
                if (item.Re_like == 1)
                {
                    item.Txt_like = "좋아요";
                }
                else
                {
                    item.Txt_like = "싫어요";
                }
            }
            return reviews;
        }
        private void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            DisplayAlert("리뷰 상세 정보", "리뷰 : " + (e.SelectedItem as Review).Re_txt + "\r\n" + "답글 : " + (e.SelectedItem as Review).Re_command + "\r\n" + "답글 날짜 : "
                + (e.SelectedItem as Review).Re_comment_date, "확인");
        }
    }
}