using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("relacion")]
[Index("Cliente", Name = "cliente", IsUnique = true)]
[Index("Relacion1", Name = "relacion", IsUnique = true)]
public partial class Relacion
{
    [Column("CLIENTE")]
    [StringLength(30)]
    public string? Cliente { get; set; }

    [Column("TIPO")]
    [StringLength(20)]
    public string? Tipo { get; set; }

    [Column("RELACION")]
    [StringLength(10)]
    public string? Relacion1 { get; set; }

    [StringLength(10)]
    public string? Usuario { get; set; }

    [Column("usuFecha", TypeName = "datetime")]
    public DateTime? UsuFecha { get; set; }

    [Column("usuHora")]
    [StringLength(8)]
    public string? UsuHora { get; set; }
}
