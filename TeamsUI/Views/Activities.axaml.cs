using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using TeamsUI.ViewModels;

namespace TeamsUI.Views;

public partial class Activities : UserControl
{
    public Activities()
    {
        InitializeComponent();
        DataContext = new ActivitiesViewModel();
    }
}