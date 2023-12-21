using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[PrimaryKey("Usuario", "Dedo")]
[Table("usuarioshuella")]
public partial class Usuarioshuella
{
    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("usuario")]
    [StringLength(50)]
    public string Usuario { get; set; } = null!;

    [Column("huella")]
    public byte[]? Huella { get; set; }

    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("dedo")]
    [StringLength(3)]
    public string Dedo { get; set; } = null!;
}
