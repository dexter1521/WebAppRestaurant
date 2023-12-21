using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
public partial class VFedatosArticuloTmp
{
    [StringLength(10)]
    public string SerieDocumento { get; set; } = null!;

    [Column("venta")]
    public int? Venta { get; set; }

    [Column("articulo")]
    [StringLength(30)]
    public string? Articulo { get; set; }

    public double? Cantidad { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? ValorU { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? Descuento { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? Impuesto { get; set; }

    public float PorcentajeImpuesto { get; set; }

    [StringLength(20)]
    public string Unidad { get; set; } = null!;

    public string Descrip { get; set; } = null!;

    [Column("SSMA_TimeStamp")]
    public byte[] SsmaTimeStamp { get; set; } = null!;

    [StringLength(30)]
    public string? Presentacion { get; set; }

    public double? PrCantidad { get; set; }

    [StringLength(100)]
    public string PrDescrip { get; set; } = null!;

    [StringLength(5)]
    public string CodImpuesto { get; set; } = null!;
}
