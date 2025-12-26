class Catalogo
{
    private Dictionary<int, Libro> catalogo = new Dictionary<int, Libro>();
    private Dictionary<int, Libro> vendidos = new Dictionary<int, Libro>();
    private Dictionary<int, Libro> prestados = new Dictionary<int, Libro>();

    private int siguienteId = 1;

    // Agregar libro al catálogo
    public void AgregarLibro()
    {
        Console.Write("Título: ");
        string titulo = Console.ReadLine();

        Console.Write("Categoría: ");
        string categoria = Console.ReadLine();

        if (titulo != "" && categoria != "")
        {
            Libro libro = new Libro(siguienteId, titulo, categoria);
            catalogo.Add(siguienteId, libro);
            siguienteId++;

            Console.WriteLine("Libro añadido correctamente.\n");
        }
        else
        {
            Console.WriteLine("Datos inválidos.\n");
        }
    }

    // Mostrar libros
    public void MostrarCatalogo()
    {
        if (catalogo.Count == 0)
        {
            Console.WriteLine("No hay libros en el catálogo.\n");
            return;
        }

        foreach (Libro libro in catalogo.Values)
        {
            Console.WriteLine(libro.MostrarInfo());
        }
        Console.WriteLine();
    }

    // Registrar venta
    public void RegistrarVenta()
    {
        MostrarCatalogo();
        int id = PedirNumero("ID del libro vendido: ");

        if (catalogo.ContainsKey(id))
        {
            vendidos.Add(id, catalogo[id]);
            catalogo.Remove(id);
            Console.WriteLine("Venta registrada.\n");
        }
        else
        {
            Console.WriteLine("ID no válido.\n");
        }
    }

    // Registrar préstamo
    public void RegistrarPrestamo()
    {
        MostrarCatalogo();
        int id = PedirNumero("ID del libro prestado: ");

        if (catalogo.ContainsKey(id))
        {
            Libro libro = catalogo[id];
            libro.Disponible = false;

            prestados.Add(id, libro);
            catalogo.Remove(id);

            Console.WriteLine("Préstamo registrado.\n");
        }
        else
        {
            Console.WriteLine("ID no válido.\n");
        }
    }

    // Método reutilizable
    private int PedirNumero(string mensaje)
    {
        Console.Write(mensaje);
        return Convert.ToInt32(Console.ReadLine());
    }

    // Carga inicial
    public void CargarLibroInicial(string titulo, string categoria)
    {
        Libro libro = new Libro(siguienteId, titulo, categoria);
        catalogo.Add(siguienteId, libro);
        siguienteId++;
    }
}