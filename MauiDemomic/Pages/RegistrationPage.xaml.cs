using MauiDemomic.ViewModel;
using Microsoft.Maui.Controls;

namespace MauiDemomic.Pages
{
    public partial class RegistrationPage : ContentPage
    {
        public RegistrationPage()
        {
            InitializeComponent();

            // ตั้งค่า BindingContext
            BindingContext = new RegistrationViewModel();
        }

        // เมธอดสำหรับจัดการการเปลี่ยนแปลงข้อความใน Entry
        private void OnSearchTextChanged(object sender, TextChangedEventArgs e)
        {
            // เชื่อมโยงกับคำค้นหาใน ViewModel
            if (BindingContext is RegistrationViewModel viewModel)
            {
                viewModel.SearchQuery = e.NewTextValue;  // อัพเดท SearchQuery ใน ViewModel
            }
        }

        // เมธอดเมื่อคลิกปุ่ม "ดูข้อมูลลงทะเบียน"
        private async void OnViewRegistrationInfoClicked(object sender, EventArgs e)
        {
            if (BindingContext is RegistrationViewModel viewModel)
            {
                // ใช้คำสั่ง GoToRegistrationInfoPage ใน ViewModel
                await viewModel.GoToRegistrationInfoPage();
            }
        }
    }
}
