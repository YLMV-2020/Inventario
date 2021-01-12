using Persistencia.ADO_SQLServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    public partial class Inicio : Form
    {
        GestorSQL gestorSQL;
        ClienteDAO clienteDAO;
        public Inicio()
        {
            InitializeComponent();
            gestorSQL = new GestorSQL();
            clienteDAO = new ClienteDAO(gestorSQL);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //dataGridViewCliente.Rows.Clear();
            //gestorSQL.abrirConexion();
            //var listaDeClientes = clienteDAO.obtenerListaDeClientes();

            //foreach(var cliente in listaDeClientes)
            //{
            //    int n = dataGridViewCliente.Rows.Add();

            //    dataGridViewCliente.Rows[n].Cells[0].Value = cliente.Nombres;
            //    dataGridViewCliente.Rows[n].Cells[1].Value = cliente.Dni;
            //    dataGridViewCliente.Rows[n].Cells[2].Value = cliente.VentasRealizadas;
            //    dataGridViewCliente.Rows[n].Cells[3].Value = cliente.ValorTotal;
            //}
            //gestorSQL.cerrarConexion();


        }
    }
}
