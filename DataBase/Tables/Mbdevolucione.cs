using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
public partial class Mbdevolucione
{
    public int? DeCompra { get; set; }

    [Column("articulo")]
    [StringLength(30)]
    public string? Articulo { get; set; }

    public double? Cantidad { get; set; }
}
