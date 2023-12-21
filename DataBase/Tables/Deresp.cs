using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("deresp")]
[Index("Id", Name = "id")]
[Index("Menu", Name = "menu")]
[Index("Nodo", Name = "nodo")]
[Index("Usuario", Name = "usuario")]
public partial class Deresp
{
    [Column("USUARIO")]
    [StringLength(50)]
    public string? Usuario { get; set; }

    [Column("ID")]
    public int? Id { get; set; }

    [Column("NODO")]
    [StringLength(30)]
    public string? Nodo { get; set; }

    [Column("MENU")]
    [StringLength(50)]
    public string? Menu { get; set; }

    [Column("TEXTO")]
    [StringLength(50)]
    public string? Texto { get; set; }

    [Column("PERMISO")]
    public short? Permiso { get; set; }
}
