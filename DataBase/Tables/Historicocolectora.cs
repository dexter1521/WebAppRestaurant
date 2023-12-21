using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("historicocolectora")]
[Index("Articulo", Name = "articulo")]
[Index("Id", Name = "id", IsUnique = true)]
public partial class Historicocolectora
{
    [Column("id")]
    public int? Id { get; set; }

    [Column("articulo")]
    [StringLength(30)]
    public string? Articulo { get; set; }

    [Column("descrip")]
    [StringLength(100)]
    public string? Descrip { get; set; }

    [Column("cantidad")]
    public double? Cantidad { get; set; }

    [Column("nuevo")]
    public short? Nuevo { get; set; }

    [Column("presentacion")]
    [StringLength(50)]
    public string? Presentacion { get; set; }

    [Column("equivalencia")]
    public double? Equivalencia { get; set; }

    [Column("terminal")]
    [StringLength(50)]
    public string? Terminal { get; set; }

    [Column("scanner")]
    public short? Scanner { get; set; }

    [Column("fecha")]
    [StringLength(20)]
    public string? Fecha { get; set; }

    [Column("precio")]
    public double? Precio { get; set; }

    [Column("impuesto")]
    public double? Impuesto { get; set; }

    [Column("usuario")]
    [StringLength(10)]
    public string? Usuario { get; set; }

    [Column("SSMA_TimeStamp")]
    public byte[] SsmaTimeStamp { get; set; } = null!;
}
