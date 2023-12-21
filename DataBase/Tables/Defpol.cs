using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("defpol")]
[Index("Defpol1", Name = "defpol")]
[Index("Id", Name = "id", IsUnique = true)]
public partial class Defpol
{
    [Column("acumulativa")]
    public short? Acumulativa { get; set; }

    [Column("defpol")]
    [StringLength(30)]
    public string? Defpol1 { get; set; }

    [Column("defpol2")]
    [StringLength(10)]
    public string? Defpol2 { get; set; }

    [Column("encabezado")]
    [StringLength(255)]
    public string? Encabezado { get; set; }

    [Column("id")]
    public int? Id { get; set; }

    [Column("procedimiento")]
    [StringLength(10)]
    public string? Procedimiento { get; set; }

    [Column("tipopol")]
    [StringLength(2)]
    public string? Tipopol { get; set; }

    [Column("usuario")]
    [StringLength(10)]
    public string? Usuario { get; set; }

    [Column("usufecha", TypeName = "datetime")]
    public DateTime? Usufecha { get; set; }

    [Column("usuhora")]
    [StringLength(8)]
    public string? Usuhora { get; set; }
}
