using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("tipoventa")]
[Index("Tipoventa", Name = "tipoventa", IsUnique = true)]
public partial class Tipoventum
{
    [Column("TIPOVENTA")]
    [StringLength(20)]
    public string? Tipoventa { get; set; }

    [Column("DESCRIP")]
    [StringLength(40)]
    public string? Descrip { get; set; }
}
