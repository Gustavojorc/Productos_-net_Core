using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WebAPI_Productos.Models;

public partial class Proveedores
{
    public int Id { get; set; }

    public string? Nombre { get; set; }
    [JsonIgnore]
    public virtual ICollection<Productos> Productos { get; set; } = new List<Productos>();
}
