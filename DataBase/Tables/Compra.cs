using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Table("compras")]
[Index("Cuenxpag", Name = "cuenxpag")]
[Index("DeCompra", Name = "decompra")]
[Index("Estado", Name = "estado")]
[Index("FEmision", Name = "f_emision")]
[Index("NoReferen", Name = "no_referen")]
[Index("Ocupado", Name = "ocupado")]
[Index("Proveedor", Name = "proveedor")]
[Index("TipoDoc", Name = "tipo_doc")]
public partial class Compra
{
    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("COMPRA")]
    public int Compra1 { get; set; }

    [Column("OCUPADO")]
    public short? Ocupado { get; set; }

    [Column("TIPO_DOC")]
    [StringLength(3)]
    public string? TipoDoc { get; set; }

    [Column("FACTURA")]
    [StringLength(30)]
    public string? Factura { get; set; }

    [Column("F_EMISION", TypeName = "datetime")]
    public DateTime? FEmision { get; set; }

    [Column("hora")]
    [StringLength(8)]
    public string? Hora { get; set; }

    [Column("F_VENC", TypeName = "datetime")]
    public DateTime? FVenc { get; set; }

    [Column("PROVEEDOR")]
    [StringLength(10)]
    public string? Proveedor { get; set; }

    [Column("IMPORTE")]
    public double? Importe { get; set; }

    [Column("DESCUENTO")]
    public double? Descuento { get; set; }

    [Column("IMPUESTO")]
    public double? Impuesto { get; set; }

    [Column("COSTO")]
    public double? Costo { get; set; }

    [Column("ALMACEN")]
    public short? Almacen { get; set; }

    [Column("ESTADO")]
    [StringLength(2)]
    public string? Estado { get; set; }

    [Column("OBSERV")]
    [StringLength(255)]
    public string? Observ { get; set; }

    [Column("TIPO_CAM")]
    public double? TipoCam { get; set; }

    [Column("MONEDA")]
    [StringLength(5)]
    public string? Moneda { get; set; }

    [Column("DESC1")]
    public double? Desc1 { get; set; }

    [Column("DESC2")]
    public double? Desc2 { get; set; }

    [Column("DESC3")]
    public double? Desc3 { get; set; }

    [Column("DESC4")]
    public double? Desc4 { get; set; }

    [Column("DESC5")]
    public double? Desc5 { get; set; }

    [Column("DATOS")]
    [StringLength(255)]
    public string? Datos { get; set; }

    [Column("DESGLOSE")]
    public short? Desglose { get; set; }

    [Column("CUENXPAG")]
    public int? Cuenxpag { get; set; }

    [Column("USUARIO")]
    [StringLength(10)]
    public string? Usuario { get; set; }

    [Column("USUFECHA", TypeName = "datetime")]
    public DateTime? Usufecha { get; set; }

    [Column("USUHORA")]
    [StringLength(8)]
    public string? Usuhora { get; set; }

    public short? Exportado { get; set; }

    [Column("No_referen")]
    public int? NoReferen { get; set; }

    [Column("vencimiento", TypeName = "datetime")]
    public DateTime? Vencimiento { get; set; }

    public int? DeCompra { get; set; }

    [Column("donativo")]
    public double? Donativo { get; set; }

    [Column("porcentajederetencion", TypeName = "smallmoney")]
    public decimal Porcentajederetencion { get; set; }

    [Column("retencion", TypeName = "smallmoney")]
    public decimal Retencion { get; set; }

    [Column("pedimentos")]
    public string? Pedimentos { get; set; }

    [Column("compraconfirmada")]
    public int? Compraconfirmada { get; set; }

    [Column("SSMA_TimeStamp")]
    public byte[] SsmaTimeStamp { get; set; } = null!;
}
