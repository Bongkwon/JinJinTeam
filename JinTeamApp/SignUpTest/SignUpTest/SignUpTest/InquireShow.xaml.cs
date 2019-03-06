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
    public partial class InquireShow : ContentPage
    {
        string json;
        Inquires[] v;
        int inquire_Id = Convert.ToInt32(Application.Current.Properties["cus_no"]);

        public InquireShow()
        {
            InitializeComponent();

            string url = "http://jinweb2.azurewebsites.net/FrmInquireRecieve.aspx" + "?inquire_Id=" + inquire_Id;

            WebRequest myRequest = WebRequest.Create(url);
            WebResponse myResponse = myRequest.GetResponse();
            StreamReader sr = new StreamReader(myResponse.GetResponseStream());

            json = sr.ReadToEnd();

            if (json == "1201")
            {
                txtTitle.Text = "잘못된 경로입니다";    // ID없음 에러 (나올수 없음)
            }
            else if (json == "1202")
            {
                txtTitle.Text = "문의내역이 없습니다";
            }
            else
            {
                v = JsonConvert.DeserializeObject<Inquires[]>(json);
                BindingContext = v;
            }
        }

        //private void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        //{
        //    if (e.SelectedItem == null) return;

        //    if (String.IsNullOrEmpty((e.SelectedItem as Inquires).Re_date))
        //    {
        //        DependencyService.Get<IMessage>().Longtime("답변을 대기중인 문의입니다");
        //    }
        //    else
        //    {
        //        DisplayAlert("문의답변일 ["+(e.SelectedItem as Inquires).Re_date+" ]","답변내용  "+ (e.SelectedItem as Inquires).Re_body, "확인");
        //    }
        //}

        private void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null) return;

            if (String.IsNullOrEmpty((e.Item as Inquires).Re_date))
            {
                DependencyService.Get<IMessage>().Longtime("답변을 대기중인 문의입니다");
            }
            else
            {
                DisplayAlert("문의답변일 [" + (e.Item as Inquires).Re_date + " ]", "답변내용  " + (e.Item as Inquires).Re_body, "확인");
            }
        }
    }
}