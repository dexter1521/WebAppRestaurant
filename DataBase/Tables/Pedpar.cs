using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Table("pedpar")]
[Index("Articulo", Name = "articulo")]
[Index("Clave", Name = "clave")]
[Index("Pedido", Name = "cotizacion")]
[Index("IdSalida", Name = "id_salida", IsUnique = true)]
[Index("PorSurt", Name = "por_surt")]
public partial class Pedpar
{
    [Column("pedido")]
    public int? Pedido { get; set; }

    [Column("ARTICULO")]
    [StringLength(30)]
    public string? Articulo { get; set; }

    [Column("CANTIDAD")]
    public double? Cantidad { get; set; }

    [Column("SURTIDO")]
    public double? Surtido { get; set; }

    [Column("POR_SURT")]
    public double? PorSurt { get; set; }

    [Column("PRECIO")]
    public double? Precio { get; set; }

    [Column("DESCUENTO")]
    public double? Descuento { get; set; }

    [Column("IMPUESTO")]
    public float? Impuesto { get; set; }

    [Column("OBSERV")]
    [StringLength(255)]
    public string? Observ { get; set; }

    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("ID_SALIDA")]
    public int IdSalida { get; set; }

    [StringLength(10)]
    public string? Usuario { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UsuFecha { get; set; }

    [StringLength(8)]
    public string? UsuHora { get; set; }

    public int? Almacen { get; set; }

    public int? Lista { get; set; }

    [StringLength(30)]
    public string? Clave { get; set; }

    [Column("PRCANTIDAD")]
    public int? Prcantidad { get; set; }

    [Column("PRDESCRIP")]
    [StringLength(40)]
    public string? Prdescrip { get; set; }

    [Column("backorder")]
    public int? Backorder { get; set; }

    [Column("donativo")]
    public short? Donativo { get; set; }

    [Column("SSMA_TimeStamp")]
    public byte[] SsmaTimeStamp { get; set; } = null!;
}
