using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("presup")]
[Index("Abono", Name = "abono")]
[Index("Concepto", Name = "concepto")]
[Index("Presup1", Name = "presup", IsUnique = true)]
[Index("Tipo", Name = "tipo")]
public partial class Presup
{
    [Column("PRESUP")]
    public int? Presup1 { get; set; }

    [Column("ABONO")]
    public int? Abono { get; set; }

    [Column("CONCEPTO")]
    [StringLength(5)]
    public string? Concepto { get; set; }

    [Column("TIPO")]
    [StringLength(50)]
    public string? Tipo { get; set; }

    [Column("IMPORTE")]
    public double? Importe { get; set; }

    [Column("COMPROB")]
    public short? Comprob { get; set; }

    [Column("INGRESO")]
    public short? Ingreso { get; set; }

    [Column("OBSERV")]
    [StringLength(255)]
    public string? Observ { get; set; }

    [Column("FECHA", TypeName = "datetime")]
    public DateTime? Fecha { get; set; }

    [Column("ENTREGADO")]
    [StringLength(10)]
    public string? Entregado { get; set; }

    [Column("USUARIO")]
    [StringLength(10)]
    public string? Usuario { get; set; }

    [Column("USUFECHA", TypeName = "datetime")]
    public DateTime? Usufecha { get; set; }

    [Column("USUHORA")]
    [StringLength(8)]
    public string? Usuhora { get; set; }

    [Column("SALDO")]
    public double? Saldo { get; set; }

    [Column("hora")]
    [StringLength(8)]
    public string? Hora { get; set; }

    public short? Arqueo { get; set; }

    [Column("SSMA_TimeStamp")]
    public byte[] SsmaTimeStamp { get; set; } = null!;
}
