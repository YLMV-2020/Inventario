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
    public class ClienteDAO : ICliente
    {
        private GestorSQL gestorSQL;

        public ClienteDAO(IGestorAccesoDatos gestorSQL)
        {
            this.gestorSQL = (GestorSQL)gestorSQL;
        }

        public List<Cliente> obtenerListaDeClientes()
        {
            List<Cliente> listaDeClientes = new List<Cliente>();
            string consultaSQL = "select * from Cliente";
            try
            {
                SqlDataReader resultadoSQL = gestorSQL.ejecutarConsulta(consultaSQL);
                while (resultadoSQL.Read())
                {
                    listaDeClientes.Add(obtenerCliente(resultadoSQL));
                }
            }
            catch (Exception err)
            {
                throw err;
            }
            return listaDeClientes;
        }

        public Cliente obtenerCliente(SqlDataReader resultadoSQL)
        {
            Cliente cliente = new Cliente();
            cliente.Nombres = resultadoSQL.GetString(1);
            cliente.Dni = resultadoSQL.GetInt32(2);
            cliente.VentasRealizadas = resultadoSQL.GetInt32(3);
            cliente.ValorTotal = (float)resultadoSQL.GetDouble(4);
            return cliente;
        }

        public void guardarCliente(Cliente cliente)
        {
            string consultaSQL = String.Format("insert into Cliente" +
                "(nombres, dni) " +
                "values('{0}', {1})",
                cliente.Nombres, cliente.Dni);

            gestorSQL.ejecutarConsulta(consultaSQL);
        }
    }
}
