﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Entidades;

namespace Dominio.Contratos
{
    public interface ICliente
    {
        List<Cliente> obtenerListaDeClientes();
        void guardarCliente(Cliente cliente);
    }
}
