using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("compopt")]
[Index("Id", Name = "id")]
[Index("IdOpcion", Name = "idopcion")]
public partial class Compopt
{
    [Column("id")]
    public int? Id { get; set; }

    [Column("articulo")]
    [StringLength(30)]
    public string? Articulo { get; set; }

    [Column("idOpcion")]
    public int? IdOpcion { get; set; }
}
