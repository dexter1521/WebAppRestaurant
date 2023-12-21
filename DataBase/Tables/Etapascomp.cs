using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("etapascomp")]
[Index("Articulo", Name = "articulo")]
[Index("Id", Name = "id", IsUnique = true)]
public partial class Etapascomp
{
    [Column("id")]
    public int? Id { get; set; }

    [Column("articulo")]
    [StringLength(30)]
    public string? Articulo { get; set; }

    [Column("etapa")]
    [StringLength(5)]
    public string? Etapa { get; set; }

    [Column("etiquetas")]
    public int? Etiquetas { get; set; }

    [Column("nombre")]
    [StringLength(40)]
    public string? Nombre { get; set; }

    [Column("costo")]
    public double? Costo { get; set; }

    [Column("manoobra")]
    public double? Manoobra { get; set; }

    [Column("SSMA_TimeStamp")]
    public byte[] SsmaTimeStamp { get; set; } = null!;
}
