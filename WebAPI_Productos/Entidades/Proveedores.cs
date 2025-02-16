using System;
using System.Collections.Generic;

namespace WebAPI_Productos;

public partial class Proveedores
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<Productos> Productos { get; set; } = new List<Productos>();
}
