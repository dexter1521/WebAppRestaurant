using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("formatosreferencias")]
[Index("Formato", Name = "formato")]
[Index("Id", Name = "id", IsUnique = true)]
public partial class Formatosreferencia
{
    [Column("id")]
    public int? Id { get; set; }

    [Column("formato")]
    [StringLength(10)]
    public string? Formato { get; set; }

    [Column("descrip")]
    [StringLength(100)]
    public string? Descrip { get; set; }

    [Column("dll")]
    [StringLength(30)]
    public string? Dll { get; set; }

    [Column("clase")]
    [StringLength(30)]
    public string? Clase { get; set; }

    [Column("alias")]
    [StringLength(30)]
    public string? Alias { get; set; }

    [Column("procesoalterno")]
    [StringLength(20)]
    public string? Procesoalterno { get; set; }
}
