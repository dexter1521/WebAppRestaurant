using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("vales")]
[Index("Cliente", Name = "cliente")]
[Index("Corte", Name = "corte")]
[Index("Estacion", Name = "estacion")]
[Index("Vale1", Name = "vale", IsUnique = true)]
public partial class Vale
{
    [Column("Vale")]
    public int? Vale1 { get; set; }

    [Column("devolucion")]
    public int? Devolucion { get; set; }

    [Column("texto")]
    public string? Texto { get; set; }

    [Column("pagado")]
    public short? Pagado { get; set; }

    [Column("importe")]
    public double? Importe { get; set; }

    [Column("corte")]
    public short? Corte { get; set; }

    [Column("incluirencorte")]
    public short? Incluirencorte { get; set; }

    [Column("estacion")]
    [StringLength(10)]
    public string? Estacion { get; set; }

    [Column("fecha", TypeName = "datetime")]
    public DateTime? Fecha { get; set; }

    [Column("cliente")]
    [StringLength(30)]
    public string? Cliente { get; set; }

    [Column("SSMA_TimeStamp")]
    public byte[] SsmaTimeStamp { get; set; } = null!;
}
