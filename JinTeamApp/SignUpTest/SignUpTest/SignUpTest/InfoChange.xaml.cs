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
    public partial class InfoChange : ContentPage
    {
        bool pw_chk = false;
        int gender;
        Customer customer;

        public InfoChange()
        {
            InitializeComponent();
        }
        public InfoChange(Customer customer) : this()
        {
            label_chk.IsVisible = false;

            this.customer = customer;
            if (customer.Cus_gender == true)
            {
                sw_gender.IsToggled = true;
                gender = 1;
            }
            else
            {
                sw_gender.IsToggled = false;
                gender = 0;
            }
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Addr.Text) && string.IsNullOrEmpty(txt_Alias.Text) && 
                string.IsNullOrEmpty(txt_Pw.Text) && string.IsNullOrEmpty(txt_ChkPw.Text) &&
                string.IsNullOrEmpty(txt_Phone.Text) && string.IsNullOrEmpty(txt_Name.Text)){
                DependencyService.Get<IMessage>().Longtime("취소되었습니다.");
                OnBackButtonPressed();
                return;
            }

            if (!string.IsNullOrEmpty(txt_Pw.Text))
            {
                if (pw_chk)
                {
                    if (await DisplayAlert("Q", "정말로 수정하시겠습니까?", "확인", "취소"))
                    {
                        SendUrl();  // 회원정보변경 메서드
                        return;
                    }
                    else
                    {
                        DependencyService.Get<IMessage>().Longtime("취소되었습니다.");
                    }
                }
                else
                {
                    await DisplayAlert("경고", "비밀번호 불일치", "확인", "취소");
                }
            }
            else
            {
                if (await DisplayAlert("Q", "정말로 수정하시겠습니까?", "확인", "취소"))
                {
                    SendUrl();  // 회원정보변경 메서드
                    return;
                }
            }
        }

        private void SendUrl()
        {
            string url = "http://jinweb2.azurewebsites.net/ChangeCustInfo.aspx"; // 파라메타 보내기

            if (pw_chk && !string.IsNullOrEmpty(txt_Pw.Text))
            {
                customer.Cus_pwd = txt_Pw.Text;
            }

            TextCheck();

            string parameta = "?cus_no=" + customer.Cus_no + "&cus_pwd=" + customer.Cus_pwd + "&cus_phone=" + customer.Cus_phone +
                "&cus_addr=" + customer.Cus_addr + "&cus_name=" + customer.Cus_name + "&cus_Nickname=" + customer.Cus_Nickname + "&cus_gender=" +gender;

            url += parameta;
            WebRequest myRequest = WebRequest.Create(url);
            WebResponse myResponse = myRequest.GetResponse();
            StreamReader sr = new StreamReader(myResponse.GetResponseStream());

            var json = sr.ReadToEnd();
            if (json.Equals("100"))
            {
                DependencyService.Get<IMessage>().Longtime("수정 되었습니다.");
                OnBackButtonPressed();
            }
            else if (json.Equals("1000"))   
            {
                DependencyService.Get<IMessage>().Longtime("실패하었습니다.");
            }
            else if (json.Equals("999"))
            {
                DependencyService.Get<IMessage>().Longtime("정보 입력값이 잘못되었습니다.");
            }
            else
            {
                DependencyService.Get<IMessage>().Longtime("서버 오류");
                OnBackButtonPressed();
            }
        }

        private void TextCheck()
        {
            if (sw_gender.IsToggled)
            {
                gender = 1;
            }
            else
            {
                gender = 0;
            }
            if (!string.IsNullOrEmpty(txt_Name.Text))
            {
                customer.Cus_name = txt_Name.Text;
            }
            if (!string.IsNullOrEmpty(txt_Phone.Text))
            {
                customer.Cus_phone = txt_Phone.Text;
            }
            if (!string.IsNullOrEmpty(txt_Addr.Text))
            {
                customer.Cus_addr = txt_Addr.Text;
            }
            if (!string.IsNullOrEmpty(txt_Alias.Text))
            {
                customer.Cus_Nickname = txt_Alias.Text;
            }
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            DependencyService.Get<IMessage>().Longtime("취소되었습니다.");
            OnBackButtonPressed();
        }

        private void Txt_ChkPw_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ChkPw.Text))
            {
                label_chk.IsVisible = false;
            }
            else
            {
                label_chk.IsVisible = true;
            }

            if (txt_Pw.Text.Equals(txt_ChkPw.Text))
            {
                label_chk.Text = "일치합니다.";
                pw_chk = true;
            }
            else
            {
                label_chk.Text = "일치하지않습니다.";
                pw_chk = false;
            }

            OkBtnEnabled();
        }

        private void Sw_gender_Toggled(object sender, ToggledEventArgs e)
        {
            if (e.Value)
            {
                gender = 1;
            }
            else
            {
                gender = 0;
            }

            OkBtnEnabled();
        }

        private void OkBtnEnabled()
        {
            if (string.IsNullOrEmpty(txt_Addr.Text) && string.IsNullOrEmpty(txt_Alias.Text) &&
                string.IsNullOrEmpty(txt_Phone.Text) && string.IsNullOrEmpty(txt_Name.Text) &&
                sw_gender.IsToggled == customer.Cus_gender && !pw_chk)
            {
                btn_ok.IsEnabled = false;
            }
            else
            {
                btn_ok.IsEnabled = true;
            }
        }

        private void Txt_Pw_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_Pw.Text))
            {
                txt_ChkPw.IsEnabled = true;
            }
            else
            {
                txt_ChkPw.IsEnabled = false;
            }

            OkBtnEnabled();
        }
    }
}