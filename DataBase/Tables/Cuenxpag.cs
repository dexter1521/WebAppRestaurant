using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Table("cuenxpag")]
[Index("Compra", Name = "compra")]
[Index("Cuenxpag1", Name = "cuenxpag", IsUnique = true)]
[Index("Fecha", Name = "fecha")]
[Index("NoReferen", Name = "no_referen")]
[Index("Orden", Name = "orden")]
[Index("Proveedor", Name = "proveedor")]
[Index("TipoDoc", Name = "tipo_doc")]
public partial class Cuenxpag
{
    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("CUENXPAG")]
    public int Cuenxpag1 { get; set; }

    [Column("PROVEEDOR")]
    [StringLength(10)]
    public string? Proveedor { get; set; }

    [Column("FECHA", TypeName = "datetime")]
    public DateTime? Fecha { get; set; }

    [Column("TIPO_DOC")]
    [StringLength(3)]
    public string? TipoDoc { get; set; }

    [Column("NO_REFEREN")]
    public int? NoReferen { get; set; }

    [Column("FECHA_VENC", TypeName = "datetime")]
    public DateTime? FechaVenc { get; set; }

    [Column("FACTURA")]
    [StringLength(30)]
    public string? Factura { get; set; }

    [Column("IMPORTE")]
    public double? Importe { get; set; }

    [Column("MONEDA")]
    [StringLength(5)]
    public string? Moneda { get; set; }

    [Column("SALDO")]
    public double? Saldo { get; set; }

    [Column("TIP_CAM")]
    public double? TipCam { get; set; }

    [Column("COMPRA")]
    public int? Compra { get; set; }

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

    [Column("ORDEN")]
    public int? Orden { get; set; }

    [Column("NPAGO")]
    public int? Npago { get; set; }

    [Column("SSMA_TimeStamp")]
    public byte[] SsmaTimeStamp { get; set; } = null!;
}
