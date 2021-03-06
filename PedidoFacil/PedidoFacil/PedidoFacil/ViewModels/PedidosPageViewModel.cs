﻿using PedidoFacil.Models;
using PedidoFacil.Services;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace PedidoFacil.ViewModels
{
    public class PedidosPageViewModel : BindableBase, INavigatedAware
    {
        private INavigationService navigationService;

        #region Properties
        private string titleTab1;
        public string TitleTab1
        {
            get { return titleTab1; }
            set { SetProperty(ref titleTab1, value); }
        }

        private string titleTab2;
        public string TitleTab2
        {
            get { return titleTab2; }
            set { SetProperty(ref titleTab2, value); }
        }

        private ObservableCollection<Pedido> pedidosSentList;
        public ObservableCollection<Pedido> PedidosSentList
        {
            get { return pedidosSentList; }
            set { SetProperty(ref pedidosSentList, value); }
        }

        private ObservableCollection<Pedido> pedidosNotSentList;
        public ObservableCollection<Pedido> PedidosNotSentList
        {
            get { return pedidosNotSentList; }
            set { SetProperty(ref pedidosNotSentList, value); }
        }
        #endregion

        #region Commands
        public DelegateCommand AddPedidoButtonCommand { get; set; }
        #endregion

        public PedidosPageViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;

            TitleTab1 = "Enviados";
            TitleTab2 = "Não Enviados";

            AddPedidoButtonCommand = new DelegateCommand(AddPedidoButtonAction);

            PedidosSentList = MockService.GetPedidosSentList();
            PedidosNotSentList = MockService.GetPedidosNotSentList();
        }

        #region Actions
        private void AddPedidoButtonAction()
        {
            navigationService.NavigateAsync("AddPedidosPage");
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
            
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            
        }
        #endregion
    }
}
