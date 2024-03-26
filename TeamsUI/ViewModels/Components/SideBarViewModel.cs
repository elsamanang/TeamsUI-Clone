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
            var data = new ObservableCollection<Menu>();
            for (var i = 1; i <= 5; i++)
            {
                data.Add(new Menu { Name = $"menu{i}" });
            }
            _menus = data;
    }
    }
}
