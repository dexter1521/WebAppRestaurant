using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("ide_proyectos")]
public partial class IdeProyecto
{
    [Column("proyecto")]
    [StringLength(50)]
    public string? Proyecto { get; set; }

    [Column("descripcion")]
    public string? Descripcion { get; set; }
}
