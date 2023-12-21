using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Table("formatosdelta")]
[Index("Catalogo", Name = "catalogo")]
[Index("Formato", Name = "formato", IsUnique = true)]
public partial class Formatosdeltum
{
    [Column("catalogo")]
    [StringLength(20)]
    public string? Catalogo { get; set; }

    [Column("codigo")]
    public string? Codigo { get; set; }

    [Column("descrip")]
    [StringLength(100)]
    public string? Descrip { get; set; }

    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("formato")]
    [StringLength(35)]
    public string Formato { get; set; } = null!;

    [Column("grupo")]
    [StringLength(20)]
    public string? Grupo { get; set; }

    [Column("observ")]
    [StringLength(255)]
    public string? Observ { get; set; }

    [Column("tipo")]
    [StringLength(20)]
    public string? Tipo { get; set; }

    [Column("proyecto")]
    public string? Proyecto { get; set; }

    [Column("usuario")]
    [StringLength(10)]
    public string? Usuario { get; set; }

    [Column("usufecha", TypeName = "datetime")]
    public DateTime? Usufecha { get; set; }

    [Column("usuhora")]
    [StringLength(8)]
    public string? Usuhora { get; set; }

    [Column("SSMA_TimeStamp")]
    public byte[] SsmaTimeStamp { get; set; } = null!;
}
