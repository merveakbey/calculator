namespace calculator;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}


	private void Button_Clicked(object sender, EventArgs e)
	{
        Navigation.PushAsync(new MainPage());
    }


}