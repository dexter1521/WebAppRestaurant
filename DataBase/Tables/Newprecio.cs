using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("newprecio")]
[Index("Articulo", Name = "articulo")]
[Index("Fecha", Name = "fecha")]
public partial class Newprecio
{
    [Column("articulo")]
    [StringLength(30)]
    public string? Articulo { get; set; }

    [Column("fecha", TypeName = "datetime")]
    public DateTime? Fecha { get; set; }
}
