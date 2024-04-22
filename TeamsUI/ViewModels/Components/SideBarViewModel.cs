﻿using Material.Icons;
using Material.Icons.Avalonia;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
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
               new Menu {Name= "Activité", Icon=MaterialIconKind.Bell, IconOutline=MaterialIconKind.BellOutline },
               new Menu {Name= "Conversqtion", Icon=MaterialIconKind.ChatProcessing, IconOutline=MaterialIconKind.ChatProcessingOutline},
               new Menu {Name= "Eauipe", Icon=MaterialIconKind.AccountGroup, IconOutline=MaterialIconKind.AccountGroupOutline},
               new Menu {Name= "Devoir", Icon=MaterialIconKind.BagPersonal, IconOutline=MaterialIconKind.BagPersonalOutline},
               new Menu {Name= "Calendrier", Icon=MaterialIconKind.CalendarMonth, IconOutline=MaterialIconKind.CalendarMonthOutline},
               new Menu {Name= "", Icon=MaterialIconKind.DotsHorizontal, IconOutline=MaterialIconKind.DotsHorizontal},
               new Menu {Name= "Applications", Icon=MaterialIconKind.Microsoft, IconOutline=MaterialIconKind.Microsoft},
            };
            
            _menus = data;
        }

        public void HandleSelection()
        {
            Debug.WriteLine($"Vous avez choisi item");
        }
    }
}
