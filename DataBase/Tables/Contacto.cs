using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Table("contacto")]
[Index("Alta", Name = "alta")]
[Index("Apellidom", Name = "apellidom")]
[Index("Apellidop", Name = "apellidop")]
[Index("Cliente", Name = "cliente")]
[Index("Contacto1", Name = "contacto")]
[Index("Id", Name = "id", IsUnique = true)]
[Index("Puesto", Name = "puesto")]
public partial class Contacto
{
    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("CONTACTO")]
    [StringLength(30)]
    public string? Contacto1 { get; set; }

    [Column("APELLIDOP")]
    [StringLength(30)]
    public string? Apellidop { get; set; }

    [Column("APELLIDOM")]
    [StringLength(30)]
    public string? Apellidom { get; set; }

    [Column("PUESTO")]
    [StringLength(30)]
    public string? Puesto { get; set; }

    [Column("ALTA", TypeName = "datetime")]
    public DateTime? Alta { get; set; }

    [Column("CUMPLE", TypeName = "datetime")]
    public DateTime? Cumple { get; set; }

    [Column("CLIENTE")]
    [StringLength(30)]
    public string? Cliente { get; set; }

    [Column("MEDIO")]
    [StringLength(20)]
    public string? Medio { get; set; }

    [StringLength(50)]
    public string? Mail { get; set; }

    [Column("USUARIO")]
    [StringLength(10)]
    public string? Usuario { get; set; }

    [Column("USUFECHA", TypeName = "datetime")]
    public DateTime? Usufecha { get; set; }

    [Column("USUHORA")]
    [StringLength(8)]
    public string? Usuhora { get; set; }

    [Column("TITULO")]
    [StringLength(5)]
    public string? Titulo { get; set; }
}
