using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("favoritos")]
[Index("Favorito1", Name = "favorito")]
[Index("Item", Name = "item")]
[Index("Nodo", Name = "nodo")]
[Index("Usuario", Name = "usuario")]
public partial class Favorito
{
    [StringLength(10)]
    public string? Usuario { get; set; }

    [Column("Favorito")]
    [StringLength(250)]
    public string? Favorito1 { get; set; }

    [StringLength(50)]
    public string? Nodo { get; set; }

    [StringLength(50)]
    public string? Item { get; set; }
}
