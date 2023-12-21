using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("conteos")]
[Index("Codigo", Name = "codigo")]
public partial class Conteo
{
    [Column("cantidad")]
    public double? Cantidad { get; set; }

    [Column("codigo")]
    [StringLength(30)]
    public string? Codigo { get; set; }

    [Column("conteo")]
    public int? Conteo1 { get; set; }

    [Column("usuario")]
    [StringLength(10)]
    public string? Usuario { get; set; }

    [Column("usufecha")]
    [StringLength(8)]
    public string? Usufecha { get; set; }

    [Column("usuhora")]
    [StringLength(8)]
    public string? Usuhora { get; set; }

    [Column("SSMA_TimeStamp")]
    public byte[] SsmaTimeStamp { get; set; } = null!;
}
