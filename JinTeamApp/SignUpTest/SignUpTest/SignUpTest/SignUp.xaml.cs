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
    public partial class SignUp : ContentPage
    {
        string age;
        string errCode;
        public SignUp()
        {
            InitializeComponent();

            for (int i = 10; i <= 80; i++)
            {
                cus_age.Items.Add(i.ToString());
            }
        }

        private void SignUp_Clicked(object sender, EventArgs e)
        {
            string gender;
            if (cus_gender.IsToggled)
            {
                gender = "1";
            }
            else
            {
                gender = "0";
            }

            string url = "http://jinweb.azurewebsites.net/FrmInsertCust.aspx" + "?cus_ID=" + cus_ID.Text + "&cus_pwd=" + cus_pwd.Text + "&cus_phone=" + cus_phone.Text + "&cus_addr=" + cus_addr.Text + "&cus_name=" + cus_name.Text + "&cus_Nickname=" + cus_Nickname.Text + "&cus_gender=" + gender + "&cus_age=" + age;

            //var req = (HttpWebRequest)WebRequest.Create(url);

            WebRequest myRequest = WebRequest.Create(url);
            WebResponse myResponse = myRequest.GetResponse();
            StreamReader sr = new StreamReader(myResponse.GetResponseStream());
           
            errCode = sr.ReadLine();
            
            if (errCode == "201")
            {
                DisplayAlert("핸드폰번호 중복", "이미 가입하신 번호입니다.", "OK");
            }

            if (errCode == "100")
            {
                DisplayAlert("Success", "회원가입 성공", "OK");
            }

            if (errCode == "202")
            {
                DisplayAlert("ID중복", "이미 가입하신 ID입니다", "OK");
            }

            sr.Close();
            //var r = myResponse.GetResponseStream();
            //r.read
        }

        private void pickAge(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;

            if (selectedIndex != -1)
            {
                age = picker.Items[selectedIndex];
            }
        }

        private void ID_Confirm_Clicked(object sender, EventArgs e)
        {

        }
    }
}