using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("etapas")]
[Index("Etapa1", Name = "etapa", IsUnique = true)]
public partial class Etapa
{
    [Column("Etapa")]
    [StringLength(5)]
    public string? Etapa1 { get; set; }

    [StringLength(40)]
    public string? Descrip { get; set; }

    [Column("usuario")]
    [StringLength(10)]
    public string? Usuario { get; set; }

    [Column("usufecha", TypeName = "datetime")]
    public DateTime? Usufecha { get; set; }

    [Column("usuhora")]
    [StringLength(8)]
    public string? Usuhora { get; set; }

    [Column("costo")]
    public double? Costo { get; set; }

    [Column("terminal")]
    public short? Terminal { get; set; }

    [Column("SSMA_TimeStamp")]
    public byte[] SsmaTimeStamp { get; set; } = null!;
}
