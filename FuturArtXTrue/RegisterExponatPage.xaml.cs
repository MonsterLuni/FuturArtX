namespace FuturArtXTrue;

public partial class RegisterExponatPage : ContentPage
{
    private MyViewModel _viewModel;
    private MyViewModel ViewModel => (MyViewModel)BindingContext;
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
    private async void OnSelectImageClicked(object sender, EventArgs e)
    {
        try
        {
            var result = await MediaPicker.PickPhotoAsync(new MediaPickerOptions
            {
                Title = "Bild auswählen"
            });

            if (result != null)
            {
                // Das ausgewählte Bild anzeigen= result.FullPath;
                ViewModel.SelectedImageSource = ImageSource.FromFile(result.FullPath);
                selectedImage.Source = ImageSource.FromFile(result.FullPath);
            }
        }
        catch (Exception ex)
        {
            // Fehlerbehandlung
            Console.WriteLine($"Fehler beim Auswählen des Bilds: {ex.Message}");
        }
    }
}