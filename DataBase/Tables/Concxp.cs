using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("concxp")]
[Index("ClaveCon", Name = "clave_con", IsUnique = true)]
public partial class Concxp
{
    [Column("CLAVE_CON")]
    [StringLength(3)]
    public string? ClaveCon { get; set; }

    [Column("DESCRIP")]
    [StringLength(40)]
    public string? Descrip { get; set; }

    [Column("TIPO_CXC")]
    [StringLength(1)]
    public string? TipoCxc { get; set; }

    [Column("FIJO")]
    public short? Fijo { get; set; }

    [Column("FORMATO")]
    [StringLength(35)]
    public string? Formato { get; set; }

    [Column("EGRESO")]
    public short? Egreso { get; set; }

    [Column("USUARIO")]
    [StringLength(10)]
    public string? Usuario { get; set; }

    [Column("USUFECHA", TypeName = "datetime")]
    public DateTime? Usufecha { get; set; }

    [Column("USUHORA")]
    [StringLength(8)]
    public string? Usuhora { get; set; }
}
