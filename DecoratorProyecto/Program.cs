//El decorator es un patron de diseño que asicamente lo que hace es que permite agregar lo que puede hacer un objeto sin que se tenga que cambiar la estrucutra
//este es diferente a la herencia en la herencia se la clase  debe depender de la clase padre y en el decorator no en el decorator se agrega una clase que se encarga de agregar las funcionalidades
using DecoratorProyecto;


List<string> productos = new List<string>()
{
    "PS5","Xbox X","Nintendo Switch"
};

IVentaDecorator venta = new Venta(productos);
Console.WriteLine(venta);

venta = new CargoDecorador(venta, 250);
Console.WriteLine(venta);

venta = new DescuentoDecorador(venta, 80);
Console.WriteLine(venta);