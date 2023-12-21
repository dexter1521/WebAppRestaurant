using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("modelos")]
[Index("Modelo1", Name = "modelo", IsUnique = true)]
public partial class Modelo
{
    [Column("modelo")]
    [StringLength(9)]
    public string? Modelo1 { get; set; }

    [Column("descrip")]
    [StringLength(100)]
    public string? Descrip { get; set; }

    [Column("precio1")]
    public double? Precio1 { get; set; }

    [Column("precio2")]
    public double? Precio2 { get; set; }

    [Column("precio3")]
    public double? Precio3 { get; set; }

    [Column("matriz")]
    [StringLength(255)]
    public string? Matriz { get; set; }

    [Column("foto")]
    [StringLength(100)]
    public string? Foto { get; set; }

    [Column("usuario")]
    [StringLength(8)]
    public string? Usuario { get; set; }

    [Column("usufecha", TypeName = "datetime")]
    public DateTime? Usufecha { get; set; }

    [Column("usuhora")]
    [StringLength(8)]
    public string? Usuhora { get; set; }

    [Column("u_costo")]
    public double? UCosto { get; set; }

    [Column("marca")]
    [StringLength(5)]
    public string? Marca { get; set; }

    [Column("SSMA_TimeStamp")]
    public byte[] SsmaTimeStamp { get; set; } = null!;
}
