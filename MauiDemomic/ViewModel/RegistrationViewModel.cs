using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiDemomic.Pages;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MauiDemomic.ViewModel
{
    public partial class RegistrationViewModel : ObservableObject
    {
        // รายการรหัสวิชาทั้งหมด
        public List<string> AllCourseCodes { get; } = new List<string>
        {
            // รายวิชาสาขาวิทยาการคอมพิวเตอร์
            "CS101 - Introduction to Computer Science",
            "CS102 - Data Structures",
            "CS103 - Algorithms",
            "CS104 - Web Development",
            "CS105 - Database Systems",
            "CS106 - Operating Systems",
            "CS107 - Computer Networks",
            "CS108 - Software Engineering",
            "CS109 - Artificial Intelligence",
            "CS110 - Machine Learning",
            // รายวิชาสาขาวิทยาศาสตร์ข้อมูล
            "DS101 - Introduction to Data Science",
            "DS102 - Data Analysis with Python",
            "DS103 - Big Data Technologies",
            "DS104 - Data Visualization",
            "DS105 - Statistical Methods",
            // รายวิชาสาขาวิศวกรรมไฟฟ้า
            "EE101 - Electrical Circuits",
            "EE102 - Digital Electronics",
            "EE103 - Microprocessors",
            "EE104 - Electrical Machines",
            "EE105 - Power Systems",
            // รายวิชาสาขาบริหารธุรกิจ
            "BA101 - Introduction to Business",
            "BA102 - Marketing Principles",
            "BA103 - Financial Accounting",
            "BA104 - Organizational Behavior",
            "BA105 - Strategic Management",
            // รายวิชาสาขาวิศวกรรมเครื่องกล
            "ME101 - Mechanics of Materials",
            "ME102 - Thermodynamics",
            "ME103 - Fluid Mechanics",
            "ME104 - Heat Transfer",
            "ME105 - Manufacturing Processes"
        };

        // รายการเทอมที่สามารถเลือกได้
        public List<string> Semesters { get; } = new List<string>
        {
            "1",
            "2",
            "3"
        };

        // ตัวแปรเก็บรหัสวิชาที่เลือก
        [ObservableProperty]
        private string selectedCourseCode;

        // ตัวแปรเก็บเทอมที่เลือก
        [ObservableProperty]
        private string selectedSemester;

        // ตัวแปรเก็บข้อความที่จะแสดงเมื่อมีการลงทะเบียน
        [ObservableProperty]
        private string registrationDetails;

        // ตัวแปรสำหรับคำค้นหา
        [ObservableProperty]
        private string searchQuery;

        // ตัวแปรสำหรับ FilteredCourseCodes
        private List<string> _filteredCourseCodes;

        // รายการรหัสวิชาที่จะแสดงหลังจากค้นหา
        public List<string> FilteredCourseCodes
        {
            get => _filteredCourseCodes;
            set
            {
                if (_filteredCourseCodes != value)
                {
                    _filteredCourseCodes = value;
                    OnPropertyChanged();
                }
            }
        }

        public RegistrationViewModel()
        {
            // เริ่มต้นด้วยรายการทั้งหมด
            FilteredCourseCodes = AllCourseCodes;
        }

        // เมื่อมีการเปลี่ยนแปลงคำค้นหา
        partial void OnSearchQueryChanged(string value)
        {
            // กรองรายวิชาตามคำค้นหาจาก SearchQuery
            FilteredCourseCodes = AllCourseCodes
                .Where(course => course.ToLower().Contains(value.ToLower()))
                .ToList();
        }

        // คำสั่งการลงทะเบียน
        [RelayCommand]
        public void Register()
        {
            if (string.IsNullOrEmpty(SelectedCourseCode) || string.IsNullOrEmpty(SelectedSemester))
            {
                RegistrationDetails = "กรุณาเลือกวิชาและเทอมที่ต้องการลงทะเบียน";
            }
            else
            {
                // แสดงข้อมูลการลงทะเบียน
                RegistrationDetails = $"ลงทะเบียนเสร็จสิ้น!\nคุณได้ลงทะเบียนในวิชา {SelectedCourseCode} สำหรับ {SelectedSemester}";
            }
        }

        // คำสั่งไปยังหน้าข้อมูลการลงทะเบียน
        [RelayCommand]
        public async Task GoToRegistrationInfoPage()
        {
            // ไปยังหน้า RegistrationInfoPage พร้อมข้อมูล
            await Shell.Current.GoToAsync($"{nameof(RegistrationInfoPage)}?courseName={SelectedCourseCode}&semester={SelectedSemester}");
        }
    }
}
