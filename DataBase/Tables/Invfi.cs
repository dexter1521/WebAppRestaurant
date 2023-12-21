using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("invfis")]
[Index("Almacen", Name = "almacen")]
[Index("Estado", Name = "estado")]
[Index("Inventario", Name = "inventario", IsUnique = true)]
[Index("Ubicacion", Name = "ubicacion")]
public partial class Invfi
{
    [Column("INVENTARIO")]
    public int? Inventario { get; set; }

    [Column("FECHA", TypeName = "datetime")]
    public DateTime? Fecha { get; set; }

    [Column("ALMACEN")]
    public short? Almacen { get; set; }

    [Column("OBSERV")]
    [StringLength(255)]
    public string? Observ { get; set; }

    [Column("VALOR")]
    public double? Valor { get; set; }

    [Column("ESTADO")]
    [StringLength(2)]
    public string? Estado { get; set; }

    [Column("ubicacion")]
    [StringLength(10)]
    public string? Ubicacion { get; set; }

    [Column("porubicacion")]
    public short? Porubicacion { get; set; }

    [Column("SSMA_TimeStamp")]
    public byte[] SsmaTimeStamp { get; set; } = null!;
}
