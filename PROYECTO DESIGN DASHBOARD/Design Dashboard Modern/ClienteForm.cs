using Dominio.Entidades;
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
    public partial class ClienteForm : Form
    {
        GestorSQL gestorSQL;
        ClienteDAO clienteDAO;
        public ClienteForm()
        {
            InitializeComponent();
            gestorSQL = new GestorSQL();
            clienteDAO = new ClienteDAO(gestorSQL);

            actualizarDatosClientes();

        }

        private void buttonAgregarCliente_Click(object sender, EventArgs e)
        {
            gestorSQL.abrirConexion();
            Cliente cliente = new Cliente(this.textBoxNombre.Text, int.Parse(this.textBoxDNI.Text));
            clienteDAO.guardarCliente(cliente);          
            gestorSQL.cerrarConexion();

            this.textBoxNombre.Text = "";
            this.textBoxDNI.Text = "";

            actualizarDatosClientes();
        }

        private void actualizarDatosClientes()
        {
            dataGridViewCliente.Rows.Clear();
            gestorSQL.abrirConexion();
            var listaDeClientes = clienteDAO.obtenerListaDeClientes();

            foreach (var cliente in listaDeClientes)
            {
                int n = dataGridViewCliente.Rows.Add();

                dataGridViewCliente.Rows[n].Cells[0].Value = cliente.Nombres;
                dataGridViewCliente.Rows[n].Cells[1].Value = cliente.Dni;
                dataGridViewCliente.Rows[n].Cells[2].Value = cliente.VentasRealizadas;
                dataGridViewCliente.Rows[n].Cells[3].Value = cliente.ValorTotal;
            }
            gestorSQL.cerrarConexion();
        }
    }
}
