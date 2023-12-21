using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("paises")]
[Index("Pais", Name = "Paises0", IsUnique = true)]
public partial class Paise
{
    [Column("pais")]
    [StringLength(50)]
    public string? Pais { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Codigo { get; set; }
}
