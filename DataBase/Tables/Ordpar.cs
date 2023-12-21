using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("ordpar")]
[Index("Articulo", Name = "articulo")]
[Index("ClaveAdd", Name = "claveadd")]
[Index("Fechaentrega", Name = "fechaentrega")]
[Index("IdEntrada", Name = "id_entrada", IsUnique = true)]
[Index("Orden", Name = "orden")]
[Index("PorSurt", Name = "por_surt")]
public partial class Ordpar
{
    [Column("ORDEN")]
    public int? Orden { get; set; }

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

    [Column("PARTIDA")]
    public int? Partida { get; set; }

    [Column("ID_ENTRADA")]
    public int? IdEntrada { get; set; }

    [StringLength(10)]
    public string? Usuario { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UsuFecha { get; set; }

    [StringLength(8)]
    public string? UsuHora { get; set; }

    [StringLength(30)]
    public string? ClaveAdd { get; set; }

    public double? DescuentoAdicional { get; set; }

    public double? PrCantidad { get; set; }

    [Column("IEspecial")]
    public double? Iespecial { get; set; }

    [Column("GASTO")]
    public double? Gasto { get; set; }

    [Column("backorder")]
    public int? Backorder { get; set; }

    [Column("fechaentrega", TypeName = "datetime")]
    public DateTime? Fechaentrega { get; set; }

    [Column("SSMA_TimeStamp")]
    public byte[] SsmaTimeStamp { get; set; } = null!;
}
