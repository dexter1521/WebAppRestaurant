using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("estados")]
[Index("Estado1", Name = "estado", IsUnique = true)]
public partial class Estado
{
    [Column("estado")]
    [StringLength(5)]
    public string? Estado1 { get; set; }

    [Column("nombre")]
    [StringLength(30)]
    public string? Nombre { get; set; }
}
