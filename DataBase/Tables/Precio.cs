using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("precios")]
[Index("Articulo", Name = "articulo", IsUnique = true)]
public partial class Precio
{
    [StringLength(30)]
    public string? Articulo { get; set; }

    public double? Cantidad1 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Vigencia1 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Vigencia2 { get; set; }

    public double? Cantidad2 { get; set; }

    public double? Utilidad { get; set; }

    public int? Numero { get; set; }

    public short? SoloVigen { get; set; }

    [Column("Precio")]
    public double? Precio1 { get; set; }

    [Column("SSMA_TimeStamp")]
    public byte[] SsmaTimeStamp { get; set; } = null!;
}
