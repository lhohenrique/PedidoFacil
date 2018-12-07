using PedidoFacil.Models;
using PedidoFacil.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace PedidoFacil.Services
{
    public class MenuItemService
    {
        private static ObservableCollection<MenuItem> menuList { get; set; }

        public static ObservableCollection<MenuItem> GetMenuItems()
        {
            menuList = new ObservableCollection<MenuItem>();

            var pedidos = new MenuItem() { Title = "Pedidos", Icon = "", TargetType = typeof(PedidosPage) };
            var clientes = new MenuItem() { Title = "Clientes", Icon = "", TargetType = typeof(ClientesPage) };
            var representadas = new MenuItem() { Title = "Representadas", Icon = "", TargetType = typeof(RepresentadasPage) };

            menuList.Add(pedidos);
            menuList.Add(clientes);
            menuList.Add(representadas);

            return menuList;
        }
    }
}
