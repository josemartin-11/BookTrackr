class Program
{
    static void Main()
    {
        Catalogo catalogo = new Catalogo();
        Historial historial = new Historial();

        // Libros iniciales
        catalogo.CargarLibroInicial("El Hobbit", "Fantasía");
        catalogo.CargarLibroInicial("1984", "Clásico");
        catalogo.CargarLibroInicial("Dune", "Ciencia ficción");

        int opcion;

        do
        {
            Menu.Mostrar();
            Console.Write("Opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (opcion)
            {
                case 1:
                    catalogo.MostrarCatalogo();
                    break;
                case 2:
                    catalogo.AgregarLibro();
                    break;
                case 3:
                    catalogo.RegistrarVenta();
                    break;
                case 4:
                    catalogo.RegistrarPrestamo();
                    break;
                case 5:
                    historial.AgregarLectura();
                    break;
                case 6:
                    historial.MostrarHistorial();
                    break;
                case 7:
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción incorrecta.\n");
                    break;
            }

        } while (opcion != 7);
    }
}