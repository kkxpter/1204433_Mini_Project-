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

    [RelayCommand]
    async Task EditProfile()
    {
        await Shell.Current.DisplayAlert("แก้ไขโปรไฟล์", "ฟีเจอร์นี้ยังไม่พร้อมใช้งาน", "ตกลง");
    }
}
