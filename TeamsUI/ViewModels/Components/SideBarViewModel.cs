using Material.Icons;
using Material.Icons.Avalonia;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TeamsUI.Models;

namespace TeamsUI.ViewModels.Components
{
    public partial class SideBarViewModel : ViewModelBase
    {
        private ObservableCollection<Menu> _menus;

        public ObservableCollection<Menu> Menus
        {
            get => _menus;
            set => SetProperty(ref _menus, value);
        }

        public SideBarViewModel()
        {
            var data = new ObservableCollection<Menu>()
            {
               new Menu {Name= "Nom", Icon=MaterialIconKind.Bell, IconOutline=MaterialIconKind.BellOutline },
               new Menu {Name= "Nom", Icon=MaterialIconKind.ChatProcessing, IconOutline=MaterialIconKind.ChatProcessingOutline},
               new Menu {Name= "Nom", Icon=MaterialIconKind.AccountGroup, IconOutline=MaterialIconKind.AccountGroupOutline},
            };
            
            _menus = data;
    }
    }
}
