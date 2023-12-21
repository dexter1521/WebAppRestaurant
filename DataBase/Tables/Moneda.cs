using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Table("monedas")]
[Index("Moneda1", Name = "moneda", IsUnique = true)]
public partial class Moneda
{
    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("Moneda")]
    [StringLength(5)]
    public string Moneda1 { get; set; } = null!;

    [StringLength(20)]
    public string? Nombre { get; set; }

    [StringLength(40)]
    public string? Descrip { get; set; }

    [Column("TC")]
    public double? Tc { get; set; }

    [Column("BASE")]
    public short? Base { get; set; }

    [StringLength(10)]
    public string? Usuario { get; set; }

    [Column("usuFecha", TypeName = "datetime")]
    public DateTime? UsuFecha { get; set; }

    [Column("usuHora")]
    [StringLength(8)]
    public string? UsuHora { get; set; }

    [Column("imagen")]
    [StringLength(250)]
    public string? Imagen { get; set; }

    [Column("SSMA_TimeStamp")]
    public byte[] SsmaTimeStamp { get; set; } = null!;
}
