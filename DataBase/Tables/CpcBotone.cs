using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Table("cpc_botones")]
public partial class CpcBotone
{
    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("id")]
    public int Id { get; set; }

    public int? Orden { get; set; }

    [Column("botones")]
    public string? Botones { get; set; }

    [StringLength(30)]
    public string? Clasificacion { get; set; }

    public string? Caption { get; set; }

    [Column("factorDeCosto")]
    public double? FactorDeCosto { get; set; }

    [Column("precioDeVenta", TypeName = "smallmoney")]
    public decimal? PrecioDeVenta { get; set; }
}
