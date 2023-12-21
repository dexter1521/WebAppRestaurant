using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("asociados")]
[Index("Articulo", Name = "articulo")]
[Index("Id", Name = "id", IsUnique = true)]
[Index("Padre", Name = "padre")]
public partial class Asociado
{
    [Column("id")]
    public int? Id { get; set; }

    [Column("articulo")]
    [StringLength(30)]
    public string? Articulo { get; set; }

    [Column("observ")]
    [StringLength(250)]
    public string? Observ { get; set; }

    [Column("padre")]
    [StringLength(30)]
    public string? Padre { get; set; }
}
