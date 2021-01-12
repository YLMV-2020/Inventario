using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Persistencia.ADO_SQLServer;
using Dominio.Contratos;
using Inventario;

namespace Design_Dashboard_Modern
{
    public partial class Form1 : Form
    {
        GestorSQL gestorSQL;
        public Form1()
        {
            InitializeComponent();
            this.gestorSQL = new GestorSQL();
            AbrirFormEnPanel(new Inicio());
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Maximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            Maximizar.Visible = false;
            Restaurar.Visible = true;
        }

        private void Restaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            Restaurar.Visible = false;
            Maximizar.Visible = true;
        }

        private void MenuSidebar_Click(object sender, EventArgs e)
        {
            if(Sidebar.Width == 270)
            {
                Sidebar.Visible = false;
                Sidebar.Width = 68;
                SidebarWrapper.Width = 90;
                LineaSidebar.Width = 52;
                AnimacionSidebar.Show(Sidebar);
            }
            else
            {
                Sidebar.Visible = false;
                Sidebar.Width = 270;
                SidebarWrapper.Width = 300;
                LineaSidebar.Width = 252;
                AnimacionSidebarBack.Show(Sidebar);
            }
        }

        private void Temporizador_Tick(object sender, EventArgs e)
        {
            Temporizador.Stop();
        }


        private void AbrirFormEnPanel(object formhija)
        {
            if (this.PanelChart.Controls.Count > 0)
            {
                //for (int i = 0; i < this.PanelChart.Controls.Count; i++) 
                //{
                //    this.PanelChart.Controls.RemoveAt(i);

                //}
                this.PanelChart.Controls.RemoveAt(0);
                //this.Wrapper.Controls.RemoveAt(0);
            }
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            //this.Wrapper.Controls.Add(PanelChart);
            this.PanelChart.Controls.Add(fh);
            this.PanelChart.Tag = fh;
            fh.Show();

        }

       

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuFlatButtonInicio_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Inicio());
        }

        private void bunifuFlatCliente_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new ClienteForm());
        }

        private void bunifuFlatButtonInventario_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new InventarioForm());
        }
    }
}
