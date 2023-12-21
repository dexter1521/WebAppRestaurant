using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("conegre")]
[Index("Concepto", Name = "concepto", IsUnique = true)]
public partial class Conegre
{
    [Column("CONCEPTO")]
    [StringLength(5)]
    public string? Concepto { get; set; }

    [Column("DESCRIP")]
    [StringLength(50)]
    public string? Descrip { get; set; }

    [Column("PRESUP")]
    public short? Presup { get; set; }

    [Column("SALDO")]
    public double? Saldo { get; set; }

    [Column("USUARIO")]
    [StringLength(10)]
    public string? Usuario { get; set; }

    [Column("USUFECHA", TypeName = "datetime")]
    public DateTime? Usufecha { get; set; }

    [Column("USUHORA")]
    [StringLength(8)]
    public string? Usuhora { get; set; }

    [Column("SSMA_TimeStamp")]
    public byte[] SsmaTimeStamp { get; set; } = null!;
}
