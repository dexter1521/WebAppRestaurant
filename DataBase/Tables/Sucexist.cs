using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("sucexist")]
public partial class Sucexist
{
    [StringLength(20)]
    public string? Sucursal { get; set; }

    [StringLength(30)]
    public string? Articulo { get; set; }

    [Column("existencia")]
    public double? Existencia { get; set; }

    [Column("alm1")]
    public double? Alm1 { get; set; }

    [Column("alm2")]
    public double? Alm2 { get; set; }

    [Column("alm3")]
    public double? Alm3 { get; set; }

    [Column("alm4")]
    public double? Alm4 { get; set; }

    [Column("alm5")]
    public double? Alm5 { get; set; }

    [Column("alm6")]
    public double? Alm6 { get; set; }

    [Column("alm7")]
    public double? Alm7 { get; set; }

    [Column("alm8")]
    public double? Alm8 { get; set; }

    [Column("alm9")]
    public double? Alm9 { get; set; }

    [Column("alm10")]
    public double? Alm10 { get; set; }

    [Column("SSMA_TimeStamp")]
    public byte[] SsmaTimeStamp { get; set; } = null!;
}
