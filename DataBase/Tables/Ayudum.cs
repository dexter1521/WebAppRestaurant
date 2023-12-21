using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("ayuda")]
[Index("Control", Name = "control", IsUnique = true)]
[Index("Forma", Name = "forma", IsUnique = true)]
public partial class Ayudum
{
    [Column("forma")]
    [StringLength(20)]
    public string? Forma { get; set; }

    [Column("control")]
    [StringLength(20)]
    public string? Control { get; set; }

    [Column("htmltema")]
    public string? Htmltema { get; set; }

    [Column("ancho")]
    public int? Ancho { get; set; }

    [Column("alto")]
    public int? Alto { get; set; }

    [Column("izquierda")]
    public int? Izquierda { get; set; }

    [Column("superior")]
    public int? Superior { get; set; }

    [Column("SSMA_TimeStamp")]
    public byte[] SsmaTimeStamp { get; set; } = null!;
}
