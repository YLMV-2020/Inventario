using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dominio.Contratos;
using Dominio.Entidades;

namespace Persistencia.ADO_SQLServer
{
    public class CategoriaDAO : ICategoria
    {
        private GestorSQL gestorSQL;

        public CategoriaDAO(IGestorAccesoDatos gestorSQL)
        {
            this.gestorSQL = (GestorSQL)gestorSQL;
        }

        public List<Categoria> obtenerListaDeCategorias()
        {
            List<Categoria> listaDeCategoria = new List<Categoria>();
            string consultaSQL = "select * from Categoria";
            try
            {
                SqlDataReader resultadoSQL = gestorSQL.ejecutarConsulta(consultaSQL);
                while (resultadoSQL.Read())
                {
                    listaDeCategoria.Add(obtenerCategoria(resultadoSQL));
                }
            }
            catch (Exception err)
            {
                throw err;
            }
            return listaDeCategoria;
        }

        public Categoria obtenerCategoria(SqlDataReader resultadoSQL)
        {
            Categoria categoria = new Categoria();
            categoria.Nombre = resultadoSQL.GetString(1);
            categoria.Descripcion = resultadoSQL.GetString(2);
            return categoria;
        }
    }
}
