// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

Console.WriteLine("BIENVENIDO A BOOKTRACKR");

// ======== ========
List<string> libros = new List<string>() { "El Hobbit", "1984", "Dune" };
List<string> categorias = new List<string>() { "Fantasía", "Ciencia ficcion", "Dune","Clásico"};
List<string> vendidos = new List<string>();
List<string> prestamos = new List<string>();
List<string> historial = new List<string>();

// ======== PROGRAMA =======

int opcion = 0;

do
{
    mostrarMenu();

    Console.WriteLine("Elige una opción");
    opcion = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    switch (opcion)
{
case 1:
            MostrarLibros();
            break;

 case 2:
            AgregarLibro();
            break;

 case 3:
            RegistrarVenta();
            break;

 case 4:
            RegistrarPrestamo();
            break;

 case 5:
            RegistrarLectura();
            break;

 case 6:
            MostrarHistorial();
            break;

 case 7:
            Console.WriteLine("Saliendo del programa...");
            break;

        default:
            Console.WriteLine("Opción no válidda");
            break;
}

    } while (opcion != 6) ;


    // ====HACER LOS MÓDULOS,FUNCIONES Y PROCEDIMIENTOS) =====

    void mostrarMenu()

    {
        Console.WriteLine("===MENÚ PRINCIPAL===");
        Console.WriteLine("1. Ver catálogo");
        Console.WriteLine("2.Agregar libro al catálogo");
        Console.WriteLine("3. Registrar venta");
        Console.WriteLine("4.Registrar préstamo");
        Console.WriteLine("5. Añadir libro al historial personal");
        Console.WriteLine("6.Ver historial personal");
        Console.WriteLine("7. salir");
        Console.WriteLine();
    }

void AgregarLibrosIniciales()

    {
        int cantidad = 0;
    Console.Write("¿Cuántos libros quieres registrar al inicio?");
        cantidad = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        for (int i = 1; i <= cantidad; i++)
        {
            Console.Write("Introduce el titulo del libro" + 1 + ":");
            string titulo = Console.ReadLine();

        Console.Write("Introduce la categoría del libro" + i + ":");
            string categoria = Console.ReadLine();

            if (titulo != "" && categoria != "")
            {
                libros.Add(titulo);
                categorias.Add(categoria);
                Console.WriteLine("Liro añadido correctamente");
            }
            else
            {
                Console.WriteLine("Datos inválidos, no se añadió el libro");
                i--;
            }
        }
    }

    void MostrarLibros()
    {
        Console.WriteLine("CATÁLOGO");

        if (libros.Count == 0)
        {
            Console.WriteLine("No hy libos en el catálogo");
        }
        else
        {
        for (int i = 0; i < libros.Count; i++)
        {
            Console.WriteLine((i + 1) + "." + libros[i] + "-" + categorias[i]);


        }
            
            Console.WriteLine("\nTotal de libros:" + libros.Count + "\n");
        }
    }

    void AgregarLibro()
    {
        Console.WriteLine("Introduce el titulo del nuevo libro:");
        string nuevolibro = Console.ReadLine();

        Console.Write("Introduce la categoria del libro:");
        string categoria = Console.ReadLine();

    if (nuevolibro == "" || categoria == "")
    {
        Console.WriteLine("Datos inválidos. No se agregó el libro.\n");
        }

    else
    {
        libros.Add(nuevolibro);
        categorias.Add(categoria);
        Console.WriteLine("Libro añadido correctamente.\n");
        }
    }

void RegistrarVenta()
{
    if (libros.Count == 0)
    {
        Console.WriteLine("No hay libros disponibles.\n");
        }

    else
    {
        MostrarLibros();
        Console.Write("Elige el número del libro vendido:");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero < 1 || numero > libros.Count)
        {
            Console.WriteLine("Número incorrecto.\n");
        }

        else
        {
            string libro = libros[numero - 1];
            vendidos.Add(libro);
            libros.RemoveAt(numero - 1);
            categorias.RemoveAt(numero - 1);
            Console.WriteLine("Libro vendido:" + libro + "\n");
        }

    }
}

void RegistrarPrestamo()

{
    if (libros.Count == 0)
    {
        Console.WriteLine("No hay libros disponibles.\n");
    }

    else
    {
        MostrarLibros();
        Console.Write("Elige el número del libro prestado:");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero < 1 || numero > libros.Count)
        {
            Console.WriteLine("Libro prestado: " + libros + "\n.");
        }
    }
}

void RegistrarLectura()
{
    Console.WriteLine("Introduce el título del libro leído o en curso:");
    string libro = Console.ReadLine();

    if (libro == "")
    {
        Console.WriteLine("No se ha introducido ningún título.\n");
    }
    else
    {
        historial.Add(libro);
        Console.WriteLine("Libro añadido al historial.\n");
    }

}

void MostrarHistorial()
{
    Console.WriteLine("Historial personal");

    if (historial.Count == 0)
    {
        Console.WriteLine("No hay libros registrados.\n");
    }

    else
    {
        foreach (string libro in historial)
        {
            Console.WriteLine("-" + libro);
        }
        Console.WriteLine("\nTotal en historial:" + historial.Count + "\n");
    }
}