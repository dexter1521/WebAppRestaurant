using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Table("pagos")]
[Index("Abono", Name = "abono", IsUnique = true)]
[Index("Autorizado", Name = "autorizado")]
[Index("Concepto", Name = "concepto")]
[Index("FechaDep", Name = "fecha_dep")]
[Index("Moneda", Name = "moneda")]
[Index("NoReferen", Name = "no_referen")]
[Index("PorApli", Name = "por_apli")]
[Index("Proveedor", Name = "proveedor")]
[Index("TipoDoc", Name = "tipo_doc")]
public partial class Pago
{
    [Key] [Dapper.Contrib.Extensions.Key]
    public int Abono { get; set; }

    [StringLength(10)]
    public string? Proveedor { get; set; }

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

    public short? Cobrar { get; set; }

    [StringLength(10)]
    public string? Banco { get; set; }

    [Column("Fecha_dep", TypeName = "datetime")]
    public DateTime? FechaDep { get; set; }

    public short? Autorizado { get; set; }

    [Column("Por_apli")]
    public double? PorApli { get; set; }

    public short? Aplicado { get; set; }

    [StringLength(255)]
    public string? Observ { get; set; }

    [StringLength(5)]
    public string? Concepto { get; set; }

    [StringLength(10)]
    public string? Usuario { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UsuFecha { get; set; }

    [StringLength(8)]
    public string? UsuHora { get; set; }

    [Column("SSMA_TimeStamp")]
    public byte[] SsmaTimeStamp { get; set; } = null!;
}
