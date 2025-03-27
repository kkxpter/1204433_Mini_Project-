using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Diagnostics;

namespace MauiDemomic.ViewModel
{
    public partial class RegistrationInfoViewModel : ObservableObject
    {
        [ObservableProperty]
        private string courseName;

        [ObservableProperty]
        private string semester;

        // คำสั่งสำหรับปุ่มถอนวิชา
        public IRelayCommand DropCourseCommand { get; }

        public RegistrationInfoViewModel(string courseName, string semester)
        {
            CourseName = courseName;
            Semester = semester;

            // กำหนดฟังก์ชันให้ปุ่มถอนวิชา
            DropCourseCommand = new RelayCommand(DropCourse);
        }

        private void DropCourse()
        {
            Debug.WriteLine($"ถอนวิชา {CourseName} เทอม {Semester}");
            CourseName = "ไม่ได้ลงทะเบียนเรียน"; // ล้างข้อมูลหลังถอน
            Semester = "-";
        }
    }
}
