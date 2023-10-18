using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorProyecto
{
   public interface IVentaDecorator
    {
        decimal CalcularTotal();
        List<string> ObtenerProducto();
    }
}
