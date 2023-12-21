using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("pagodestajo")]
[Index("Id", Name = "id", IsUnique = true)]
public partial class Pagodestajo
{
    [Column("id")]
    public int? Id { get; set; }

    [Column("fecha")]
    [StringLength(20)]
    public string? Fecha { get; set; }

    [Column("empleado")]
    [StringLength(20)]
    public string? Empleado { get; set; }

    [Column("importe")]
    public double? Importe { get; set; }

    [Column("SSMA_TimeStamp")]
    public byte[] SsmaTimeStamp { get; set; } = null!;
}
