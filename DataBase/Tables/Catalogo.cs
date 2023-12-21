using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("catalogos")]
[Index("Nodo", Name = "nodo", IsUnique = true)]
public partial class Catalogo
{
    [StringLength(30)]
    public string? Nodo { get; set; }

    [Column("Catalogo")]
    [StringLength(30)]
    public string? Catalogo1 { get; set; }

    [StringLength(255)]
    public string? Modulo { get; set; }
}
