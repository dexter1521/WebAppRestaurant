using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("ordauto")]
[Index("Articulo", Name = "articulo", IsUnique = true)]
public partial class Ordauto
{
    [Column("articulo")]
    [StringLength(30)]
    public string? Articulo { get; set; }

    [Column("cantidad")]
    public double? Cantidad { get; set; }

    [Column("usuario")]
    [StringLength(10)]
    public string? Usuario { get; set; }

    [Column("usufecha", TypeName = "datetime")]
    public DateTime? Usufecha { get; set; }

    [Column("usuhora")]
    [StringLength(8)]
    public string? Usuhora { get; set; }

    [Column("proveedor")]
    [StringLength(10)]
    public string? Proveedor { get; set; }

    [Column("cantidad1")]
    public int? Cantidad1 { get; set; }

    [Column("usuario1")]
    [StringLength(10)]
    public string? Usuario1 { get; set; }

    [Column("usufecha1", TypeName = "datetime")]
    public DateTime? Usufecha1 { get; set; }

    [Column("usuhora1")]
    [StringLength(8)]
    public string? Usuhora1 { get; set; }

    [Column("finalizado")]
    public short? Finalizado { get; set; }

    [Column("proveedor1")]
    [StringLength(10)]
    public string? Proveedor1 { get; set; }

    [Column("finalizado1")]
    public short? Finalizado1 { get; set; }

    [Column("SSMA_TimeStamp")]
    public byte[] SsmaTimeStamp { get; set; } = null!;
}
