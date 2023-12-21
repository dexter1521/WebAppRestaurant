using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Table("cpc_partidas")]
public partial class CpcPartida
{
    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("descripcion")]
    public string? Descripcion { get; set; }

    [Column("cantidad")]
    public double? Cantidad { get; set; }

    [Column("precio", TypeName = "smallmoney")]
    public decimal? Precio { get; set; }

    [Column("descuento")]
    public double? Descuento { get; set; }

    [Column("mesa")]
    public int? Mesa { get; set; }

    [Column("fecha", TypeName = "smalldatetime")]
    public DateTime? Fecha { get; set; }

    [Column("botones")]
    public string? Botones { get; set; }
}
