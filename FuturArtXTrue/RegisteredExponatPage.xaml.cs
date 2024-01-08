namespace FuturArtXTrue;

public partial class RegisteredExponatPage : ContentPage
{
    public RegisteredExponatPage(string text, string gegenstand, string beschreibung, string image, string email)
    {
        InitializeComponent();
        Name.Text = text;
        Gegenstand.Text = gegenstand;
        Beschreibung.Text = beschreibung;
        Image.Source = image;
        Email.Text = email;
        Menu.IsVisible = false;
    }
    private void ChangePageExponat(object sender, EventArgs e)
    {
        App.Current.MainPage = new ExponatPage();
    }
    private void ChangePageHome(object sender, EventArgs e)
    {
        App.Current.MainPage = new HomePage();
    }
    private void ChangePageAccount(object sender, EventArgs e)
    {
        App.Current.MainPage = new AccountPage();
    }
    private void ChangePageExponatRegister(object sender, EventArgs e)
    {
        App.Current.MainPage = new RegisterExponatPage();
    }
    private void ShowMenu(object sender, EventArgs e)
    {
        Menu.IsVisible = !Menu.IsVisible;
    }
}