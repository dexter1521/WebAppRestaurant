using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("articlien")]
[Index("Articulo", Name = "articulo", IsUnique = true)]
[Index("Cliente", Name = "cliente")]
public partial class Articlien
{
    [StringLength(10)]
    public string? Cliente { get; set; }

    [StringLength(30)]
    public string? Articulo { get; set; }

    public double? Precio { get; set; }

    [Column("usuFecha", TypeName = "datetime")]
    public DateTime? UsuFecha { get; set; }

    [Column("usuHora")]
    [StringLength(8)]
    public string? UsuHora { get; set; }

    [StringLength(10)]
    public string? Usuario { get; set; }

    [Column("porlistadeprecios")]
    public short? Porlistadeprecios { get; set; }

    [Column("SSMA_TimeStamp")]
    public byte[] SsmaTimeStamp { get; set; } = null!;
}
