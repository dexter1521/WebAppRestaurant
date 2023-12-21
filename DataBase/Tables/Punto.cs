using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("puntos")]
public partial class Punto
{
    [Column("articulo")]
    [StringLength(30)]
    public string? Articulo { get; set; }

    [Column("cantidad")]
    public double? Cantidad { get; set; }

    [Column("ent_sal")]
    [StringLength(1)]
    public string? EntSal { get; set; }

    [Column("id_salida")]
    public int? IdSalida { get; set; }

    [Column("no_referen")]
    public int? NoReferen { get; set; }

    [Column("puntos")]
    public int? Puntos { get; set; }

    [Column("tipo_doc")]
    [StringLength(3)]
    public string? TipoDoc { get; set; }

    [Column("usufecha", TypeName = "datetime")]
    public DateTime? Usufecha { get; set; }

    [Column("venta")]
    public int? Venta { get; set; }

    [Column("SSMA_TimeStamp")]
    public byte[] SsmaTimeStamp { get; set; } = null!;
}
