using PedidoFacil.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace PedidoFacil.Services
{
    public class MockService
    {
        public static ObservableCollection<Pedido> GetPedidosSentList()
        {
            var pedidosSentList = new ObservableCollection<Pedido>
            {
                new Pedido
                {
                    PedidoNumber = "#1",
                    Cliente = new Cliente(){ Name = "Cliente 1" },
                    Representada = new Representada(){Name="Representada 1"},
                    CondicaoDePagamento = "1 Vez",
                    Value = 10000d
                },
                new Pedido
                {
                    PedidoNumber = "#2",
                    Cliente = new Cliente(){ Name = "Cliente 2" },
                    Representada = new Representada(){Name="Representada 2"},
                    CondicaoDePagamento = "2 Vezes",
                    Value = 25000d
                }
            };

            return pedidosSentList;
        }

        public static ObservableCollection<Pedido> GetPedidosNotSentList()
        {
            var pedidosSentList = new ObservableCollection<Pedido>
            {
                new Pedido
                {
                    PedidoNumber = "#1",
                    Cliente = new Cliente(){ Name = "Cliente 3" },
                    Representada = new Representada(){Name="Representada 2"},
                    CondicaoDePagamento = "1 Vez",
                    Value = 10000f
                },
                new Pedido
                {
                    PedidoNumber = "#2",
                    Cliente = new Cliente(){ Name = "Cliente 4" },
                    Representada = new Representada(){Name="Representada 1"},
                    CondicaoDePagamento = "2 Vezes",
                    Value = 25000f
                }
            };

            return pedidosSentList;
        }

        public static ObservableCollection<Cliente> GetClientesList()
        {
            var clientesList = new ObservableCollection<Cliente>
            {
                new Cliente
                {
                    Name = "Cliente 1"
                },
                new Cliente
                {
                    Name = "Cliente 2"
                }
            };

            return clientesList;
        }
    }
}
