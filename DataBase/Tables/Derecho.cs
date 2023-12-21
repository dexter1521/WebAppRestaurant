using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("derechos")]
[Index("Id", Name = "id", IsUnique = true)]
[Index("Usuario", Name = "usuario")]
public partial class Derecho
{
    [Column("USUARIO")]
    [StringLength(10)]
    public string? Usuario { get; set; }

    [Column("ID")]
    public int? Id { get; set; }

    [Column("LLAVE")]
    [StringLength(50)]
    public string? Llave { get; set; }

    [Column("TEXTO")]
    [StringLength(100)]
    public string? Texto { get; set; }

    [Column("PARENT")]
    [StringLength(100)]
    public string? Parent { get; set; }

    [Column("PERMISO")]
    public short? Permiso { get; set; }

    [Column("TIPO")]
    [StringLength(10)]
    public string? Tipo { get; set; }

    [Column("PADRE")]
    public short? Padre { get; set; }
}
