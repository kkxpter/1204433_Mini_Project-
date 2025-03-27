using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiDemomic.ViewModel
{
    public partial class RegistrationInfoViewModel : ObservableObject
    {
        [ObservableProperty]
        private string courseName;

        [ObservableProperty]
        private string semester;

        public RegistrationInfoViewModel(string courseName, string semester)
        {
            CourseName = courseName;
            Semester = semester;
        }
    }
}
