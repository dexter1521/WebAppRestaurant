using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Table("suscripciones")]
[Index("Articulo", Name = "IX_suscripciones")]
public partial class Suscripcione
{
    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("cliente")]
    [StringLength(20)]
    public string? Cliente { get; set; }

    [Column("articulo")]
    [StringLength(30)]
    public string? Articulo { get; set; }

    [Column("cp")]
    [StringLength(5)]
    public string? Cp { get; set; }

    [Column("calle")]
    [StringLength(50)]
    public string? Calle { get; set; }

    [Column("colonia")]
    [StringLength(50)]
    public string? Colonia { get; set; }

    [Column("poblacion")]
    [StringLength(50)]
    public string? Poblacion { get; set; }

    [Column("ciudad")]
    [StringLength(50)]
    public string? Ciudad { get; set; }

    [Column("responsable")]
    [StringLength(50)]
    public string? Responsable { get; set; }

    [Column("telefono")]
    [StringLength(50)]
    public string? Telefono { get; set; }

    [Column("volumenes")]
    public int? Volumenes { get; set; }

    [Column("serieDocumento")]
    [StringLength(10)]
    public string? SerieDocumento { get; set; }

    [Column("factura")]
    [StringLength(10)]
    public string? Factura { get; set; }

    [Column("modoentrega")]
    [StringLength(10)]
    public string? Modoentrega { get; set; }
}
