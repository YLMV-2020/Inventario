using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Cliente
    {
        private string nombres;
        private int dni;
        private int ventasRealizadas;
        private float valorTotal;

        public Cliente(string nombres, int dni)
        {
            this.Nombres = nombres;
            this.Dni = dni;
            this.VentasRealizadas = 0;
            this.ValorTotal = 0;
        }

        public Cliente() { }

        public string Nombres { get => nombres; set => nombres = value; }
        public int Dni { get => dni; set => dni = value; }
        public int VentasRealizadas { get => ventasRealizadas; set => ventasRealizadas = value; }
        public float ValorTotal { get => valorTotal; set => valorTotal = value; }
    }
}
