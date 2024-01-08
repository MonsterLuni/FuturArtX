namespace FuturArtXTrue;

public partial class RegisterExponatPage : ContentPage
{
    private MyViewModel _viewModel;
    public RegisterExponatPage()
    {
        InitializeComponent();
        InitializeViewModel();
        Menu.IsVisible = false;
    }
    private void InitializeViewModel()
    {
        _viewModel = new MyViewModel();
        BindingContext = _viewModel;
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