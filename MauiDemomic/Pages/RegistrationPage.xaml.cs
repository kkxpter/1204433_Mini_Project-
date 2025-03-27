using MauiDemomic.ViewModel;
using Microsoft.Maui.Controls;

namespace MauiDemomic.Pages
{
    public partial class RegistrationPage : ContentPage
    {
        public RegistrationPage()
        {
            InitializeComponent();
            BindingContext = new RegistrationViewModel();
        }
    }
}
