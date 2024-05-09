using Avalonia.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using TeamsUI.Views;

namespace TeamsUI.ViewModels;

public class ViewModelBase : ObservableObject
{
    private UserControl _views;

    public UserControl Views
    {
        get => _views;
        set => SetProperty(ref _views, value);
    }

    public ViewModelBase()
    {
        _views = new Activities();
    }
    public void Navigate (UserControl views)
    {
        Views = views;
    }
}
