namespace FuturArtXTrue;

public partial class RegisterExponatPage : ContentPage
{
    public RegisterExponatPage()
    {
        InitializeComponent();
        Menu.IsVisible = false;
    }
    public void ChangePageExponat(object sender, EventArgs e)
    {
        App.Current.MainPage = new ExponatPage();
    }
    public void ChangePageHome(object sender, EventArgs e)
    {
        App.Current.MainPage = new HomePage();
    }
    public void ChangePageAccount(object sender, EventArgs e)
    {
        App.Current.MainPage = new AccountPage();
    }
    public void ChangePageExponatRegister(object sender, EventArgs e)
    {
        App.Current.MainPage = new RegisterExponatPage();
    }
    public void ShowMenu(object sender, EventArgs e)
    {
        Menu.IsVisible = !Menu.IsVisible;
    }
}