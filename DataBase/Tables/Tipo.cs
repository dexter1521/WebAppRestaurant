using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Table("tipos")]
[Index("Tipo1", Name = "tipo", IsUnique = true)]
public partial class Tipo
{
    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("Tipo")]
    [StringLength(5)]
    public string Tipo1 { get; set; } = null!;

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
