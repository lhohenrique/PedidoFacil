using PedidoFacil.Common;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace PedidoFacil.Models
{
    public class Pedido
    {
        public string PedidoNumber { get; set; }

        public Cliente Cliente { get; set; }

        public string ClienteName
        {
            get { return Cliente.Name; }
        }

        public Representada Representada { get; set; }

        public string RepresentadaName
        {
            get { return Representada.Name; }
        }

        public TipoPedido TipoDePedido { get; set; }

        public string CondicaoDePagamento { get; set; }

        public DateTime DataEmissao { get; set; }

        public Contato Contato { get; set; }

        public string EnderecoEntrega { get; set; }

        public string InformacoesAdicionais { get; set; }

        public bool Enviado { get; set; }

        public double Value { get; set; }

        public string FormattedValue
        {
            get { return Value.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")); }
        }
    }
}
