using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("encuesta")]
[Index("Id", Name = "id", IsUnique = true)]
[Index("Opcion", Name = "opcion")]
public partial class Encuestum
{
    [Column("id")]
    public int? Id { get; set; }

    [StringLength(100)]
    public string? Opcion { get; set; }

    [Column("fecha", TypeName = "datetime")]
    public DateTime? Fecha { get; set; }

    [Column("usuario")]
    [StringLength(10)]
    public string? Usuario { get; set; }

    [Column("hora")]
    [StringLength(10)]
    public string? Hora { get; set; }
}
