using PedidoFacil.Models;
using PedidoFacil.Services;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace PedidoFacil.ViewModels
{
	public class AddPedidosPageViewModel : BindableBase
	{
        #region Properties
        private ObservableCollection<Cliente> clientesList;
        public ObservableCollection<Cliente> ClientesList
        {
            get { return clientesList; }
            set { SetProperty(ref clientesList, value); }
        }
        #endregion

        public AddPedidosPageViewModel()
        {
            ClientesList = MockService.GetClientesList();
        }
	}
}
