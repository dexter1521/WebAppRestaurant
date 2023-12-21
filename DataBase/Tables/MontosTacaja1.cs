using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("montosTACAJA1")]
public partial class MontosTacaja1
{
    [Column("proveedor")]
    public int Proveedor { get; set; }

    [Column("monto")]
    public double Monto { get; set; }
}
