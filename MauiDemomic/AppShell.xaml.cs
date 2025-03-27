using MauiDemomic.Pages;

namespace MauiDemomic;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(ShowDataPage), typeof(ShowDataPage));
		Routing.RegisterRoute(nameof(ShowObjectPage), typeof(ShowObjectPage));
		Routing.RegisterRoute("forgetpassword", typeof(ForgetPasswordPage));
		Routing.RegisterRoute("viewpage", typeof(ViewPage));
		Routing.RegisterRoute("register", typeof(RegisterPage));
		Routing.RegisterRoute(nameof(ViewMain), typeof(ViewMain));
		
	}
	
}
