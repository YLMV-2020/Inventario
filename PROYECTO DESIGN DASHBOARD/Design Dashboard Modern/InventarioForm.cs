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
    public partial class InventarioForm : Form
    {
        GestorSQL gestorSQL;
        ProductoDAO productoDAO;
        public InventarioForm()
        {
            InitializeComponent();
            this.gestorSQL = new GestorSQL();
            this.productoDAO = new ProductoDAO(gestorSQL);
            actualizarDatosProductos();
        }

        private void buttonAgregarProducto_Click(object sender, EventArgs e)
        {

        }

        private void actualizarDatosProductos()
        {
            dataGridViewProductos.Rows.Clear();
            gestorSQL.abrirConexion();
            var listaDeProductos = productoDAO.obtenerListaDeProductos();

            foreach (var producto in listaDeProductos)
            {
                int n = dataGridViewProductos.Rows.Add();

                dataGridViewProductos.Rows[n].Cells[0].Value = producto.Nombre;
                dataGridViewProductos.Rows[n].Cells[1].Value = producto.Descripcion;
                dataGridViewProductos.Rows[n].Cells[2].Value = producto.Precio;
                dataGridViewProductos.Rows[n].Cells[3].Value = producto.Cantidad;
                dataGridViewProductos.Rows[n].Cells[4].Value = producto.Categoria.Nombre;
            }
            gestorSQL.cerrarConexion();
        }
    }
}
