using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Table("formasdelta")]
[Index("Forma", Name = "forma", IsUnique = true)]
public partial class Formasdeltum
{
    [Column("codigo")]
    public string? Codigo { get; set; }

    [Column("descrip")]
    [StringLength(100)]
    public string? Descrip { get; set; }

    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("forma")]
    [StringLength(20)]
    public string Forma { get; set; } = null!;

    [Column("frm")]
    public string? Frm { get; set; }

    [Column("proyecto")]
    public string? Proyecto { get; set; }

    [Column("SSMA_TimeStamp")]
    public byte[] SsmaTimeStamp { get; set; } = null!;
}
