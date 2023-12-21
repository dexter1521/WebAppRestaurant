using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("movsuc")]
[Index("Id", Name = "id", IsUnique = true)]
[Index("Sucursal", Name = "sucursal")]
public partial class Movsuc
{
    [Column("id")]
    public int? Id { get; set; }

    [Column("consec")]
    public int? Consec { get; set; }

    [Column("articulo")]
    [StringLength(30)]
    public string? Articulo { get; set; }

    [Column("cantidad")]
    public double? Cantidad { get; set; }

    [Column("almacen")]
    public short? Almacen { get; set; }

    [Column("entsal")]
    [StringLength(1)]
    public string? Entsal { get; set; }

    [Column("sucursal")]
    [StringLength(20)]
    public string? Sucursal { get; set; }

    [Column("SSMA_TimeStamp")]
    public byte[] SsmaTimeStamp { get; set; } = null!;
}
