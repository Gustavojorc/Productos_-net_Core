using System;
using System.Collections.Generic;

namespace WebAPI_Productos;

public partial class Productos
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public decimal Precio { get; set; }

    public int? Idtipo { get; set; }

    public int? Idproveedores { get; set; }

    public virtual Proveedores? IdproveedoresNavigation { get; set; }

    public virtual TipoProducto? IdtipoNavigation { get; set; }
}
