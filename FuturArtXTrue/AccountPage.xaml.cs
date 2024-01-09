using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuturArtXTrue;

public partial class AccountPage : ContentPage
{
    private MyViewModel _viewModel;
    public AccountPage()
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