using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("servicios")]
[Index("Articulo", Name = "articulo")]
[Index("Id", Name = "id", IsUnique = true)]
[Index("Venta", Name = "venta")]
public partial class Servicio
{
    [Column("id")]
    public int? Id { get; set; }

    [Column("articulo")]
    [StringLength(30)]
    public string? Articulo { get; set; }

    [Column("ocupado")]
    public short? Ocupado { get; set; }

    [Column("numeroservicio")]
    public int? Numeroservicio { get; set; }

    [Column("venta")]
    public int? Venta { get; set; }

    [Column("fecha", TypeName = "datetime")]
    public DateTime? Fecha { get; set; }

    [Column("hora")]
    [StringLength(8)]
    public string? Hora { get; set; }
}
