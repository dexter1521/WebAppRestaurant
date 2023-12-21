using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("usuventas")]
[Index("Usuario", Name = "usuario", IsUnique = true)]
public partial class Usuventa
{
    [Column("USUARIO")]
    [StringLength(10)]
    public string? Usuario { get; set; }

    [Column("PRECIO")]
    public short? Precio { get; set; }

    [Column("ALMACEN")]
    public short? Almacen { get; set; }

    [Column("VENDEDOR")]
    public short? Vendedor { get; set; }

    [Column("DESCUENTO")]
    public short? Descuento { get; set; }

    [Column("EXISTENCIA")]
    public short? Existencia { get; set; }

    public short? AltaClientes { get; set; }

    public short? AltaVendedor { get; set; }

    public short? AltaAlmacen { get; set; }

    public short? AltaMoneda { get; set; }

    public short? AltaArticulo { get; set; }

    public short? CancelarVenta { get; set; }

    public short? CorteX { get; set; }

    public short? CorteZ { get; set; }

    public short? Devolucion { get; set; }

    public short? DevPunto { get; set; }

    public short? CambioPrecios { get; set; }
}
