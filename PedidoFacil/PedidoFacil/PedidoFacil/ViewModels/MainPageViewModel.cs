using PedidoFacil.Models;
using PedidoFacil.Services;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace PedidoFacil.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        #region Properties
        private ObservableCollection<MenuItem> menuItemList;
        public ObservableCollection<MenuItem> MenuItemList
        {
            get { return menuItemList; }
            set { SetProperty(ref menuItemList, value); }
        }

        private bool isPresented;
        public bool IsPresented
        {
            get { return isPresented; }
            set { SetProperty(ref isPresented, value); }
        }
        #endregion

        #region Commands
        //public DelegateCommand<MenuItem> MenuItemSelectedCommand { get; set; }
        #endregion

        public MainPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            MenuItemList = MenuItemService.GetMenuItems();
        }
    }
}
