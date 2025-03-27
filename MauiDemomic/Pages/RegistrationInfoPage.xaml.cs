using MauiDemomic.ViewModel;
using Microsoft.Maui.Controls;

namespace MauiDemomic.Pages
{
    [QueryProperty(nameof(CourseName), "courseName")]
    [QueryProperty(nameof(Semester), "semester")]
    public partial class RegistrationInfoPage : ContentPage
    {
        public string CourseName { get; set; }
        public string Semester { get; set; }

        public RegistrationInfoPage()
        {
            InitializeComponent();
        }

        // เมื่อหน้า RegistrationInfoPage ปรากฏ จะเช็คค่าจาก Query Parameters หรือกำหนดค่าเริ่มต้น
        protected override void OnAppearing()
        {
            base.OnAppearing();

            // กรณีที่ไม่มีค่า CourseName หรือ Semester จาก Query Parameter
            if (string.IsNullOrEmpty(CourseName))
            {
                CourseName = "CS101 - Introduction to Computer Science";  // ชื่อวิชาตัวอย่าง
            }

            if (string.IsNullOrEmpty(Semester))
            {
                Semester = "1";  // เทอมตัวอย่าง
            }

            // ตั้งค่า BindingContext ให้เชื่อมโยงกับ ViewModel
            var viewModel = new RegistrationInfoViewModel(CourseName, Semester);
            BindingContext = viewModel;
        }
    }
}
