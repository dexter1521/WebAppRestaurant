using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Table("zonas")]
[Index("Zona1", Name = "zona", IsUnique = true)]
public partial class Zona
{
    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("Zona")]
    [StringLength(5)]
    public string Zona1 { get; set; } = null!;

    [StringLength(50)]
    public string? Descrip { get; set; }

    [StringLength(10)]
    public string? Usuario { get; set; }

    [Column("usuFecha", TypeName = "datetime")]
    public DateTime? UsuFecha { get; set; }

    [Column("usuHora")]
    [StringLength(8)]
    public string? UsuHora { get; set; }
}
