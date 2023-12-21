using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("defpoldet")]
[Index("Cuenta", Name = "cuenta")]
[Index("Defpol", Name = "defpol")]
[Index("Id", Name = "id")]
[Index("Iddefpol", Name = "iddefpol")]
public partial class Defpoldet
{
    [Column("cuenta")]
    [StringLength(15)]
    public string? Cuenta { get; set; }

    [Column("debe")]
    [StringLength(20)]
    public string? Debe { get; set; }

    [Column("defpol")]
    [StringLength(10)]
    public string? Defpol { get; set; }

    [Column("haber")]
    [StringLength(20)]
    public string? Haber { get; set; }

    [Column("id")]
    public int? Id { get; set; }

    [Column("iddefpol")]
    public int? Iddefpol { get; set; }

    [Column("usuario")]
    [StringLength(10)]
    public string? Usuario { get; set; }

    [Column("usufecha", TypeName = "datetime")]
    public DateTime? Usufecha { get; set; }

    [Column("usuhora")]
    [StringLength(8)]
    public string? Usuhora { get; set; }
}
