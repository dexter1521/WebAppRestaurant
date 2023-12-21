using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Table("partcomp")]
[Index("Articulo", Name = "articulo")]
[Index("Claveadd", Name = "claveadd")]
[Index("Compra", Name = "compra")]
[Index("IdEntrada", Name = "id_entrada", IsUnique = true)]
public partial class Partcomp
{
    [Column("COMPRA")]
    public int? Compra { get; set; }

    [Column("TIPO_DOC")]
    [StringLength(3)]
    public string? TipoDoc { get; set; }

    [Column("NO_REFEREN")]
    public int? NoReferen { get; set; }

    [Column("ARTICULO")]
    [StringLength(30)]
    public string? Articulo { get; set; }

    [Column("CANTIDAD")]
    public double? Cantidad { get; set; }

    [Column("PRECIO")]
    public double? Precio { get; set; }

    [Column("DESCUENTO")]
    public double? Descuento { get; set; }

    [Column("IMPUESTO")]
    public float? Impuesto { get; set; }

    [Column("OBSERV")]
    [StringLength(255)]
    public string? Observ { get; set; }

    [Column("PARTIDA")]
    public int? Partida { get; set; }

    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("ID_ENTRADA")]
    public int IdEntrada { get; set; }

    [StringLength(10)]
    public string? Usuario { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UsuFecha { get; set; }

    [StringLength(8)]
    public string? UsuHora { get; set; }

    [Column("PRCANTIDAD")]
    public int? Prcantidad { get; set; }

    [Column("PRDESCRIP")]
    [StringLength(40)]
    public string? Prdescrip { get; set; }

    [Column("CLAVEADD")]
    [StringLength(30)]
    public string? Claveadd { get; set; }

    public double? DescuentoAdicional { get; set; }

    [Column("donativo")]
    public double? Donativo { get; set; }

    [Column("costoadic")]
    public double? Costoadic { get; set; }

    [Column("descuento1")]
    public double? Descuento1 { get; set; }

    [Column("descuento2")]
    public double? Descuento2 { get; set; }

    [Column("descuento3")]
    public double? Descuento3 { get; set; }

    [Column("descuento4")]
    public double? Descuento4 { get; set; }

    [Column("descuento5")]
    public double? Descuento5 { get; set; }

    [Column("descuento6")]
    public double? Descuento6 { get; set; }

    [Column("descuento7")]
    public double? Descuento7 { get; set; }

    [Column("descuento8")]
    public double? Descuento8 { get; set; }

    [Column("descuento9")]
    public double? Descuento9 { get; set; }

    [Column("descuento10")]
    public double? Descuento10 { get; set; }

    [Column("piezas")]
    public double? Piezas { get; set; }

    [Column("SSMA_TimeStamp")]
    public byte[] SsmaTimeStamp { get; set; } = null!;
}
