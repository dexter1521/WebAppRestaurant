using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("barra")]
public partial class Barra
{
    [Column("USUARIO")]
    [StringLength(10)]
    public string? Usuario { get; set; }

    [Column("BAR")]
    [StringLength(20)]
    public string? Bar { get; set; }

    [Column("ITEM")]
    [StringLength(20)]
    public string? Item { get; set; }

    public short? Activo { get; set; }
}
