using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Material.Icons;
using System.Collections.ObjectModel;
using TeamsUI.Models;
using TeamsUI.Views;

namespace TeamsUI.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    public string Greeting => "Welcome to Avalonia!";
    private ObservableCollection<Menu> _menus;
    [ObservableProperty]
    private Menu? _selectedMenu;

    public ObservableCollection<Menu> Menus
    {
        get => _menus;
        set => SetProperty(ref _menus, value);
    }

    public MainViewModel() {
        var data = new ObservableCollection<Menu>()
            {
               new Menu {Name= "Activité", Icon=MaterialIconKind.Bell, IconOutline=MaterialIconKind.BellOutline},
               new Menu {Name= "Conversation", Icon=MaterialIconKind.ChatProcessing, IconOutline=MaterialIconKind.ChatProcessingOutline},
               new Menu {Name= "Equipe", Icon=MaterialIconKind.AccountGroup, IconOutline=MaterialIconKind.AccountGroupOutline},
               new Menu {Name= "Devoir", Icon=MaterialIconKind.BagPersonal, IconOutline=MaterialIconKind.BagPersonalOutline},
               new Menu {Name= "Calendrier", Icon=MaterialIconKind.CalendarMonth, IconOutline=MaterialIconKind.CalendarMonthOutline},
               new Menu {Name= "", Icon=MaterialIconKind.DotsHorizontal, IconOutline=MaterialIconKind.DotsHorizontal},
               new Menu {Name= "Applications", Icon=MaterialIconKind.Microsoft, IconOutline=MaterialIconKind.Microsoft},
            };
        _menus = data;
    }

    [RelayCommand]
    public void UpdateView(string value)
    {
        Navigate(new Help());
    }

    partial void OnSelectedMenuChanged(Menu? value)
    {
        if (value == null) return;

        switch (value.Name)
        {
            case "Activité":
                Navigate(new Activities());
                break;
            case "Devoir":
                Navigate(new Devoir());
                break;
            case "Conversation":
                Navigate(new Conversation());
                break;
            case "Equipe":
                Navigate(new Equipe());
                break;
            case "Calendrier":
                Navigate(new Calendar());
                break;
            case "Applications":
                Navigate(new Application());
                break;
            default:
                break;
        }
    }

}

