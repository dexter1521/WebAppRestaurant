using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("impuestos")]
[Index("Impuesto1", Name = "impuesto", IsUnique = true)]
public partial class Impuesto
{
    [Column("Impuesto")]
    [StringLength(5)]
    public string? Impuesto1 { get; set; }

    [StringLength(40)]
    public string? Descrip { get; set; }

    public float? Valor { get; set; }

    [StringLength(10)]
    public string? Usuario { get; set; }

    [Column("usuFecha", TypeName = "datetime")]
    public DateTime? UsuFecha { get; set; }

    [Column("usuHora")]
    [StringLength(8)]
    public string? UsuHora { get; set; }

    [Column("componente1")]
    public double? Componente1 { get; set; }

    [Column("componente2")]
    public double? Componente2 { get; set; }

    [Column("componente3")]
    public double? Componente3 { get; set; }

    [Column("componente4")]
    public double? Componente4 { get; set; }

    [Column("componente5")]
    public double? Componente5 { get; set; }

    [Column("SSMA_TimeStamp")]
    public byte[] SsmaTimeStamp { get; set; } = null!;
}
