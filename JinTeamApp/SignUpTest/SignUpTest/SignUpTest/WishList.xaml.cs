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
    public partial class WishList : ContentPage
    {
        public WishList()
        {
            InitializeComponent();

            wishListView.ItemsSource = new[] { "test1", "test2", "제품테스트" };
        }
        public void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null) return;
            DisplayAlert("상품 상세정보", e.SelectedItem + "제품의 상세정보 내용...", "OK");
            ((ListView)sender).SelectedItem = null;
        }
        private void DeleteProduct_Clicked(object sender, EventArgs e)
        {
            var flag = DisplayAlert("장바구니 삭제", "해당 상품을 장바구니에서 빼시겠습니까?", "삭제", "취소");

            if (flag.IsCompleted)
            {
                // 상품 삭제
            }
        }
    }
}