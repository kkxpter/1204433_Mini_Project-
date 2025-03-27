using MauiDemomic.ViewModel;

namespace MauiDemomic.Pages;

public partial class ShowObjectPage : ContentPage
{
	public ShowObjectPage()
	{
		InitializeComponent();
		BindingContext = new ShowObjectViewModel();

		
	}
}