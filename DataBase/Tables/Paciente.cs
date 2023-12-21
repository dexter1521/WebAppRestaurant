using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("pacientes")]
[Index("Paciente1", Name = "paciente", IsUnique = true)]
public partial class Paciente
{
    [Column("paciente")]
    [StringLength(20)]
    public string? Paciente1 { get; set; }

    [Column("nombre")]
    [StringLength(20)]
    public string? Nombre { get; set; }

    [Column("apellidop")]
    [StringLength(20)]
    public string? Apellidop { get; set; }

    [Column("apellidom")]
    [StringLength(20)]
    public string? Apellidom { get; set; }

    [Column("sexo")]
    [StringLength(1)]
    public string? Sexo { get; set; }

    [Column("edad")]
    public int? Edad { get; set; }
}
