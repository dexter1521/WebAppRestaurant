using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("actualizacion")]
[Index("Fecha", Name = "fecha", IsUnique = true)]
public partial class Actualizacion
{
    [Column("fecha", TypeName = "datetime")]
    public DateTime? Fecha { get; set; }
}
