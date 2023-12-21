using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[PrimaryKey("Almacen", "Articulo")]
[Table("existenciaalmacen")]
public partial class Existenciaalmacen
{
    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("almacen")]
    public int Almacen { get; set; }

    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("articulo")]
    [StringLength(30)]
    public string Articulo { get; set; } = null!;

    [Column("existencia")]
    public double? Existencia { get; set; }
}
