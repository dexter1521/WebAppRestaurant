using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("precioscliente")]
[Index("Cliente", Name = "cliente")]
public partial class Precioscliente
{
    [Column("cliente")]
    [StringLength(30)]
    public string? Cliente { get; set; }

    [Column("articulo")]
    [StringLength(30)]
    public string? Articulo { get; set; }

    [Column("precio")]
    public int? Precio { get; set; }
}
