// ViewModel.cs

using System.Collections.ObjectModel;
using System.Text.RegularExpressions;

namespace FuturArtXTrue
{
    public class MyViewModel : BindableObject
    {
        
        public ObservableCollection<string> CarouselItems { get; }
        
        public static readonly BindableProperty NameProperty = BindableProperty.Create(nameof(Name), typeof(string), typeof(MyViewModel), default(string));
        public static readonly BindableProperty EmailProperty = BindableProperty.Create(nameof(Email), typeof(string), typeof(MyViewModel), default(string));
        public static readonly BindableProperty GegenstandProperty = BindableProperty.Create(nameof(Gegenstand), typeof(string), typeof(MyViewModel), default(string));
        public static readonly BindableProperty BeschreibungProperty = BindableProperty.Create(nameof(Beschreibung), typeof(string), typeof(MyViewModel), default(string));
        public string Name
        {
            get => (string)GetValue(NameProperty);
            set => SetValue(NameProperty, value);
        }
        public string Email
        {
            get => (string)GetValue(EmailProperty);
            set => SetValue(EmailProperty, value);
        }
        public string Gegenstand
        {
            get => (string)GetValue(GegenstandProperty);
            set => SetValue(GegenstandProperty, value);
        }
        public string Beschreibung
        {
            get => (string)GetValue(BeschreibungProperty);
            set => SetValue(BeschreibungProperty, value);
        }
        public ObservableCollection<CarouselContent> CarouselThings { get; }
        public MyViewModel()
        {
            ValidateCommand = new Command(Validate);
            CarouselThings = new ObservableCollection<CarouselContent>
            {
                new CarouselContent { gegenstand = "Sternennacht", beschreibung = "Die Wirbel in diesem Extraordinären Exponat sind alle voller Personalität und sorgen für innere Wohlfühlsamkeit.", image = "kunst1.png", number = "1"},
                new CarouselContent { gegenstand = "Der Schrei", beschreibung = "Der Schrei verkörpert ein verlangen dass viele Menschen auch bereits erlebt haben, es repräsentiert die verzweiflung.", image = "kunst2.png", number = "2"},
                new CarouselContent { gegenstand = "Antiker Staubsauger", beschreibung = "Dies ist ein sehr eleganter und schöner Staubsauger der in vielen Hinsichten nur so vor Originalität strahlt. Er ist noch ganz!", image = "kunst3.png", number = "3"},
            };
        }

        public Command ValidateCommand { get; }
        
        private Color _NameBackgroundColor = Colors.Black;
        private Color _EmailBackgroundColor = Colors.Black;
        private Color _GegenstandBackgroundColor = Colors.Black;
        private Color _BeschreibungBackgroundColor = Colors.Black;
        
        public Color NameBackgroundColor
        {
            get => _NameBackgroundColor;
            set
            {
                _NameBackgroundColor = value;
                OnPropertyChanged();
            }
        }
        public Color EmailBackgroundColor
        {
            get => _EmailBackgroundColor;
            set
            {
                _EmailBackgroundColor = value;
                OnPropertyChanged();
            }
        }
        public Color GegenstandBackgroundColor
        {
            get => _GegenstandBackgroundColor;
            set
            {
                _GegenstandBackgroundColor = value;
                OnPropertyChanged();
            }
        }
        public Color BeschreibungBackgroundColor
        {
            get => _BeschreibungBackgroundColor;
            set
            {
                _BeschreibungBackgroundColor = value;
                OnPropertyChanged();
            }
        }
        
        private void Validate()
        {
            if (string.IsNullOrWhiteSpace(Name) ||  string.IsNullOrWhiteSpace(Email) || string.IsNullOrWhiteSpace(Gegenstand) || string.IsNullOrWhiteSpace(Beschreibung))
            {
                ShowAlert("Validierung Fehlgeschlagen","Die Rot markierten Felder sind nicht ausgefüllt");
                NameBackgroundColor = Colors.Black;
                GegenstandBackgroundColor = Colors.Black;
                BeschreibungBackgroundColor = Colors.Black;
                EmailBackgroundColor = Colors.Black;
                if (string.IsNullOrWhiteSpace(Name))
                {
                    NameBackgroundColor = Colors.Red;
                }
                if (string.IsNullOrWhiteSpace(Email))
                {
                    EmailBackgroundColor = Colors.Red;
                }
                if (string.IsNullOrWhiteSpace(Gegenstand))
                {
                    GegenstandBackgroundColor = Colors.Red;
                }
                if (string.IsNullOrWhiteSpace(Beschreibung))
                {
                    BeschreibungBackgroundColor = Colors.Red;
                }
            }
            else if (!ValidateNoSpecialCharacters(Name) || !ValidateNoSpecialCharacters(Gegenstand))
            {
                ShowAlert("Validierung Fehlgeschlagen","Der Name und Gegenstand dürfen keine Sonderzeichen enthalten");
                NameBackgroundColor = Colors.Black;
                GegenstandBackgroundColor = Colors.Black;
                BeschreibungBackgroundColor = Colors.Black;
                if (!ValidateNoSpecialCharacters(Name))
                {
                    NameBackgroundColor = Colors.Red;
                }
                if (!ValidateNoSpecialCharacters(Gegenstand))
                {
                    GegenstandBackgroundColor = Colors.Red;
                }
            }
            else if (!IsValidEmail(Email))
            {
                ShowAlert("Validierung Fehlgeschlagen","Die Email-Adresse ist nicht korrekt");
                NameBackgroundColor = Colors.Black;
                GegenstandBackgroundColor = Colors.Black;
                BeschreibungBackgroundColor = Colors.Black;
                EmailBackgroundColor = Colors.Red;
            }
            else
            {
                NameBackgroundColor = Colors.Black;
                GegenstandBackgroundColor = Colors.Black;
                BeschreibungBackgroundColor = Colors.Black;
                EmailBackgroundColor = Colors.Black;
                App.Current.MainPage = new RegisteredExponatPage(Name,Gegenstand,Beschreibung,"",Email);
            }
        }
        
        static bool ValidateNoSpecialCharacters(string input)
        {
            // Regex, der nur Buchstaben und Ziffern zulässt
            string pattern = "^[a-zA-Z0-9\\s]*$";
        
            Regex regex = new Regex(pattern);
            return regex.IsMatch(input);
        }
        private bool IsValidEmail(string email)
        {
            // Einfacher Regulärer Ausdruck für E-Mail-Validierung
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(emailPattern);
            return regex.IsMatch(email);
        }
        private void ShowAlert(string title,string message)
        {
            // Anzeige einer Alert-Meldung
            Page currentPage = Application.Current?.MainPage;
            currentPage?.DisplayAlert(title, message, "OK");
        }
    }
}