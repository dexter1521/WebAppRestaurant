using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
public partial class VFedatosArticulo
{
    [StringLength(10)]
    public string SerieDocumento { get; set; } = null!;

    [Column("venta")]
    public int? Venta { get; set; }

    [Column("articulo")]
    [StringLength(30)]
    public string? Articulo { get; set; }

    public double? Cantidad { get; set; }

    public double ValorU { get; set; }

    public double Descuento { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? Impuesto { get; set; }

    public float PorcentajeImpuesto { get; set; }

    [StringLength(20)]
    public string Unidad { get; set; } = null!;

    public string Descrip { get; set; } = null!;
}
