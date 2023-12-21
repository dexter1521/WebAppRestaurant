using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Table("flujo")]
[Index("Abono", Name = "abono")]
[Index("Cargo", Name = "cargo")]
[Index("Concepto2", Name = "concepto2")]
[Index("Corte", Name = "corte")]
[Index("Flujo1", Name = "flujo", IsUnique = true)]
[Index("IngEg", Name = "ing_eg")]
[Index("Modulo", Name = "modulo")]
[Index("Venta", Name = "venta")]
[Index("Verificado", Name = "verificado")]
public partial class Flujo
{
    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("FLUJO")]
    public int Flujo1 { get; set; }

    [Column("ABONO")]
    public int Abono { get; set; }

    [Column("CONCEPTO")]
    [StringLength(5)]
    public string? Concepto { get; set; }

    [Column("ING_EG")]
    [StringLength(1)]
    public string? IngEg { get; set; }

    [Column("IMPORTE")]
    public double Importe { get; set; }

    [Column("FECHA", TypeName = "datetime")]
    public DateTime? Fecha { get; set; }

    [Column("HORA")]
    [StringLength(8)]
    public string? Hora { get; set; }

    [Column("MONEDA")]
    [StringLength(5)]
    public string? Moneda { get; set; }

    [Column("ESTACION")]
    [StringLength(10)]
    public string? Estacion { get; set; }

    [Column("USUARIO")]
    [StringLength(10)]
    public string? Usuario { get; set; }

    [Column("USUFECHA", TypeName = "datetime")]
    public DateTime? Usufecha { get; set; }

    [Column("USUHORA")]
    [StringLength(8)]
    public string? Usuhora { get; set; }

    [StringLength(3)]
    public string? Modulo { get; set; }

    public int Venta { get; set; }

    public short Corte { get; set; }

    [Column("cierretienda")]
    public short Cierretienda { get; set; }

    [Column("tipo_cam")]
    public double TipoCam { get; set; }

    public int Cargo { get; set; }

    [Column("concepto2")]
    [StringLength(5)]
    public string? Concepto2 { get; set; }

    [Column("banco")]
    [StringLength(30)]
    public string? Banco { get; set; }

    [Column("cheque")]
    [StringLength(40)]
    public string? Cheque { get; set; }

    [Column("verificado")]
    public short Verificado { get; set; }

    [Column("id_cobdet")]
    public int? IdCobdet { get; set; }

    [Column("observaciones")]
    public string? Observaciones { get; set; }

    public int? NumeroCorte { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? FechaCorte { get; set; }

    [Column("SSMA_TimeStamp")]
    public byte[] SsmaTimeStamp { get; set; } = null!;
}
