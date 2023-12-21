using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("tipopend")]
[Index("Tipopend1", Name = "tipopend", IsUnique = true)]
public partial class Tipopend
{
    [Column("TIPOPEND")]
    [StringLength(5)]
    public string? Tipopend1 { get; set; }

    [Column("DESCRIP")]
    [StringLength(50)]
    public string? Descrip { get; set; }

    [StringLength(10)]
    public string? Usuario { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UsuFecha { get; set; }

    [StringLength(8)]
    public string? UsuHora { get; set; }
}
