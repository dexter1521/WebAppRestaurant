using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("montosTACAJA2")]
public partial class MontosTacaja2
{
    [Column("proveedor")]
    public int Proveedor { get; set; }

    [Column("monto")]
    public double Monto { get; set; }
}
