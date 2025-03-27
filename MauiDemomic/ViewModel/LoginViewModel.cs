using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiDemomic.Pages;

namespace MauiDemomic.ViewModel;

public partial class LoginViewModel : ObservableObject
{
    [ObservableProperty]
    string username = "";

    [ObservableProperty]
    string password = "";

    [RelayCommand]
    async Task Login()
    {
        System.Diagnostics.Debug.Print("Username: " + Username);
        System.Diagnostics.Debug.Print("Password: " + Password);

        await GoToPage(nameof(ViewMain));
    }

    [RelayCommand]
    async Task GoToPage(string page)
    {
        await Shell.Current.GoToAsync(page);
    }

}
