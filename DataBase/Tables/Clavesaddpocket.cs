using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[PrimaryKey("Clave", "Almacen")]
[Table("clavesaddpocket")]
public partial class Clavesaddpocket
{
    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("clave")]
    [StringLength(30)]
    public string Clave { get; set; } = null!;

    [Column("articulo")]
    [StringLength(30)]
    public string Articulo { get; set; } = null!;

    [Column("dato1")]
    [StringLength(100)]
    public string Dato1 { get; set; } = null!;

    [Column("cantidad")]
    public double Cantidad { get; set; }

    [Column("precio")]
    public double Precio { get; set; }

    [Column("valor")]
    public double Valor { get; set; }

    [Column("existencia")]
    public double Existencia { get; set; }

    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("almacen")]
    public short Almacen { get; set; }
}
