using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("colorxmodelo")]
public partial class Colorxmodelo
{
    [Column("id")]
    public int Id { get; set; }

    [StringLength(9)]
    public string Modelo { get; set; } = null!;

    [Column("color")]
    [StringLength(5)]
    public string Color { get; set; } = null!;

    [StringLength(15)]
    public string Usuario { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime UsuFecha { get; set; }

    [StringLength(8)]
    public string UsuHora { get; set; } = null!;
}
