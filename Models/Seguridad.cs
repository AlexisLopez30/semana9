using System;
using System.Collections.Generic;

namespace semana8.Models;

public partial class Seguridad
{
    public int IdSeguridad { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string? Regla { get; set; }

    public string? Identificador { get; set; }
}
