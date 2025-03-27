using MauiDemomic.ViewModel;
using Microsoft.Maui.Controls;

namespace MauiDemomic.Pages
{
    [QueryProperty(nameof(CourseName), "courseName")]
    [QueryProperty(nameof(Semester), "semester")]
    public partial class RegistrationInfoPage : ContentPage
    {
        public RegistrationInfoPage()
        {
            InitializeComponent();
        }

        public string CourseName { get; set; }
        public string Semester { get; set; }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            // ตอนนี้สามารถใช้ CourseName และ Semester ได้แล้ว
            // เช่น แสดงใน UI หรือใช้ใน ViewModel
        }
    }
}
