using System;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiDemomic.Pages;
using Microsoft.Maui.Controls;

namespace MauiDemomic.ViewModel
{
    public partial class ViewMainViewModel : ObservableObject
    {
        [RelayCommand]
        async Task GoToProfile()
        {
            await Shell.Current.GoToAsync(nameof(ViewProfile));
        }

        [RelayCommand]
        async Task GoToRegistrationPage()
        {
            await Shell.Current.GoToAsync(nameof(RegistrationPage));
        }

        [RelayCommand]
        public async Task GoToRegistrationInfoPage()
{
    // สมมติว่าเรามีข้อมูลจากการลงทะเบียนแล้ว
    string selectedCourseCode = "CS101 - Introduction to Computer Science";
    string selectedSemester = "1";

    // ไปยังหน้า RegistrationInfoPage พร้อมข้อมูล
    string route = $"RegistrationInfoPage?courseName={selectedCourseCode}&semester={selectedSemester}";
    await Shell.Current.GoToAsync(route);
        }

    }
}
