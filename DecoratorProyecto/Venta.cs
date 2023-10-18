using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorProyecto
{
    public class Venta : IVentaDecorator
    {
        private List<string> _productos;
        public Venta(List<string>productos)
        {
            _productos = productos;
        }
        public Venta():this(new List<string>())
        {
        }
        public decimal CalcularTotal()
        {
            decimal total = 100000;
            return total;
        }
        public List<string> ObtenerProducto()
        {
            return _productos;
        }

        public override string ToString() => 
            $"Total venta: {CalcularTotal():N2}";
    }
}
