using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Table("prodsDelSitio")]
public partial class ProdsDelSitio
{
    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("articulo")]
    [StringLength(30)]
    public string Articulo { get; set; } = null!;

    [Column("descripcion")]
    public string Descripcion { get; set; } = null!;

    [Column("precio", TypeName = "smallmoney")]
    public decimal Precio { get; set; }

    [Column("impuesto", TypeName = "smallmoney")]
    public decimal Impuesto { get; set; }

    [Column("costo_u")]
    public double CostoU { get; set; }

    [Column("existencia")]
    public double Existencia { get; set; }

    [Column("validado")]
    [StringLength(2)]
    public string Validado { get; set; } = null!;
}
