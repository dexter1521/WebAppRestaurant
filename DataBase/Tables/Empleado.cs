using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("empleados")]
[Index("Empleado1", Name = "empleado", IsUnique = true)]
public partial class Empleado
{
    [Column("empleado")]
    [StringLength(20)]
    public string? Empleado1 { get; set; }

    [Column("nombre")]
    [StringLength(50)]
    public string? Nombre { get; set; }

    [Column("usuario")]
    [StringLength(10)]
    public string? Usuario { get; set; }

    [Column("usufecha", TypeName = "datetime")]
    public DateTime? Usufecha { get; set; }

    [Column("usuhora")]
    [StringLength(8)]
    public string? Usuhora { get; set; }

    [Column("horaentrada")]
    [StringLength(5)]
    public string? Horaentrada { get; set; }

    [Column("horasalida")]
    [StringLength(5)]
    public string? Horasalida { get; set; }

    [Column("imagen")]
    [StringLength(100)]
    public string? Imagen { get; set; }
}
