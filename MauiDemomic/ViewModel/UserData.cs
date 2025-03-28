namespace MauiDemomic.Models
{
    public class UserData
    {
        public string Email { get; set; } = "";
        public string Password { get; set; } = "";
        public string Name { get; set; } = "";
        public string Phone { get; set; } = ""; // เพิ่มเบอร์โทร
        public List<Course> RegisteredCourses { get; set; } = new();
    }

    public class Course
    {
        public string CourseName { get; set; } = "";
        public string Semester { get; set; } = "";
    }

    public class UserList
    {
        public List<UserData> Users { get; set; } = new();
    }
}
