using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Table("cobdet")]
[Index("Abono", Name = "abono")]
[Index("CargoAb", Name = "cargo_ab")]
[Index("Cliente", Name = "cliente")]
[Index("Cobranza", Name = "cobranza")]
[Index("Fecha", Name = "fecha")]
[Index("Id", Name = "id", IsUnique = true)]
[Index("NoReferen", Name = "no_referen")]
[Index("TipoDoc", Name = "tipo_doc")]
[Index("Venta", Name = "venta")]
public partial class Cobdet
{
    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("COBRANZA")]
    public int? Cobranza { get; set; }

    [Column("CLIENTE")]
    [StringLength(30)]
    public string? Cliente { get; set; }

    [Column("FECHA", TypeName = "datetime")]
    public DateTime? Fecha { get; set; }

    [Column("serieDocumento")]
    [StringLength(20)]
    public string? SerieDocumento { get; set; }

    [Column("TIPO_DOC")]
    [StringLength(3)]
    public string? TipoDoc { get; set; }

    [Column("NO_REFEREN")]
    [StringLength(50)]
    public string? NoReferen { get; set; }

    [Column("Cargo_ab")]
    [StringLength(1)]
    public string? CargoAb { get; set; }

    [Column("IMPORTE")]
    public double? Importe { get; set; }

    [Column("MONEDA")]
    [StringLength(5)]
    public string? Moneda { get; set; }

    [Column("TIP_CAM")]
    public double? TipCam { get; set; }

    [Column("VENTA")]
    public int? Venta { get; set; }

    [Column("COBRADOR")]
    [StringLength(5)]
    public string? Cobrador { get; set; }

    [Column("OBSERV")]
    [StringLength(255)]
    public string? Observ { get; set; }

    [Column("CONTAB")]
    public short? Contab { get; set; }

    [Column("ABONO")]
    public int? Abono { get; set; }

    [Column("USUARIO")]
    [StringLength(10)]
    public string? Usuario { get; set; }

    [Column("USUFECHA", TypeName = "datetime")]
    public DateTime? Usufecha { get; set; }

    [Column("USUHORA")]
    [StringLength(8)]
    public string? Usuhora { get; set; }

    [Column("concepto")]
    [StringLength(5)]
    public string? Concepto { get; set; }

    [Column("SSMA_TimeStamp")]
    public byte[] SsmaTimeStamp { get; set; } = null!;

    [ForeignKey("Cobranza")]
    [InverseProperty("Cobdets")]
    public virtual Cobranza? CobranzaNavigation { get; set; }
}
