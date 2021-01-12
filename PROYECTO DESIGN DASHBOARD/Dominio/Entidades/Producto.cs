using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Producto
    {
        private string nombre;
        private string descripcion;
        private float precio;
        private int cantidad;
        private Categoria categoria;

        public Producto(string nombre, string descripcion, float precio, int cantidad, Categoria categoria)
        {
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.Precio = precio;
            this.Cantidad = cantidad;
            this.Categoria = categoria;
        }

        public Producto() { }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public float Precio { get => precio; set => precio = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public Categoria Categoria { get => categoria; set => categoria = value; }
    }
}
