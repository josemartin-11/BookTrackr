class Libro
{
    public int Id { get; set; }
    public string Titulo { get; set; }
    public string Categoria { get; set; }
    public bool Disponible { get; set; }

    public Libro(int id, string titulo, string categoria)
    {
        Id = id;
        Titulo = titulo;
        Categoria = categoria;
        Disponible = true;
    }

    public string MostrarInfo()
    {
        string estado = Disponible ? "Disponible" : "No disponible";
        return Id + " - " + Titulo + " (" + Categoria + ") - " + estado;
    }
}