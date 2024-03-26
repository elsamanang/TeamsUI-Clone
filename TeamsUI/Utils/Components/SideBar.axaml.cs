using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using TeamsUI.ViewModels.Components;

namespace TeamsUI;

public partial class SideBar : UserControl
{
    public SideBar()
    {
        InitializeComponent();

        DataContext = new SideBarViewModel();
    }
}