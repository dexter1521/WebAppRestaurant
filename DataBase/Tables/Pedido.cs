using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Table("pedidos")]
[Index("Tipo", "NoPed", Name = "IX_cotiza", IsUnique = true)]
[Index("Pedido1", Name = "cotizacion", IsUnique = true)]
[Index("Sucremota", Name = "sucremota")]
public partial class Pedido
{
    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("pedido")]
    public int Pedido1 { get; set; }

    [Column("F_EMISION", TypeName = "datetime")]
    public DateTime? FEmision { get; set; }

    [Column("CLIENTE")]
    [StringLength(30)]
    public string? Cliente { get; set; }

    [Column("VEND")]
    [StringLength(15)]
    public string? Vend { get; set; }

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
    public int? Almacen { get; set; }

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
    [Unicode(false)]
    public string? Datos { get; set; }

    [Column("DESGLOSE")]
    public short? Desglose { get; set; }

    [Column("COBRANZA")]
    public int? Cobranza { get; set; }

    [Column("USUARIO")]
    [StringLength(10)]
    public string? Usuario { get; set; }

    [Column("USUFECHA", TypeName = "datetime")]
    public DateTime? Usufecha { get; set; }

    [Column("USUHORA")]
    [StringLength(8)]
    public string? Usuhora { get; set; }

    [Column("RELACION")]
    [StringLength(10)]
    public string? Relacion { get; set; }

    [Column("PEDCLI")]
    [StringLength(40)]
    public string? Pedcli { get; set; }

    public short? AplicarDes { get; set; }

    public short? Autorizado { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Entrega { get; set; }

    [StringLength(2)]
    public string? Tipo { get; set; }

    [Column("no_ped")]
    public int? NoPed { get; set; }

    [Column("sucremota")]
    [StringLength(20)]
    public string? Sucremota { get; set; }

    [Column("cotizaremota")]
    public int? Cotizaremota { get; set; }

    [Column("auto")]
    public short? Auto { get; set; }

    [Column("donativo")]
    public short? Donativo { get; set; }

    [Column("SSMA_TimeStamp")]
    public byte[] SsmaTimeStamp { get; set; } = null!;

    [Column("ocupado")]
    public short Ocupado { get; set; }
}
