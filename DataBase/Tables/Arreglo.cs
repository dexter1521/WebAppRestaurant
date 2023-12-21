using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Table("arreglos")]
public partial class Arreglo
{
    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("arreglo")]
    [StringLength(10)]
    public string Arreglo1 { get; set; } = null!;

    [Column("descripcion")]
    public string? Descripcion { get; set; }

    [Column("url")]
    public string? Url { get; set; }
}
