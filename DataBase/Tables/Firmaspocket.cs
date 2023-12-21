using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("firmaspocket")]
public partial class Firmaspocket
{
    [Column("firma")]
    [StringLength(20)]
    public string Firma { get; set; } = null!;

    [Column("fecha", TypeName = "datetime")]
    public DateTime Fecha { get; set; }
}
