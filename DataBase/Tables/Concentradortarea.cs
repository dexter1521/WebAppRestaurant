using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("concentradortareas")]
[Index("Id", Name = "id", IsUnique = true)]
public partial class Concentradortarea
{
    [Column("id")]
    public short? Id { get; set; }

    [Column("tarea")]
    [StringLength(10)]
    public string? Tarea { get; set; }

    [Column("fecha", TypeName = "datetime")]
    public DateTime? Fecha { get; set; }
}
