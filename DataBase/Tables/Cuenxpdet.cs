using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Table("cuenxpdet")]
[Index("CargoAb", Name = "cargo_ab")]
[Index("Compra", Name = "compra")]
[Index("Cuenxpag", Name = "cuenxpag")]
[Index("Fecha", Name = "fecha")]
[Index("NoReferen", Name = "no_referen")]
[Index("Orden", Name = "orden")]
[Index("Proveedor", Name = "proveedor")]
[Index("TipoDoc", Name = "tipo_doc")]
public partial class Cuenxpdet
{
    [Key] [Dapper.Contrib.Extensions.Key]
    public int Id { get; set; }

    [Column("CUENXPAG")]
    public int Cuenxpag { get; set; }

    [Column("PROVEEDOR")]
    [StringLength(10)]
    public string? Proveedor { get; set; }

    [Column("FECHA", TypeName = "datetime")]
    public DateTime? Fecha { get; set; }

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

    [Column("COMPRA")]
    public int? Compra { get; set; }

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

    [Column("ORDEN")]
    public int? Orden { get; set; }

    [Column("SSMA_TimeStamp")]
    public byte[] SsmaTimeStamp { get; set; } = null!;
}
