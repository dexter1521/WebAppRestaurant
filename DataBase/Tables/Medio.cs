using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("medios")]
[Index("Medio1", Name = "medio", IsUnique = true)]
public partial class Medio
{
    [Column("MEDIO")]
    [StringLength(20)]
    public string? Medio1 { get; set; }

    [Column("DESCRIP")]
    [StringLength(50)]
    public string? Descrip { get; set; }

    [Column("USUARIO")]
    [StringLength(10)]
    public string? Usuario { get; set; }

    [Column("USUFECHA", TypeName = "datetime")]
    public DateTime? Usufecha { get; set; }

    [Column("USUHORA")]
    [StringLength(8)]
    public string? Usuhora { get; set; }
}
