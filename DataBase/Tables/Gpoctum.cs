using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("gpocta")]
[Index("Grupo", Name = "grupo", IsUnique = true)]
public partial class Gpoctum
{
    [Column("descrip")]
    [StringLength(40)]
    public string? Descrip { get; set; }

    [Column("grupo")]
    [StringLength(4)]
    public string? Grupo { get; set; }

    [Column("usuario")]
    [StringLength(10)]
    public string? Usuario { get; set; }

    [Column("usufecha", TypeName = "datetime")]
    public DateTime? Usufecha { get; set; }

    [Column("usuhora")]
    [StringLength(8)]
    public string? Usuhora { get; set; }
}
