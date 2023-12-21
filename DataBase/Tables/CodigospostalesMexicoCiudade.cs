using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[PrimaryKey("Estado", "Ciudad")]
[Table("codigospostales_mexico_ciudades")]
public partial class CodigospostalesMexicoCiudade
{
    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("estado")]
    [StringLength(10)]
    public string Estado { get; set; } = null!;

    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("ciudad")]
    [StringLength(10)]
    public string Ciudad { get; set; } = null!;

    [Column("nombre")]
    [StringLength(50)]
    public string? Nombre { get; set; }
}
