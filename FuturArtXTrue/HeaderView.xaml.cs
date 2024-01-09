using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuturArtXTrue;

public partial class HeaderView : ContentView
{
    public HeaderView()
    {
        InitializeComponent();
        Menu.IsVisible = false;
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
    public void ChangePageUeberUns(object sender, EventArgs e)
    {
        App.Current.MainPage = new UeberUnsPage();
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