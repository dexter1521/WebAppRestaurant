using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("montosTAESTACION01")]
public partial class MontosTaestacion01
{
    [Column("proveedor")]
    public int Proveedor { get; set; }

    [Column("monto")]
    public double Monto { get; set; }
}
