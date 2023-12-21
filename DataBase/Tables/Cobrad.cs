using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("cobrad")]
[Index("Cobrador", Name = "cobrador", IsUnique = true)]
public partial class Cobrad
{
    [StringLength(5)]
    public string? Cobrador { get; set; }

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

    [Column("SSMA_TimeStamp")]
    public byte[] SsmaTimeStamp { get; set; } = null!;
}
