using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("requisa")]
[Index("Estado", Name = "estado")]
[Index("FEmision", Name = "f_emision")]
[Index("Proveedor", Name = "proveedor")]
[Index("Requisicion", Name = "requisicion", IsUnique = true)]
[Index("Sucursal", Name = "sucursal")]
public partial class Requisa
{
    [Column("requisicion")]
    public int? Requisicion { get; set; }

    [Column("F_EMISION", TypeName = "datetime")]
    public DateTime? FEmision { get; set; }

    [Column("PROVEEDOR")]
    [StringLength(10)]
    public string? Proveedor { get; set; }

    [Column("IMPORTE")]
    public double? Importe { get; set; }

    [Column("DESCUENTO")]
    public double? Descuento { get; set; }

    [Column("IMPUESTO")]
    public double? Impuesto { get; set; }

    [Column("PRECIO")]
    [StringLength(1)]
    public string? Precio { get; set; }

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
    [StringLength(3)]
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

    [Column("ORDPROV")]
    [StringLength(250)]
    public string? Ordprov { get; set; }

    [Column("USUARIO")]
    [StringLength(10)]
    public string? Usuario { get; set; }

    [Column("USUFECHA", TypeName = "datetime")]
    public DateTime? Usufecha { get; set; }

    [Column("USUHORA")]
    [StringLength(8)]
    public string? Usuhora { get; set; }

    [Column("SUCURSAL")]
    [StringLength(20)]
    public string? Sucursal { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Entrega { get; set; }

    [Column("tipo")]
    [StringLength(2)]
    public string? Tipo { get; set; }

    [Column("pedido")]
    public int? Pedido { get; set; }

    [Column("exportado")]
    public short? Exportado { get; set; }

    [Column("SSMA_TimeStamp")]
    public byte[] SsmaTimeStamp { get; set; } = null!;
}
