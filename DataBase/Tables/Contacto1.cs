using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Table("contactos")]
public partial class Contacto1
{
    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("cliente")]
    [StringLength(30)]
    public string? Cliente { get; set; }

    [Column("nombre")]
    public string? Nombre { get; set; }

    [Column("puesto")]
    [StringLength(50)]
    public string? Puesto { get; set; }

    [Column("email")]
    [StringLength(50)]
    public string? Email { get; set; }

    [Column("telefono")]
    [StringLength(50)]
    public string? Telefono { get; set; }

    [Column("celular")]
    [StringLength(50)]
    public string? Celular { get; set; }
}
