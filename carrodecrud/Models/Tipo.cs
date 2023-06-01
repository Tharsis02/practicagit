using System;
using System.Collections.Generic;

namespace carrodecrud.Models;

public partial class Tipo
{
    public string Tipo1 { get; set; } = null!;

    public string? Descripcion { get; set; }

    public string? Estatus { get; set; }
}
