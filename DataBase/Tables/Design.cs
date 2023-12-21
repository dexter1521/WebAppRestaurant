using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("design")]
[Index("Formato", Name = "formato", IsUnique = true)]
public partial class Design
{
    [StringLength(20)]
    public string? Formato { get; set; }

    public string? Codigo { get; set; }

    [Column("imagen")]
    [StringLength(250)]
    public string? Imagen { get; set; }

    [Column("ancho")]
    public double? Ancho { get; set; }

    [Column("alto")]
    public double? Alto { get; set; }

    [Column("SSMA_TimeStamp")]
    public byte[] SsmaTimeStamp { get; set; } = null!;
}
