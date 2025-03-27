using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiDemomic.Pages;
using Microsoft.Maui.Controls;
using System.Threading.Tasks;

namespace MauiDemomic.ViewModel
{
    public partial class RegistrationViewModel : ObservableObject
    {
        // รายการรหัสวิชาทั้งหมด
        public List<string> AllCourseCodes { get; } = new List<string>
        {
            "CS101 - Introduction to Computer Science",
            "CS102 - Data Structures",
            "CS103 - Algorithms",
            "CS104 - Web Development",
            "CS105 - Database Systems"
        };

        public List<string> Semesters { get; } = new List<string>
        {
            "Term 1",
            "Term 2",
            "Term 3"
        };

        [ObservableProperty]
        string selectedCourseCode;

        [ObservableProperty]
        string selectedSemester;

        [ObservableProperty]
        string registrationDetails;

        [ObservableProperty]
        string searchQuery;

        public List<string> FilteredCourseCodes { get; private set; }

        public RegistrationViewModel()
        {
            FilteredCourseCodes = AllCourseCodes;
        }

        partial void OnSearchQueryChanged(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                FilteredCourseCodes = AllCourseCodes;
            }
            else
            {
                FilteredCourseCodes = AllCourseCodes.Where(course => course.ToLower().Contains(value.ToLower())).ToList();
            }
        }

        // คำสั่งลงทะเบียน
        [RelayCommand]
        public void Register()
        {
            if (string.IsNullOrEmpty(SelectedCourseCode) || string.IsNullOrEmpty(SelectedSemester))
            {
                RegistrationDetails = "กรุณาเลือกวิชาและเทอมที่ต้องการลงทะเบียน";
            }
            else
            {
                RegistrationDetails = $"ลงทะเบียนเสร็จสิ้น!\nคุณได้ลงทะเบียนในวิชา {SelectedCourseCode} สำหรับ {SelectedSemester}";
            }
        }

        // คำสั่งสำหรับไปหน้า RegistrationInfoPage
        [RelayCommand]
        public async Task GoToRegistrationInfoPage()
        {
            var courseName = SelectedCourseCode;
            var semester = SelectedSemester;

            // ไปยังหน้า RegistrationInfoPage และส่งข้อมูล courseName, semester
            await Shell.Current.GoToAsync($"{nameof(RegistrationPage)}?courseName={courseName}&semester={semester}");
        }
    }
}
