using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("turno")]
[Index("Truno", Name = "truno", IsUnique = true)]
public partial class Turno
{
    [Column("comida")]
    [StringLength(5)]
    public string? Comida { get; set; }

    [Column("entrada")]
    [StringLength(5)]
    public string? Entrada { get; set; }

    [Column("salida")]
    [StringLength(5)]
    public string? Salida { get; set; }

    [Column("truno")]
    [StringLength(20)]
    public string? Truno { get; set; }
}
