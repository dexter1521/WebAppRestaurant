using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("ordserv")]
[Index("Id", Name = "id", IsUnique = true)]
public partial class Ordserv
{
    [Column("id")]
    public int? Id { get; set; }

    [Column("orden")]
    public int? Orden { get; set; }

    [Column("equipo")]
    [StringLength(40)]
    public string? Equipo { get; set; }

    [Column("cliente")]
    [StringLength(20)]
    public string? Cliente { get; set; }

    [Column("serie")]
    [StringLength(30)]
    public string? Serie { get; set; }

    [Column("motivo")]
    [StringLength(20)]
    public string? Motivo { get; set; }

    [Column("condicion")]
    public string? Condicion { get; set; }

    [Column("problema")]
    [StringLength(100)]
    public string? Problema { get; set; }

    [Column("estatus")]
    public short? Estatus { get; set; }

    [Column("fecha", TypeName = "datetime")]
    public DateTime? Fecha { get; set; }

    [Column("usuario")]
    [StringLength(10)]
    public string? Usuario { get; set; }

    [Column("usufecha", TypeName = "datetime")]
    public DateTime? Usufecha { get; set; }

    [Column("usuhora")]
    [StringLength(10)]
    public string? Usuhora { get; set; }

    [Column("SSMA_TimeStamp")]
    public byte[] SsmaTimeStamp { get; set; } = null!;
}
