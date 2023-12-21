using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("tareas")]
[Index("Id", Name = "id", IsUnique = true)]
public partial class Tarea
{
    [Column("id")]
    public int? Id { get; set; }

    [Column("http")]
    [StringLength(255)]
    public string? Http { get; set; }
}
