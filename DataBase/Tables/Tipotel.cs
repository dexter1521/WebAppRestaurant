using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("tipotel")]
[Index("Tipotel1", Name = "tipotel", IsUnique = true)]
public partial class Tipotel
{
    [Column("TIPOTEL")]
    [StringLength(20)]
    public string? Tipotel1 { get; set; }

    [StringLength(50)]
    public string? Descrip { get; set; }
}
