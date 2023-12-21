using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("METODOSDEPAGO")]
public partial class Metodosdepago
{
    [Column("CLAVE")]
    [StringLength(5)]
    public string? Clave { get; set; }

    [Column("CONCEPTO")]
    [StringLength(30)]
    public string? Concepto { get; set; }
}
