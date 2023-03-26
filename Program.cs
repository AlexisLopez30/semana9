using semana8.Models;

using AlmacenContext db = new AlmacenContext();

CrudProductos CrudProductos = new CrudProductos();
Producto Pro = new Producto();

Console.Write(@"Menu
Pulse 1 para Insertar un nuevo Producto
Pulse 2 para Salir
-> ");

var Menu = Convert.ToInt32(Console.ReadLine());

switch (Menu)
{
    case 1:
        bool bucle = true;
        while (bucle == true)
        {
            Console.Write("Ingrese el nombre del producto -> ");
            Pro.Nombre = Console.ReadLine();
            Console.Write("\nIngrese una breve descripcion del producto -> ");
            Pro.Descripcion = Console.ReadLine();
            Console.Write("\nIngrese el precio del producto -> $");
            Pro.Precio = Convert.ToDecimal(Console.ReadLine());
            Console.Write("\nIngrese la cantidad de productos existentes");
            Pro.Stock = Convert.ToInt32(Console.ReadLine());

            CrudProductos.AgregarProducto(Pro);

            Console.Write(@"
El Producto se ingreso correctamente
Pulsa 1 para seguir insertando Productos
Pulsa 2 para salir
-> ");

            var Menu2 = Convert.ToInt32(Console.ReadLine());

            switch (Menu2)
            {
                case 1:
                    bucle = true;
                    break;

                case 2:
                    Console.Write("Gracias por utilizar el programa");
                    bucle = false;
                    break;

                default:
                    Console.Write("Ingrese una opcion del menu");
                    break;
            }
        }
        break;

    case 2:
        Console.Write("Gracias por utilizar el programa");
        break;

    default:
        Console.Write("La opcion no se encuentra disponible");
        break;
}
