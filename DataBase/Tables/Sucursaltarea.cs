using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("sucursaltareas")]
[Index("Fecha", Name = "fecha")]
[Index("Id", Name = "id", IsUnique = true)]
public partial class Sucursaltarea
{
    [Column("id")]
    public int? Id { get; set; }

    [Column("sucursal")]
    [StringLength(20)]
    public string? Sucursal { get; set; }

    [Column("tarea")]
    [StringLength(10)]
    public string? Tarea { get; set; }

    [Column("articulo")]
    [StringLength(20)]
    public string? Articulo { get; set; }

    [Column("salida")]
    public int? Salida { get; set; }

    [Column("fecha", TypeName = "datetime")]
    public DateTime? Fecha { get; set; }
}
