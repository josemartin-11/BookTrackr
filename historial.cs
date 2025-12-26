class Historial
{
    private List<string> historial = new List<string>();

    public void AgregarLectura()
    {
        Console.Write("Libro leído o en curso: ");
        string titulo = Console.ReadLine();

        if (titulo != "")
        {
            historial.Add(titulo);
            Console.WriteLine("Libro añadido al historial.\n");
        }
        else
        {
            Console.WriteLine("Título inválido.\n");
        }
    }

    public void MostrarHistorial()
    {
        if (historial.Count == 0)
        {
            Console.WriteLine("Historial vacío.\n");
            return;
        }

        Console.WriteLine("Historial personal:");
        foreach (string libro in historial)
        {
            Console.WriteLine("- " + libro);
        }
        Console.WriteLine();
    }
}
