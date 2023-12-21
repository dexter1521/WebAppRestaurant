using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Table("cobranza")]
[Index("Cliente", Name = "cliente")]
[Index("Cobranza1", Name = "cobranza", IsUnique = true)]
[Index("Fecha", Name = "fecha")]
[Index("FechaVenc", Name = "fecha_venc")]
[Index("NoReferen", Name = "no_referen")]
[Index("TipoDoc", Name = "tipo_doc")]
[Index("Venta", Name = "venta")]
public partial class Cobranza
{
    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("COBRANZA")]
    public int Cobranza1 { get; set; }

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
    public int? NoReferen { get; set; }

    [Column("FECHA_VENC", TypeName = "datetime")]
    public DateTime? FechaVenc { get; set; }

    [Column("IMPORTE")]
    public double? Importe { get; set; }

    [Column("MONEDA")]
    [StringLength(5)]
    public string? Moneda { get; set; }

    [Column("SALDO")]
    public double? Saldo { get; set; }

    [Column("TIP_CAM")]
    public double? TipCam { get; set; }

    [Column("VENTA")]
    public int? Venta { get; set; }

    [Column("COBRADOR")]
    [StringLength(5)]
    public string? Cobrador { get; set; }

    [Column("ESTADO")]
    [StringLength(1)]
    public string? Estado { get; set; }

    [Column("OBSERV")]
    [StringLength(255)]
    public string? Observ { get; set; }

    [Column("CONTAB")]
    public short? Contab { get; set; }

    [Column("USUARIO")]
    [StringLength(10)]
    public string? Usuario { get; set; }

    [Column("USUFECHA", TypeName = "datetime")]
    public DateTime? Usufecha { get; set; }

    [Column("USUHORA")]
    [StringLength(8)]
    public string? Usuhora { get; set; }

    [StringLength(15)]
    public string? Leyenda { get; set; }

    [Column("SSMA_TimeStamp")]
    public byte[] SsmaTimeStamp { get; set; } = null!;

    [InverseProperty("CobranzaNavigation")]
    public virtual ICollection<Cobdet> Cobdets { get; set; } = new List<Cobdet>();

    [ForeignKey("Venta")]
    [InverseProperty("Cobranzas")]
    public virtual Venta? VentaNavigation { get; set; }
}
