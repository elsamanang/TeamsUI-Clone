using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamsUI.ViewModels;

namespace TeamsUI.Utils.Components.ViewModels
{
    internal class SideBarViewModel: ViewModelBase
    {
        private ObservableCollection<string> _menus = [ "cat", "camel", "cow", "chameleon", "mouse", "lion", "zebra" ];

        public ObservableCollection<string> Menus
        {
            get => _menus;
            set => SetProperty(ref _menus, value);
        }
    }
}
