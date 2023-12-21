using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("vends")]
[Index("Vend1", Name = "vend", IsUnique = true)]
public partial class Vend
{
    [Column("Vend")]
    [StringLength(15)]
    public string? Vend1 { get; set; }

    [StringLength(50)]
    public string? Nombre { get; set; }

    public double? Comision { get; set; }

    [StringLength(10)]
    public string? Usuario { get; set; }

    [Column("usuFecha", TypeName = "datetime")]
    public DateTime? UsuFecha { get; set; }

    [Column("usuHora")]
    [StringLength(8)]
    public string? UsuHora { get; set; }

    public short? Activo { get; set; }

    [Column("foraneo")]
    public short? Foraneo { get; set; }

    [Column("SSMA_TimeStamp")]
    public byte[] SsmaTimeStamp { get; set; } = null!;
}
