using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Table("c_ClaveUnidad")]
public partial class CClaveUnidad
{
    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("c_claveunidad")]
    [StringLength(9)]
    public string CClaveunidad1 { get; set; } = null!;

    [Column("nombre")]
    [StringLength(350)]
    public string? Nombre { get; set; }
}
