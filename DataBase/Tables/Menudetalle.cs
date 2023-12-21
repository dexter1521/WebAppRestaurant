using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("menudetalle")]
[Index("Catalogo", Name = "catalogo")]
[Index("Menu", Name = "menu")]
public partial class Menudetalle
{
    [StringLength(50)]
    public string? Menu { get; set; }

    [StringLength(50)]
    public string? Catalogo { get; set; }
}
