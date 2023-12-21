using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("asistencia")]
[Index("Fechahora", Name = "fechahora")]
[Index("Id", Name = "id", IsUnique = true)]
public partial class Asistencium
{
    [Column("id")]
    public int? Id { get; set; }

    [Column("fechahora")]
    [StringLength(19)]
    public string? Fechahora { get; set; }

    [Column("empleado")]
    [StringLength(20)]
    public string? Empleado { get; set; }

    [Column("fecha", TypeName = "datetime")]
    public DateTime? Fecha { get; set; }

    [Column("fechahorasalida")]
    [StringLength(19)]
    public string? Fechahorasalida { get; set; }

    [Column("retardo")]
    public int? Retardo { get; set; }
}
