using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Table("colores")]
public partial class Colore
{
    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("color")]
    [StringLength(5)]
    public string Color { get; set; } = null!;

    [StringLength(40)]
    public string Descrip { get; set; } = null!;

    [Column("visualcolor")]
    public int Visualcolor { get; set; }

    [Column("usuario")]
    [StringLength(8)]
    public string Usuario { get; set; } = null!;

    [Column("usufecha", TypeName = "datetime")]
    public DateTime Usufecha { get; set; }

    [Column("usuhora")]
    [StringLength(8)]
    public string Usuhora { get; set; } = null!;

    [Column("visualcolor2")]
    public int Visualcolor2 { get; set; }

    [Column("r1")]
    public int R1 { get; set; }

    [Column("g1")]
    public int G1 { get; set; }

    [Column("b1")]
    public int B1 { get; set; }

    [Column("r2")]
    public int R2 { get; set; }

    [Column("g2")]
    public int G2 { get; set; }

    [Column("b2")]
    public int B2 { get; set; }
}
