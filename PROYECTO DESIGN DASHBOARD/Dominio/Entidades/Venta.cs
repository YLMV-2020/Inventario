using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    class Venta
    {
        private Cliente cliente;
        private Tienda tienda;
        private List<LineaDeVenta> listaDeVentas;
        private DateTime fecha;

        public Venta(Cliente cliente, Tienda tienda, List<LineaDeVenta> listaDeVentas, DateTime fecha)
        {
            this.Cliente = cliente;
            this.Tienda = tienda;
            this.ListaDeVentas = listaDeVentas;
            this.Fecha = fecha;
        }

        public DateTime Fecha { get => fecha; set => fecha = value; }
        internal Cliente Cliente { get => cliente; set => cliente = value; }
        internal Tienda Tienda { get => tienda; set => tienda = value; }
        internal List<LineaDeVenta> ListaDeVentas { get => listaDeVentas; set => listaDeVentas = value; }
    }
}
