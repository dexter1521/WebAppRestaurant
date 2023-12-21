using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Table("almacen")]
[Index("Almacen1", Name = "almacen", IsUnique = true)]
public partial class Almacen
{
    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("Almacen")]
    public short Almacen1 { get; set; }

    [StringLength(40)]
    public string? Descrip { get; set; }

    [StringLength(10)]
    public string? Usuario { get; set; }

    [Column("usuFecha", TypeName = "datetime")]
    public DateTime? UsuFecha { get; set; }

    [Column("usuhora")]
    [StringLength(10)]
    public string? Usuhora { get; set; }
}
