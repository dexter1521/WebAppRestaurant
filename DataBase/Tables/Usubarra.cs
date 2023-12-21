using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("usubarra")]
[Index("Usuario", Name = "usuario", IsUnique = true)]
public partial class Usubarra
{
    [Column("USUARIO")]
    [StringLength(10)]
    public string? Usuario { get; set; }

    [Column("BUSINESSM")]
    public short? Businessm { get; set; }

    [Column("VENTA")]
    public short? Venta { get; set; }

    [Column("COTIZA")]
    public short? Cotiza { get; set; }

    [Column("CLIENTE")]
    public short? Cliente { get; set; }

    [Column("PRODUCTO")]
    public short? Producto { get; set; }

    [Column("BUSCAR")]
    public short? Buscar { get; set; }

    [Column("PROVEEDOR")]
    public short? Proveedor { get; set; }

    [Column("PAGO")]
    public short? Pago { get; set; }

    [Column("COMPRAS")]
    public short? Compras { get; set; }

    [Column("ORDEN")]
    public short? Orden { get; set; }

    [Column("CALC")]
    public short? Calc { get; set; }

    public short? Graficos { get; set; }

    public short? Cobro { get; set; }
}
