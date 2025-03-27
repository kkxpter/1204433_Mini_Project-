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
            System.Diagnostics.Debug.Print("profile");
            await Shell.Current.GoToAsync(nameof(ViewProfile));
        }

        [RelayCommand]
        async Task GoToRegistrationInfo()
        {
            //await Shell.Current.GoToAsync(nameof(RegistrationInfoPage));
        }

        [RelayCommand]
        async Task GoToRegistration()
        {
            //await Shell.Current.GoToAsync(nameof(RegistrationPage));
        }
    }
}
