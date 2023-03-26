using System;
using System.Collections.Generic;

namespace semana8.Models;

public partial class Contadurium
{
    public int IdContaduria { get; set; }

    public decimal? Ingresos { get; set; }

    public decimal? Egresos { get; set; }

    public DateTime Fecha { get; set; }

    public string Clase { get; set; } = null!;
}
