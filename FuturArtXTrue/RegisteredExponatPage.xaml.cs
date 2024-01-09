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
    }
}