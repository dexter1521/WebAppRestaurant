using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("movimientosestaciones")]
[Index("Estacion", Name = "estacion")]
[Index("Estacionrecibe", Name = "estacionrecibe")]
[Index("Fecha", Name = "fecha")]
[Index("Folio", Name = "folio")]
[Index("Id", Name = "id", IsUnique = true)]
public partial class Movimientosestacione
{
    [Column("id")]
    public int? Id { get; set; }

    [Column("estacion")]
    [StringLength(10)]
    public string? Estacion { get; set; }

    [Column("fecha", TypeName = "datetime")]
    public DateTime? Fecha { get; set; }

    [Column("folio")]
    public int? Folio { get; set; }

    [Column("usuario")]
    [StringLength(10)]
    public string? Usuario { get; set; }

    [Column("usufecha", TypeName = "datetime")]
    public DateTime? Usufecha { get; set; }

    [Column("estacionrecibe")]
    [StringLength(10)]
    public string? Estacionrecibe { get; set; }

    [Column("estado")]
    [StringLength(2)]
    public string? Estado { get; set; }

    [Column("usuhora")]
    [StringLength(10)]
    public string? Usuhora { get; set; }
}
