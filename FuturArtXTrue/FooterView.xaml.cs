namespace FuturArtXTrue;

public partial class FooterView : ContentView
{
    public FooterView()
    {
        InitializeComponent();
    }
    public void ChangePageHome(object sender, EventArgs e)
    {
        App.Current.MainPage = new HomePage();
    }
    public void ChangePageAccount(object sender, EventArgs e)
    {
        App.Current.MainPage = new AccountPage();
    }
    public void ChangePageExponat(object sender, EventArgs e)
    {
        App.Current.MainPage = new ExponatPage();
    }
}