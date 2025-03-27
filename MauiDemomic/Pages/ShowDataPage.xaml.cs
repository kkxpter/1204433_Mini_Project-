
using MauiDemomic.ViewModel;

namespace MauiDemomic.Pages;

public partial class ShowDataPage : ContentPage
{
	public ShowDataPage()
	{
		InitializeComponent();
		BindingContext = new ShowDataViewModel();
	}
}