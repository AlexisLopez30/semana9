using System;
using System.Collections.Generic;

namespace semana8.Models;

public partial class Registro
{
    public int IdRegistro { get; set; }

    public int NEmpleado { get; set; }

    public string TipoCategoria { get; set; } = null!;

    public string ClaseDoc { get; set; } = null!;

    public DateTime? Fecha { get; set; }
}
