using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("usurep")]
[Index("Formato", Name = "formato")]
[Index("Usuario", Name = "usuario")]
public partial class Usurep
{
    [Column("FORMATO")]
    [StringLength(35)]
    public string? Formato { get; set; }

    [Column("USUARIO")]
    [StringLength(50)]
    public string? Usuario { get; set; }

    [StringLength(100)]
    public string? Descrip { get; set; }
}
