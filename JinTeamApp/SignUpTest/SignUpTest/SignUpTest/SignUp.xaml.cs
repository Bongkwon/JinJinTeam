using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SignUpTest
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUp : ContentPage
    {
        string answerSignUp = string.Empty;
        bool emailChk = false;  // 이메일 인증
        string age;
        string errCode;
        int min = 0;
        int sec = 50;

        public SignUp()
        {
            InitializeComponent();

            for (int i = 10; i <= 80; i++)
            {
                cus_age.Items.Add(i.ToString());
            }
        }

        /// <summary>
        /// 회원가입 버튼 이벤트
        /// 모든 유효성 검사를 거친 뒤 회원가입 절차를 거침
        /// </summary>
        /// <param name="sender">가입 버튼</param>
        /// <param name="e"></param>
        private void SignUp_Clicked(object sender, EventArgs e)
        {
            if (emailChk == false)
            {
                DisplayAlert("인증 오류", "이메일 인증이 필요합니다", "확인");
            }
            else if (cus_pwd.Text != txt_ChkPw.Text)
            {
                DependencyService.Get<IMessage>().Longtime("비밀번호 불일치");
            }
            else
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

                string url = "http://jinweb2.azurewebsites.net/FrmInsertCust.aspx" + "?cus_ID=" + cus_ID.Text + "&cus_pwd=" + cus_pwd.Text + "&cus_phone=" + cus_phone.Text + "&cus_addr=" + cus_addr.Text + "&cus_name=" + cus_name.Text + "&cus_Nickname=" + cus_Nickname.Text + "&cus_gender=" + gender + "&cus_age=" + age;

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
                    OnBackButtonPressed();
                }

                if (errCode == "202")
                {
                    DisplayAlert("ID중복", "이미 가입하신 ID입니다", "OK");
                }

                sr.Close();
                //var r = myResponse.GetResponseStream();
                //r.read
            }
        }

        /// <summary>
        /// 나이 Pick 선택 이벤트
        /// 선택 한 나이를 가져옴
        /// </summary>
        /// <param name="sender">Picker</param>
        /// <param name="e"></param>
        private void pickAge(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;

            if (selectedIndex != -1)
            {
                age = picker.Items[selectedIndex];
            }
        }

        /// <summary>
        /// 올바른 이베일 형식인지 확인
        /// </summary>
        /// <param name="email">가져올 email</param>
        /// <returns></returns>
        public static bool IsValidEmail(string email)
        {
            // 올바른 이메일 형식인지 확인

            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                string DomainMapper(Match match)
                {
                    var idn = new IdnMapping();

                    var domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
            catch (ArgumentException)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                    @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        /// <summary>
        /// 이메일 인증 버튼 클릭 이벤트
        /// 이메일에 해당 인증 코드를 발송
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ID_Confirm_Clicked(object sender, EventArgs e)
        {
            lblTitle.Text = "이메일을 확인해주세요";
            lblTitle.TextColor = Color.Blue;

            // 이메일 인증 클릭이벤트
            if (emailChk == true)
            {
                DisplayAlert("", "이미 인증하신 메일입니다", "확인");
                return;
            }

            if (String.IsNullOrEmpty(cus_ID.Text))
            {
                DisplayAlert("인증 오류", "이메일 주소를 입력하세요", "확인");
            }
            else if (!IsValidEmail(cus_ID.Text))
            {
                DisplayAlert("인증 오류", "잘못된 이메일 입니다", "확인");
            }
            else
            {
                // Mail 보내기
                MailAddress fromAddr = new MailAddress("ku718@naver.com", "JINTEAM_SHOP", Encoding.UTF8);
                var toAddr = new MailAddress(cus_ID.Text, "JinTeam 회원가입 인증", Encoding.UTF8);

                // SMTP 프로토콜 객체 생성
                SmtpClient smtp = new SmtpClient("smtp.naver.com", 587);
                smtp.EnableSsl = true;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential("ku718", "rhdnrska");


                //메일 메시지 객체 생성
                answerSignUp = GetRandomCode(10);

                MailMessage msg = new MailMessage(fromAddr, toAddr);
                msg.Subject = "JinTeam 회원 인증 메일입니다.";
                msg.Body = "다음 인증코드를 입력해주세요 \a\n  =  [ " + answerSignUp + " ]";
                msg.BodyEncoding = Encoding.UTF8;
                msg.SubjectEncoding = Encoding.UTF8;

                //메일 보내기
                smtp.Send(msg);

                overlay.IsVisible = true;

                //DateTime dt = new DateTime(1000, 1, 1, 0, 0, 0);
                //DateTime dt2 = new DateTime(1, 1, 1, 0, 0, 1);
                //dt.AddMinutes(5);
                
                Device.StartTimer(TimeSpan.FromSeconds(1), () =>
                {
                    if (min == 0 && sec == 0)
                    {
                        lblTitle.Text = "다시 인증해주세요";
                        lblTitle.TextColor = Color.Red;
                        return false;
                        // 실행 멈춤
                    }
                    else if (sec == 0)
                    {
                        min = min - 1;
                        sec = 59;
                    }
                    else
                    {
                        sec = sec - 1;
                    }
                    Device.BeginInvokeOnMainThread(() =>
                    //txtTime.Text = "남은시간 : " + (dt - dt2).ToString());//"mm:ss"));
                    txtTime.Text = "남은시간 : " + min + "분 " + sec + "초");


                    return true;
                });
            }
        }

        /// <summary>
        /// 인증 코드 랜덤으로 뽑는 메서드
        /// </summary>
        /// <param name="length">인증 코드 길이</param>
        /// <returns></returns>
        public static string GetRandomCode(int length)
        {
            // 랜덤코드 생성
            Random rand = new Random();
            string input = "abcdefghijklmnopqrstuvwxyz0123456789"; var chars = Enumerable.Range(0, length).Select(x => input[rand.Next(0, input.Length)]);
            return new string(chars.ToArray());
        }

        /// <summary>
        /// 메일 인증 확인 이벤트
        /// </summary>
        /// <param name="sender">인증 버튼</param>
        /// <param name="e"></param>
        private void CheckID_Check(object sender, EventArgs e)
        {
            // 메일인증 확인

            if (answerSignUp == txtUserCode.Text)
            {
                emailChk = true;
                cus_ID.IsEnabled = false;
                overlay.IsVisible = false;
                DisplayAlert("인증확인", "이메일 확인 완료", "확인");
            }
            else
            {
                DisplayAlert("인증오류", "인증코드를 다시 확인해주세요", "확인");
            }
        }

        /// <summary>
        /// 메일 인증 취소 이벤트
        /// </summary>
        /// <param name="sender">메일 인증 취소 버튼</param>
        /// <param name="e"></param>
        private void CheckID_Cancel(object sender, EventArgs e)
        {
            // 메일인증 취소
            overlay.IsVisible = false;
        }

        /// <summary>
        /// 취소 이벤트
        /// </summary>
        /// <param name="sender">취소 버튼</param>
        /// <param name="e"></param>
        private void Cancel_Clicked(object sender, EventArgs e)
        {
            OnBackButtonPressed();
        }
    }
}