using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("menus")]
[Index("Id", Name = "id", IsUnique = true)]
[Index("Menu1", Name = "menu")]
public partial class Menu
{
    public int? Id { get; set; }

    [Column("Menu")]
    [StringLength(50)]
    public string? Menu1 { get; set; }

    [StringLength(50)]
    public string? Descrip { get; set; }

    [StringLength(20)]
    public string? Catalogo { get; set; }

    public short? Siempre { get; set; }

    public short? Todos { get; set; }
}
