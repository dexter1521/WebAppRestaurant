using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("defform")]
public partial class Defform
{
    [Column("FACTURAS")]
    [StringLength(20)]
    public string? Facturas { get; set; }

    [Column("REMISIONES")]
    [StringLength(20)]
    public string? Remisiones { get; set; }

    [Column("VENTAS")]
    [StringLength(20)]
    public string? Ventas { get; set; }

    [Column("DEVOLUC")]
    [StringLength(20)]
    public string? Devoluc { get; set; }

    [Column("COMPRAS")]
    [StringLength(20)]
    public string? Compras { get; set; }

    [Column("DEVCOMP")]
    [StringLength(20)]
    public string? Devcomp { get; set; }

    [Column("SALIDAS")]
    [StringLength(20)]
    public string? Salidas { get; set; }

    [Column("ENTRADAS")]
    [StringLength(20)]
    public string? Entradas { get; set; }

    [Column("PEDIDOS")]
    [StringLength(20)]
    public string? Pedidos { get; set; }

    [Column("COTIZA")]
    [StringLength(20)]
    public string? Cotiza { get; set; }

    [Column("ORDEN")]
    [StringLength(20)]
    public string? Orden { get; set; }

    [Column("TICKET")]
    [StringLength(20)]
    public string? Ticket { get; set; }
}
