using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("telefono")]
[Index("Id", Name = "id", IsUnique = true)]
public partial class Telefono
{
    [Column("ID")]
    public int? Id { get; set; }

    [Column("CA")]
    [StringLength(7)]
    public string? Ca { get; set; }

    [Column("IDContacto")]
    public int? Idcontacto { get; set; }

    [Column("TELEFONO")]
    [StringLength(30)]
    public string? Telefono1 { get; set; }

    [Column("TIPO")]
    [StringLength(20)]
    public string? Tipo { get; set; }

    [Column("COMENT")]
    [StringLength(100)]
    public string? Coment { get; set; }

    [Column("AUTO")]
    public short? Auto { get; set; }

    [Column("USUARIO")]
    [StringLength(10)]
    public string? Usuario { get; set; }

    [Column("USUFECHA", TypeName = "datetime")]
    public DateTime? Usufecha { get; set; }

    [Column("USUHORA")]
    [StringLength(8)]
    public string? Usuhora { get; set; }

    [Column("telefonold")]
    [StringLength(30)]
    public string? Telefonold { get; set; }
}
