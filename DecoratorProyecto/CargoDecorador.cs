using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorProyecto
{
    public class CargoDecorador : VentaDecorador
    {
        private decimal _importeCargo;
        public CargoDecorador(IVentaDecorator venta, decimal importeCargo)
            : base(venta)
        {
            _importeCargo = importeCargo;
        }

        public override decimal CalcularTotal()
        {
            decimal total = base.CalcularTotal();
            return total + _importeCargo;
        }

        public override string ToString()
        {
            return $"Total con cargo: {CalcularTotal():N2}";
        }
    }
}