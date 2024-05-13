using Avalonia.Controls;
using TeamsUI.ViewModels;

namespace TeamsUI.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();
        DataContext = new MainViewModel();
    }
}
