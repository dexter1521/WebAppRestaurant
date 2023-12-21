using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("formas")]
[Index("Forma1", Name = "forma", IsUnique = true)]
public partial class Forma
{
    [StringLength(100)]
    public string? Descrip { get; set; }

    [Column("Forma")]
    [StringLength(20)]
    public string? Forma1 { get; set; }

    [Column("codigo")]
    public string? Codigo { get; set; }

    [Column("frm")]
    public string? Frm { get; set; }

    [Column("SSMA_TimeStamp")]
    public byte[] SsmaTimeStamp { get; set; } = null!;
}
