namespace FitnessApplicationFrontEnd.Pages;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private void OnGoogleSignInClicked(object sender, EventArgs e)
    {
        Console.WriteLine("Hello World");
    }

    private async void OnGoogleSignUpClicked(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new CreateAccountPage());
    }
}