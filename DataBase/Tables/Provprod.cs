using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[PrimaryKey("Articulo", "Proveedor")]
[Table("provprod")]
[Index("Articulo", Name = "articulo")]
[Index("Proveedor", Name = "proveedor")]
public partial class Provprod
{
    [Key] [Dapper.Contrib.Extensions.Key]
    [StringLength(30)]
    public string Articulo { get; set; } = null!;

    [Key] [Dapper.Contrib.Extensions.Key]
    [StringLength(10)]
    public string Proveedor { get; set; } = null!;

    [Column("COMPRA")]
    public int Compra { get; set; }

    public short Principal { get; set; }

    public double Desc1 { get; set; }

    public double Desc2 { get; set; }

    public double Desc3 { get; set; }

    public double Retrazo { get; set; }

    [Column("ult_costo")]
    public double UltCosto { get; set; }

    [Column("ult_comp")]
    [StringLength(10)]
    public string? UltComp { get; set; }

    [Column("SSMA_TimeStamp")]
    public byte[] SsmaTimeStamp { get; set; } = null!;
}
