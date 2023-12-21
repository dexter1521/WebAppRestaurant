using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("PartidasMalla")]
public partial class PartidasMalla
{
    [StringLength(30)]
    public string? Articulo { get; set; }

    public string? Descrip { get; set; }

    public int? Cantidad { get; set; }

    public double? CostoPrecio { get; set; }

    public double? Impuesto { get; set; }

    public double? ImporteTotal { get; set; }
}
