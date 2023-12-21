using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("invinicial")]
[Index("Articulo", "Fecha", Name = "articulo", IsUnique = true)]
public partial class Invinicial
{
    [Column("fecha", TypeName = "datetime")]
    public DateTime? Fecha { get; set; }

    [Column("fechainicial", TypeName = "datetime")]
    public DateTime? Fechainicial { get; set; }

    [Column("articulo")]
    [StringLength(30)]
    public string? Articulo { get; set; }

    [Column("existencia")]
    public double? Existencia { get; set; }

    [Column("costo")]
    public double? Costo { get; set; }

    [Column("SSMA_TimeStamp")]
    public byte[] SsmaTimeStamp { get; set; } = null!;
}
