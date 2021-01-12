using Dominio.Contratos;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.ADO_SQLServer
{
    public class ProductoDAO : IProducto
    {
        private GestorSQL gestorSQL;

        public ProductoDAO(IGestorAccesoDatos gestorSQL)
        {
            this.gestorSQL = (GestorSQL)gestorSQL;
        }

        public List<Producto> obtenerListaDeProductos()
        {
            List<Producto> listaDeProductos = new List<Producto>();
            string consultaSQL = "select P.nombre,P.descripcion,P.precio,P.cantidad,C.nombre,C.descripcion from Producto P left join Categoria C ON P.id_categoria = C.id_categoria";
            try
            {
                SqlDataReader resultadoSQL = gestorSQL.ejecutarConsulta(consultaSQL);
                while (resultadoSQL.Read())
                {
                    listaDeProductos.Add(obtenerProducto(resultadoSQL));
                }
            }
            catch (Exception err)
            {
                throw err;
            }
            return listaDeProductos;
        }

        public Producto obtenerProducto(SqlDataReader resultadoSQL)
        {
            Producto producto = new Producto();
            producto.Nombre = resultadoSQL.GetString(0);
            producto.Descripcion = resultadoSQL.GetString(1);
            producto.Precio = (float)resultadoSQL.GetDouble(2);
            producto.Cantidad = resultadoSQL.GetInt32(3);

            Categoria categoria = new Categoria();

            if (resultadoSQL.IsDBNull(4))
            {
                categoria.Nombre = "";
                categoria.Descripcion = "";
            }
            else
            {
                categoria.Nombre = resultadoSQL.GetString(4);
                categoria.Descripcion = resultadoSQL.GetString(5);
            }

            producto.Categoria = categoria;

            return producto;
        }

        public void guardarProducto(Producto producto)
        {
            //string consultaSQL = String.Format("insert into Cliente" +
            //    "(nombres, dni) " +
            //    "values('{0}', {1})",
            //    cliente.Nombres, cliente.Dni);

            //gestorSQL.ejecutarConsulta(consultaSQL);
        }
    }
}
