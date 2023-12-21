using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Table("tallas")]
public partial class Talla
{
    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("Talla")]
    [StringLength(5)]
    public string Talla1 { get; set; } = null!;

    [Column("descrip")]
    [StringLength(40)]
    public string Descrip { get; set; } = null!;

    [Column("usuario")]
    [StringLength(8)]
    public string Usuario { get; set; } = null!;

    [Column("usufecha", TypeName = "datetime")]
    public DateTime Usufecha { get; set; }

    [Column("usuhora")]
    [StringLength(8)]
    public string Usuhora { get; set; } = null!;
}
