using System;
using System.Collections.Generic;

namespace semana8.Models;

public partial class CategoriaRegistro
{
    public int CodCategoria { get; set; }

    public string? Categoria { get; set; }

    public string ClaseDoc { get; set; } = null!;

    public DateTime? FechaHora { get; set; }

    public string? Actividad { get; set; }
}
