using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("histcamb")]
[Index("Articulo", Name = "articulo")]
[Index("Bitacora", Name = "bitacora")]
[Index("Id", Name = "id", IsUnique = true)]
[Index("Usufecha", Name = "usufecha")]
public partial class Histcamb
{
    [Column("id")]
    public int? Id { get; set; }

    [Column("articulo")]
    [StringLength(30)]
    public string? Articulo { get; set; }

    [Column("sucursal")]
    [StringLength(20)]
    public string? Sucursal { get; set; }

    [Column("precio1")]
    public double? Precio1 { get; set; }

    [Column("precio2")]
    public double? Precio2 { get; set; }

    [Column("precio3")]
    public double? Precio3 { get; set; }

    [Column("precio4")]
    public double? Precio4 { get; set; }

    [Column("precio5")]
    public double? Precio5 { get; set; }

    [Column("precio6")]
    public double? Precio6 { get; set; }

    [Column("precio7")]
    public double? Precio7 { get; set; }

    [Column("precio8")]
    public double? Precio8 { get; set; }

    [Column("precio9")]
    public double? Precio9 { get; set; }

    [Column("precio10")]
    public double? Precio10 { get; set; }

    [Column("usufecha", TypeName = "datetime")]
    public DateTime? Usufecha { get; set; }

    [Column("usuhora")]
    [StringLength(8)]
    public string? Usuhora { get; set; }

    [Column("usuario")]
    [StringLength(10)]
    public string? Usuario { get; set; }

    public int? Bitacora { get; set; }

    [Column("existencia")]
    public double? Existencia { get; set; }

    [Column("precioold1")]
    public double? Precioold1 { get; set; }

    [Column("precioold2")]
    public double? Precioold2 { get; set; }

    [Column("precioold3")]
    public double? Precioold3 { get; set; }

    [Column("precioold4")]
    public double? Precioold4 { get; set; }

    [Column("precioold5")]
    public double? Precioold5 { get; set; }

    [Column("precioold6")]
    public double? Precioold6 { get; set; }

    [Column("precioold7")]
    public double? Precioold7 { get; set; }

    [Column("precioold8")]
    public double? Precioold8 { get; set; }

    [Column("precioold9")]
    public double? Precioold9 { get; set; }

    [Column("precioold10")]
    public double? Precioold10 { get; set; }

    [Column("c10")]
    public double? C10 { get; set; }

    [Column("c2")]
    public double? C2 { get; set; }

    [Column("c3")]
    public double? C3 { get; set; }

    [Column("c4")]
    public double? C4 { get; set; }

    [Column("c5")]
    public double? C5 { get; set; }

    [Column("c6")]
    public double? C6 { get; set; }

    [Column("c7")]
    public double? C7 { get; set; }

    [Column("c8")]
    public double? C8 { get; set; }

    [Column("c9")]
    public double? C9 { get; set; }

    [Column("SSMA_TimeStamp")]
    public byte[] SsmaTimeStamp { get; set; } = null!;
}
