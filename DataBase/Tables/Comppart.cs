using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("comppart")]
[Index("Articulo", Name = "articulo")]
[Index("Componente", Name = "componente")]
[Index("Idpartida", Name = "idpartida")]
public partial class Comppart
{
    [Column("ARTICULO")]
    [StringLength(30)]
    public string? Articulo { get; set; }

    [Column("COMPONENTE")]
    [StringLength(30)]
    public string? Componente { get; set; }

    [Column("CANTIDAD")]
    public double? Cantidad { get; set; }

    [Column("ALMACEN")]
    public short? Almacen { get; set; }

    [StringLength(255)]
    public string? Observ { get; set; }

    [Column("IDPartida")]
    public int? Idpartida { get; set; }

    public double? Tiempo { get; set; }

    public short? Exportado { get; set; }

    [Column("ID")]
    public int? Id { get; set; }

    [Column("SSMA_TimeStamp")]
    public byte[] SsmaTimeStamp { get; set; } = null!;
}
