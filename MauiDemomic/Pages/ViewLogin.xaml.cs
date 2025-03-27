using MauiDemomic.ViewModel;

namespace MauiDemomic.Pages;

public partial class ViewLogin : ContentPage
{
	public ViewLogin()
	{
		InitializeComponent();
		BindingContext = new LoginViewModel();
	}

	private async void Button_Clicked(object sender, EventArgs e)
	{
		// System.Diagnostics.Debug.WriteLine(uname.Text);
		// System.Diagnostics.Debug.WriteLine(pwd.Text);
		// if (uname.Text == "admin" && pwd.Text == "1234")
		// {
		// 	// await Navigation.PushAsync(new ViewPage());
		// 	await Shell.Current.GoToAsync("viewpage");
		// }
		// else
		// {
		// 	await DisplayAlert("Error", "Username or Password incorrect", "try again");
		// }
	}
	private async void ForgetPasswordTapped(object sender, EventArgs e)
	{
	// 	var loginData = new LoginData
	// 	{
	// 		Uname = uname.Text,
	// 		Pwd = pwd.Text
	// 	};
	// 	var queryParams = new Dictionary<string, object>(){
	// 	{ "data", loginData}
	// };

		// await Shell.Current.GoToAsync("forgetpassword");
		// await Shell.Current.GoToAsync($"forgetpassword?uname={uname.Text}&pwd={pwd.Text}");

		// await Shell.Current.GoToAsync("forgetpassword", queryParams);
	}
	public class LoginData
	{
		public string Uname { get; set; } = "";
		public string Pwd { get; set; } = "";
	}	
}