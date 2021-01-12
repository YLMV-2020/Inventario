using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Contratos
{
    public interface IProducto
    {
        List<Producto> obtenerListaDeProductos();
        void guardarProducto(Producto producto);
    }
}
