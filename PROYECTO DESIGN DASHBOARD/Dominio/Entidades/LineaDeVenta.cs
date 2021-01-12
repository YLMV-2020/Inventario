using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    class LineaDeVenta
    {
        private Producto producto;
        private int cantidad;
        private string descipcion;
        private float precioUnitario;
        private float importe;
       
      
        public LineaDeVenta(Producto producto, int cantidad, string descipcion, float precioUnitario, float importe)
        {
            this.Producto = producto;
            this.Cantidad = cantidad;
            this.Descipcion = descipcion;
            this.PrecioUnitario = precioUnitario;
            this.Importe = importe;
        }

        public LineaDeVenta() { }

        public int Cantidad { get => cantidad; set => cantidad = value; }
        public string Descipcion { get => descipcion; set => descipcion = value; }
        public float PrecioUnitario { get => precioUnitario; set => precioUnitario = value; }
        public float Importe { get => importe; set => importe = value; }
        internal Producto Producto { get => producto; set => producto = value; }
        
    }
}
