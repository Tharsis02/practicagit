using System;
using System.Collections.Generic;

namespace carrodecrud.Models;

public partial class Colore
{
    public string Color { get; set; } = null!;

    public string? Descripcion { get; set; }

    public string? Estatus { get; set; }
}
