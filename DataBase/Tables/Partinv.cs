using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[PrimaryKey("Inventario", "Articulo")]
[Table("partinv")]
[Index("Articulo", "Inventario", Name = "articulo", IsUnique = true)]
[Index("Noencontrado", Name = "noencontrado")]
public partial class Partinv
{
    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("INVENTARIO")]
    public int Inventario { get; set; }

    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("ARTICULO")]
    [StringLength(30)]
    public string Articulo { get; set; } = null!;

    [Column("alm1")]
    public double? Alm1 { get; set; }

    [Column("EXISTENCIA")]
    public double? Existencia { get; set; }

    [Column("EREAL")]
    public double? Ereal { get; set; }

    [Column("ALMACEN")]
    public float? Almacen { get; set; }

    [Column("USUARIO")]
    [StringLength(10)]
    public string? Usuario { get; set; }

    [Column("USUFECHA", TypeName = "datetime")]
    public DateTime? Usufecha { get; set; }

    [Column("USUHORA")]
    [StringLength(8)]
    public string? Usuhora { get; set; }

    [Column("CLAVEADD")]
    [StringLength(30)]
    public string? Claveadd { get; set; }

    [Column("PRCANTIDAD")]
    public double? Prcantidad { get; set; }

    [Column("marbete")]
    public int? Marbete { get; set; }

    [Column("conteo1")]
    public double? Conteo1 { get; set; }

    [Column("conteo2")]
    public double? Conteo2 { get; set; }

    [Column("noencontrado")]
    public short? Noencontrado { get; set; }

    [Column("observ")]
    [StringLength(100)]
    public string? Observ { get; set; }

    [Column("SSMA_TimeStamp")]
    public byte[] SsmaTimeStamp { get; set; } = null!;
}
