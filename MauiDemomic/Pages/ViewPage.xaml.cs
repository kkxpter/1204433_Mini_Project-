namespace MauiDemomic.Pages;

public partial class ViewPage : ContentPage
{
	public ViewPage()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await Navigation.PopAsync();
        // await DisplayAlert("Alert", "Message", "Close");
    }

  
}