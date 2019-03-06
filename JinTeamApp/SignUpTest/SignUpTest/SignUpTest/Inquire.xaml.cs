using Plugin.Media;
using Plugin.Media.Abstractions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SignUpTest
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Inquire : ContentPage
    {
        string errCode;
        string inquire_Id = Convert.ToString(Application.Current.Properties["cus_no"]);
        string inquireType = "";
        public Inquire()
        {
            InitializeComponent();
            inquireTypePicker.Items.Add("피드백");
            inquireTypePicker.Items.Add("사용문의");
            inquireTypePicker.Items.Add("회원문의");
            inquireTypePicker.Items.Add("시스템");
            inquireTypePicker.Items.Add("결제문의");
            inquireTypePicker.Items.Add("기타");
        }

        private void pickInquire(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;

            if (selectedIndex != -1)
            {
                inquireType = picker.Items[selectedIndex];
            }
        }


        private void Cancel_Clicked(object sender, EventArgs e)
        {
            OnBackButtonPressed();
        }

        private async void InquireSend_Clicked(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(inquireType))
            {
                DependencyService.Get<IMessage>().Longtime("문의분야를 선택해주세요");
            }
            else if (String.IsNullOrEmpty(inquireTitle.Text))
            {
                DependencyService.Get<IMessage>().Longtime("제목을 입력해주세요");
            }
            else if (String.IsNullOrEmpty(inquireBody.Text))
            {
                DependencyService.Get<IMessage>().Longtime("문의내용을 입력해주세요");
            }
            else
            {
                var s = DisplayAlert("문의 전송", "문의답변은 2~3일 정도 소요되며, 고객님 이메일로 발송됩니다. \r\n 문의 하시겠습니까?", "전송", "취소");
                if (await s)
                {
                    string url = "http://jinweb2.azurewebsites.net/FrmInquireSend.aspx" + "?inquire_type=" + inquireType + "&inquire_id=" + inquire_Id + "&inquire_title=" + inquireTitle.Text + "&inquire_body=" + inquireBody.Text;

                    WebRequest myRequest = WebRequest.Create(url);
                    WebResponse myResponse = myRequest.GetResponse();
                    StreamReader sr = new StreamReader(myResponse.GetResponseStream());

                    errCode = sr.ReadLine();

                    if (errCode == "1100")
                    {
                        DependencyService.Get<IMessage>().Longtime("문의완료");
                        OnBackButtonPressed();
                    }
                    else if (errCode == "1101")
                    {
                        // 미리 예외처리를 해서 일어날 수 없는 오류
                        DependencyService.Get<IMessage>().Longtime("값이 제대로 입력되지 않았습니다");
                    }
                    else
                    {
                        // 예외가 있을지 생각해보자......
                    }
                }
            }
        } 
    }
}