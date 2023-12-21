using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Table("secciones")]
public partial class Seccione
{
    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("seccion")]
    [StringLength(20)]
    public string Seccion { get; set; } = null!;

    [Column("mesainicial")]
    public int? Mesainicial { get; set; }

    [Column("mesafinal")]
    public int? Mesafinal { get; set; }

    [Column("fumar")]
    public bool? Fumar { get; set; }
}
