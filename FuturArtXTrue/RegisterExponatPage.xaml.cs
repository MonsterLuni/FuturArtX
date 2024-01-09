namespace FuturArtXTrue;

public partial class RegisterExponatPage : ContentPage
{
    private MyViewModel _viewModel;
    public RegisterExponatPage()
    {
        InitializeComponent();
        InitializeViewModel();
    }
    private void InitializeViewModel()
    {
        _viewModel = new MyViewModel();
        BindingContext = _viewModel;
    }
}