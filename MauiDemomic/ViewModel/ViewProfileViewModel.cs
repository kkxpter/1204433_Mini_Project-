using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiDemomic.ViewModel;

public partial class ViewProfileViewModel : ObservableObject
{
    [ObservableProperty]
    string fullName = "John Doe";

    [ObservableProperty]
    string email = "johndoe@example.com";

    // เพิ่ม PhoneNumber
    [ObservableProperty]
    string phoneNumber = "0829265047";

    [RelayCommand]
    async Task EditProfile()
    {
        // ตรวจสอบว่าผู้ใช้กรอกข้อมูลทั้งหมดแล้วหรือยัง
        if (string.IsNullOrEmpty(FullName) || string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(PhoneNumber))
        {
            await Shell.Current.DisplayAlert("ผิดพลาด", "กรุณากรอกข้อมูลให้ครบถ้วน", "ตกลง");
            return;
        }

        // หากข้อมูลครบถ้วนให้แสดงข้อความว่าอัปเดตสำเร็จ
        await Shell.Current.DisplayAlert("สำเร็จ", "โปรไฟล์ของคุณถูกอัปเดตแล้ว", "ตกลง");
        
        // ในกรณีจริง คุณสามารถทำการบันทึกข้อมูลที่แก้ไขที่นี่ (เช่น บันทึกลงในฐานข้อมูลหรือ API)
    }
}
