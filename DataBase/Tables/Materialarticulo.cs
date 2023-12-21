using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[PrimaryKey("Material", "Articulo")]
[Table("materialarticulo")]
public partial class Materialarticulo
{
    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("material")]
    [StringLength(30)]
    public string Material { get; set; } = null!;

    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("articulo")]
    [StringLength(30)]
    public string Articulo { get; set; } = null!;
}
