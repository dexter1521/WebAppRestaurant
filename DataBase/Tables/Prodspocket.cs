using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[PrimaryKey("Articulo", "Almacen")]
[Table("prodspocket")]
public partial class Prodspocket
{
    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("articulo")]
    [StringLength(30)]
    public string Articulo { get; set; } = null!;

    [Column("donativo")]
    public double Donativo { get; set; }

    [Column("descrip")]
    [StringLength(200)]
    public string Descrip { get; set; } = null!;

    [Column("precio1")]
    public double Precio1 { get; set; }

    [Column("precio2")]
    public double Precio2 { get; set; }

    [Column("precio3")]
    public double Precio3 { get; set; }

    [Column("precio4")]
    public double Precio4 { get; set; }

    [Column("precio5")]
    public double Precio5 { get; set; }

    [Column("precio6")]
    public double Precio6 { get; set; }

    [Column("precio7")]
    public double Precio7 { get; set; }

    [Column("precio8")]
    public double Precio8 { get; set; }

    [Column("precio9")]
    public double Precio9 { get; set; }

    [Column("precio10")]
    public double Precio10 { get; set; }

    [Column("c2")]
    public double C2 { get; set; }

    [Column("c3")]
    public double C3 { get; set; }

    [Column("c4")]
    public double C4 { get; set; }

    [Column("c5")]
    public double C5 { get; set; }

    [Column("c6")]
    public double C6 { get; set; }

    [Column("c7")]
    public double C7 { get; set; }

    [Column("c8")]
    public double C8 { get; set; }

    [Column("c9")]
    public double C9 { get; set; }

    [Column("c10")]
    public double C10 { get; set; }

    [Column("valor")]
    public double Valor { get; set; }

    [Column("costo_u")]
    public double CostoU { get; set; }

    [Column("existencia")]
    public double Existencia { get; set; }

    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("almacen")]
    public short Almacen { get; set; }
}
