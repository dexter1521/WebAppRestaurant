using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Table("materiales")]
public partial class Materiale
{
    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("articulo")]
    [StringLength(30)]
    public string Articulo { get; set; } = null!;

    [Column("descripcion")]
    public string? Descripcion { get; set; }

    [Column("costo", TypeName = "smallmoney")]
    public decimal? Costo { get; set; }

    [Column("margen", TypeName = "smallmoney")]
    public decimal? Margen { get; set; }

    [Column("impuesto")]
    [StringLength(5)]
    public string? Impuesto { get; set; }

    [Column("precio", TypeName = "smallmoney")]
    public decimal? Precio { get; set; }
}
