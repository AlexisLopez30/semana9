using System;
using System.Collections.Generic;

namespace semana8.Models;

public partial class Empleado
{
    public int IdEmpleado { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public int NDoc { get; set; }

    public string? Estado { get; set; }
}
