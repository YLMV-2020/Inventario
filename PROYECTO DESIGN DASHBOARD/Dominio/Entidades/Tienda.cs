using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    class Tienda
    {
        private string nombre;
        private string direccion;
        private string ruc;
        private List<Producto> listaDeProductos;
        private List<Categoria> listaDeCategorias;
        private List<Venta> listaDeVentas;
        private List<Cliente> listaDeClientes;

        public Tienda(string nombre, string direccion, string ruc, List<Producto> listaDeProductos, List<Categoria> listaDeCategorias, List<Venta> listaDeVentas, List<Cliente> listaDeClientes)
        {
            this.Nombre = nombre;
            this.Direccion = direccion;
            this.Ruc = ruc;
            this.ListaDeProductos = listaDeProductos;
            this.ListaDeCategorias = listaDeCategorias;
            this.ListaDeVentas = listaDeVentas;
            this.ListaDeClientes = listaDeClientes;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Ruc { get => ruc; set => ruc = value; }
        public List<Categoria> ListaDeCategorias { get => listaDeCategorias; set => listaDeCategorias = value; }
        internal List<Producto> ListaDeProductos { get => listaDeProductos; set => listaDeProductos = value; }
        internal List<Venta> ListaDeVentas { get => listaDeVentas; set => listaDeVentas = value; }
        internal List<Cliente> ListaDeClientes { get => listaDeClientes; set => listaDeClientes = value; }
    }
}
