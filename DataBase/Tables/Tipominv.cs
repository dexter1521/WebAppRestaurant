using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("tipominv")]
[Index("TipoMovim", Name = "tipo_movim", IsUnique = true)]
public partial class Tipominv
{
    [Column("TIPO_MOVIM")]
    [StringLength(3)]
    public string? TipoMovim { get; set; }

    [Column("DESCRIP")]
    [StringLength(50)]
    public string? Descrip { get; set; }

    [Column("ENT_SAL")]
    [StringLength(1)]
    public string? EntSal { get; set; }

    [Column("FIJO")]
    public short? Fijo { get; set; }

    [Column("USUARIO")]
    [StringLength(10)]
    public string? Usuario { get; set; }

    [Column("USUFECHA", TypeName = "datetime")]
    public DateTime? Usufecha { get; set; }

    [Column("USUHORA")]
    [StringLength(8)]
    public string? Usuhora { get; set; }

    [Column("afectacosto")]
    public short? Afectacosto { get; set; }
}
