using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[PrimaryKey("Moneda", "Fecha")]
[Table("tiposdecambio")]
public partial class Tiposdecambio
{
    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("moneda")]
    [StringLength(5)]
    public string Moneda { get; set; } = null!;

    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("fecha", TypeName = "smalldatetime")]
    public DateTime Fecha { get; set; }

    [Column("tipoDeCambio")]
    public double? TipoDeCambio { get; set; }

    [Column("usuario")]
    [StringLength(50)]
    public string? Usuario { get; set; }

    [Column("usufecha", TypeName = "smalldatetime")]
    public DateTime? Usufecha { get; set; }

    [Column("usuhora")]
    [StringLength(8)]
    public string? Usuhora { get; set; }
}
