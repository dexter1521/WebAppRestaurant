using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("tiposprov")]
[Index("TipoProv", Name = "tipoprov", IsUnique = true)]
public partial class Tiposprov
{
    [StringLength(5)]
    public string? TipoProv { get; set; }

    [StringLength(50)]
    public string? Descrip { get; set; }

    [StringLength(10)]
    public string? Usuario { get; set; }

    [Column("usuFecha", TypeName = "datetime")]
    public DateTime? UsuFecha { get; set; }

    [Column("usuHora")]
    [StringLength(8)]
    public string? UsuHora { get; set; }
}
