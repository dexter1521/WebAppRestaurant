using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("componen")]
[Index("Articulo", Name = "articulo", IsUnique = true)]
[Index("Exportado", Name = "exportado")]
public partial class Componen
{
    [StringLength(30)]
    public string? Articulo { get; set; }

    [StringLength(255)]
    public string? Coment { get; set; }

    public double? Minimo { get; set; }

    public double? Existencia { get; set; }

    public short? Exportado { get; set; }

    [Column("SSMA_TimeStamp")]
    public byte[] SsmaTimeStamp { get; set; } = null!;
}
