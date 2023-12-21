using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Table("caja")]
[Index("Abono", Name = "abono", IsUnique = true)]
[Index("Aplicado", Name = "aplicado")]
[Index("Cliente", Name = "cliente")]
[Index("Cobrador", Name = "cobrador")]
[Index("Concepto", Name = "concepto")]
[Index("Depositado", Name = "depositado")]
[Index("FechaDep", Name = "fecha_dep")]
[Index("Moneda", Name = "moneda")]
[Index("NoReferen", Name = "no_referen")]
[Index("PorApli", Name = "por_apli")]
[Index("TipoDoc", Name = "tipo_doc")]
public partial class Caja
{
    [Key] [Dapper.Contrib.Extensions.Key]
    public int Abono { get; set; }

    [Column("CLIENTE")]
    [StringLength(30)]
    public string? Cliente { get; set; }

    [Column("serieDocumento")]
    [StringLength(20)]
    public string? SerieDocumento { get; set; }

    [Column("Tipo_doc")]
    [StringLength(3)]
    public string? TipoDoc { get; set; }

    [Column("No_referen")]
    [StringLength(50)]
    public string? NoReferen { get; set; }

    public double? Importe { get; set; }

    [StringLength(5)]
    public string? Moneda { get; set; }

    [Column("TC")]
    public double? Tc { get; set; }

    public double? ImportBase { get; set; }

    [Column("Fecha_dep", TypeName = "datetime")]
    public DateTime? FechaDep { get; set; }

    public short? Depositado { get; set; }

    [Column("Por_apli")]
    public double PorApli { get; set; }

    public string? Observ { get; set; }

    [StringLength(5)]
    public string? Cobrador { get; set; }

    public double? Pago { get; set; }

    [StringLength(5)]
    public string? Concepto { get; set; }

    public short Aplicado { get; set; }

    [StringLength(10)]
    public string? Usuario { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UsuFecha { get; set; }

    [StringLength(8)]
    public string? UsuHora { get; set; }

    [Column("SSMA_TimeStamp")]
    public byte[] SsmaTimeStamp { get; set; } = null!;
}
