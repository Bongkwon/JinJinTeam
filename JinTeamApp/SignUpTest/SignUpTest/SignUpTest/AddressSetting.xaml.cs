using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Xml;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SignUpTest
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddressSetting : ContentPage
    {
        string cus_no = Convert.ToString(Application.Current.Properties["cus_no"]);
        string json;
        StreamReader sr;
        WebRequest myRequest;
        WebResponse myResponse;
        int apiPageNum = 1;
        int apiEndPageNum;
        string userAddr;
        List<Juso> lstJuso = new List<Juso>();

        public AddressSetting()
        {
            InitializeComponent();
        }

        private void AddAddess_Clicked(object sender, EventArgs e)
        {
            userAddr = txtUser_Addr.Text + txtUser_DetailAddr.Text;
            if (String.IsNullOrEmpty(txtUser_Name.Text))
            {
                DependencyService.Get<IMessage>().Longtime("받으시는분 성함을 입력해주세요");
            }
            else if (String.IsNullOrEmpty(userAddr))
            {
                DependencyService.Get<IMessage>().Longtime("배송받을 주소를 입력해주세요");
            }
            else if (String.IsNullOrEmpty(txtPostal_Code.Text))
            {
                DependencyService.Get<IMessage>().Longtime("우편번호를 입력해주세요");
            }
            else
            {
                string url = "http://jinweb2.azurewebsites.net/FrmInserUserShipInfo.aspx" + "?cus_no=" + cus_no + "&user_name=" + txtUser_Name.Text + "&user_addr=" + userAddr + "&postal_code=" + txtPostal_Code.Text + "&ship_require=" + txtShip_Require.Text;

                myRequest = WebRequest.Create(url);
                myResponse = myRequest.GetResponse();
                sr = new StreamReader(myResponse.GetResponseStream());

                json = sr.ReadToEnd();
                if (json == "2501")
                {
                    //DisplayAlert("서버오류", "잘못된 경로 입니다.", "확인");
                    DependencyService.Get<IMessage>().Longtime("잘못된 경로 입니다.");
                }
                else if (json == "2500")
                {
                    txtUser_Name.Text = "";
                    txtUser_Addr.Text = "";
                    txtUser_DetailAddr.Text = "";
                    txtPostal_Code.Text = "";
                    txtShip_Require.Text = "";
                    DependencyService.Get<IMessage>().Longtime("배송지 정보 저장완료");
                }
                else
                {
                    // 나올 수 없는 에러
                    DependencyService.Get<IMessage>().Longtime("서버 오류");
                }
            }
        }

        private async void AddrTapped(object sender, ItemTappedEventArgs e)
        {
            var answer = await DisplayAlert(null, "선택한 배송지정보를 삭제하시겠습니까?", "삭제", "취소");
            if (answer)
            {
                string url = "http://jinweb2.azurewebsites.net/FrmDeleteUserShipInfo.aspx" + "?user_ship_Id=" + (e.Item as UserShipInfo).User_Ship_Id;

                myRequest = WebRequest.Create(url);
                myResponse = myRequest.GetResponse();
                sr = new StreamReader(myResponse.GetResponseStream());
                json = sr.ReadToEnd();

                if (json == "2204")
                {
                    DependencyService.Get<IMessage>().Longtime("잘못된 경로 입니다");   // user_ship_Id가 없는 에러(일어날 수 없음)
                }
                else if (json == "2203")
                {
                    DependencyService.Get<IMessage>().Longtime("배송지 정보 삭제완료");
                    SavedMyAddr_Clicked(null, null);
                }
                else
                {
                    // ..?
                    DependencyService.Get<IMessage>().Longtime("서버 오류");
                }
            }
        }

        private void SavedMyAddr_Clicked(object sender, EventArgs e)
        {
            SavedAddr.ItemsSource = "";
            if (ctvMyAddr.IsVisible)
            {
                ctvMyAddr.IsVisible = false;
            }
            else
            {
                ctvMyAddr.IsVisible = true;

                string url = "http://jinweb2.azurewebsites.net/FrmSavedUserShipInfo.aspx" + "?cus_no=" + cus_no;

                myRequest = WebRequest.Create(url);
                myResponse = myRequest.GetResponse();
                sr = new StreamReader(myResponse.GetResponseStream());

                json = sr.ReadToEnd();

                if (json == "2200")
                {
                    DisplayAlert("오류", "잘못된 경로 입니다.", "확인");    // cus_no 입력이 없는에러 (일어날 수 없음)
                }
                else if (json == "2201")
                {
                    txtMyAddr.Text = "저장하신 배송지가 없습니다";
                }
                else
                {
                    var v = JsonConvert.DeserializeObject<UserShipInfo[]>(json);
                    SavedAddr.ItemsSource = v;
                }
            }
        }

        private void PostalCodeSearch_Clicked(object sender, EventArgs e)
        {
            if (ctvSearch.IsVisible)
            {
                ctvSearch.IsVisible = false;
            }
            else
            {
                ctvSearch.IsVisible = true;
            }

        }

        private void CodeSearch_Clicked(object sender, EventArgs e)
        {

            lstJuso.Clear();

            string uri = "http://www.juso.go.kr/addrlink/addrLinkApi.do?confmKey=U01TX0FVVEgyMDE5MDIxMjE2MjA1MzEwODUwMjU=&currentPage=" + apiPageNum + "&countPerPage=10 &keyword=" + txtRoad.Text;

            var req = (HttpWebRequest)WebRequest.Create(uri);
            var res = (HttpWebResponse)req.GetResponse();

            var statusCode = res.StatusCode.ToString();

            if (statusCode == "OK")
            {
                var stream = res.GetResponseStream();
                var sr = new StreamReader(stream, Encoding.UTF8);
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(sr.ReadToEnd());
                XmlNodeList lstxml = doc.DocumentElement.SelectNodes("/results/juso");
                apiEndPageNum = Int32.Parse(doc.DocumentElement.SelectSingleNode("/results/common/totalCount").InnerText) / 10 + 1;


                foreach (XmlNode item in lstxml)
                {
                    lstJuso.Add(new Juso(item.SelectSingleNode("roadAddr").InnerText, item.SelectSingleNode("jibunAddr").InnerText, item.SelectSingleNode("zipNo").InnerText));
                }
            }
            res.Close();
            searchCode.ItemsSource = null;
            searchCode.ItemsSource = lstJuso;
        }

        private async void SearchAddrTapped(object sender, ItemTappedEventArgs e)
        {
            var answer = await DisplayAlert(null, "해당주소를 선택 하시겠습니까?", "예", "아니오");
            if (answer)
            {
                txtPostal_Code.Text = (e.Item as Juso).ZipNo;
                txtUser_Addr.Text = (e.Item as Juso).RoadAddr;
                ctvSearch.IsVisible = false;
                DependencyService.Get<IMessage>().Longtime("상세주소를 입력하세요");
            }
            else
            {
                ctvSearch.IsVisible = false;
            }
        }

        private void CloseSearch_Clicked(object sender, EventArgs e)
        {
            ctvSearch.IsVisible = false;
        }

        private void Before_Clicked(object sender, EventArgs e)
        {
            if (apiPageNum <= 1)
            {
                DependencyService.Get<IMessage>().Longtime("첫 페이지 입니다");
            }
            else
            {
                apiPageNum--;
                CodeSearch_Clicked(null, null);
            }
        }

        private void Next_Clicked(object sender, EventArgs e)
        {
            if (apiPageNum >= apiEndPageNum)
            {
                DependencyService.Get<IMessage>().Longtime("끝 페이지 입니다");
            }
            else
            {
                apiPageNum++;
                CodeSearch_Clicked(null, null);
            }
        }
    }
}