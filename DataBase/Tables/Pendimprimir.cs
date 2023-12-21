using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("pendimprimir")]
[Index("Venta", Name = "venta", IsUnique = true)]
public partial class Pendimprimir
{
    [Column("venta")]
    public int? Venta { get; set; }
}
