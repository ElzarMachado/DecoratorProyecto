using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorProyecto
{
    public abstract class VentaDecorador : IVentaDecorator
    {
        private IVentaDecorator _venta;

        public VentaDecorador(IVentaDecorator venta)
        {
            _venta = venta;
        }

        public virtual decimal CalcularTotal()
        {
            return _venta.CalcularTotal();
        }

        public virtual List<string> ObtenerProducto()
        {
            return _venta.ObtenerProducto();
        }
    }
}
