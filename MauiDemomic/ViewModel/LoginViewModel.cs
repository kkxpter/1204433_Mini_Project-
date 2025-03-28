using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Text.RegularExpressions;
using MauiDemomic.Pages;

namespace MauiDemomic.ViewModel;

public partial class LoginViewModel : ObservableObject
{
    [ObservableProperty]
    string email = "";

    [ObservableProperty]
    string password = "";

    [RelayCommand]
    async Task Login()
    {
        // ตรวจสอบรูปแบบอีเมล
        if (!IsValidEmail(Email))
        {
            // ถ้าอีเมลไม่ถูกต้อง ให้แสดงข้อความแจ้งเตือน
            await Shell.Current.DisplayAlert("ผิดพลาด", "กรุณากรอกอีเมลที่ถูกต้อง", "ตกลง");
            return;
        }

        // แสดงข้อมูลใน debug console
        System.Diagnostics.Debug.Print("Email: " + Email);
        System.Diagnostics.Debug.Print("Password: " + Password);

        // ไปที่หน้าหลัก
        await GoToPage(nameof(ViewMain));
    }

    // ฟังก์ชันตรวจสอบอีเมล
    private bool IsValidEmail(string email)
    {
        var emailRegex = @"^[^@\s]+@[^@\s]+\.[^@\s]+$"; // รูปแบบอีเมล
        return Regex.IsMatch(email, emailRegex);
    }

    [RelayCommand]
    async Task GoToPage(string page)
    {
        await Shell.Current.GoToAsync(page);
    }
}