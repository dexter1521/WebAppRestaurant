using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("ubicacion")]
[Index("Ubicacion1", Name = "ubicacion", IsUnique = true)]
public partial class Ubicacion
{
    [Column("Ubicacion")]
    [StringLength(20)]
    public string? Ubicacion1 { get; set; }

    [Column("descrip")]
    [StringLength(40)]
    public string? Descrip { get; set; }

    [StringLength(20)]
    public string? Usuario { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Usufecha { get; set; }

    [StringLength(8)]
    public string? UsuHora { get; set; }
}
