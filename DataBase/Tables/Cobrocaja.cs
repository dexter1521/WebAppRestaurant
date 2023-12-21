using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("cobrocaja")]
[Index("Id", Name = "id", IsUnique = true)]
[Index("Operacion", Name = "operacion")]
public partial class Cobrocaja
{
    [Column("banco")]
    [StringLength(30)]
    public string? Banco { get; set; }

    [Column("cheque")]
    [StringLength(40)]
    public string? Cheque { get; set; }

    [Column("concepto1")]
    [StringLength(3)]
    public string? Concepto1 { get; set; }

    [Column("concepto2")]
    [StringLength(3)]
    public string? Concepto2 { get; set; }

    [Column("concepto3")]
    [StringLength(3)]
    public string? Concepto3 { get; set; }

    [Column("departamento")]
    [StringLength(20)]
    public string? Departamento { get; set; }

    [Column("id")]
    public int? Id { get; set; }

    [Column("importe")]
    public double? Importe { get; set; }

    [Column("operacion")]
    public int? Operacion { get; set; }

    [Column("pago1")]
    public double? Pago1 { get; set; }

    [Column("pago2")]
    public double? Pago2 { get; set; }

    [Column("pago3")]
    public double? Pago3 { get; set; }

    [Column("usuario")]
    [StringLength(10)]
    public string? Usuario { get; set; }

    [Column("usufecha", TypeName = "datetime")]
    public DateTime? Usufecha { get; set; }

    [Column("usuhora")]
    [StringLength(8)]
    public string? Usuhora { get; set; }

    [Column("venta")]
    public int? Venta { get; set; }

    [Column("SSMA_TimeStamp")]
    public byte[] SsmaTimeStamp { get; set; } = null!;
}
