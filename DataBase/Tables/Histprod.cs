using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("histprods")]
[Index("Articulo", Name = "articulo")]
[Index("Mesyear", Name = "mesyear")]
[Index("Month", Name = "month")]
[Index("MonthCol", Name = "monthcol")]
[Index("Year", Name = "year")]
[Index("YearCol", Name = "yearcol")]
public partial class Histprod
{
    [StringLength(15)]
    public string? Articulo { get; set; }

    public int? Month { get; set; }

    [Column("year")]
    public int? Year { get; set; }

    [Column("cantidad")]
    public double? Cantidad { get; set; }

    [Column("entrada", TypeName = "datetime")]
    public DateTime? Entrada { get; set; }

    [Column("activos")]
    public int? Activos { get; set; }

    [Column("clasificacion")]
    [StringLength(20)]
    public string? Clasificacion { get; set; }

    [Column("mesyear")]
    [StringLength(6)]
    public string? Mesyear { get; set; }

    [Column("meses")]
    public int? Meses { get; set; }

    [Column("MonthCOL")]
    public int? MonthCol { get; set; }

    [Column("yearCOL")]
    public int? YearCol { get; set; }

    [Column("SSMA_TimeStamp")]
    public byte[] SsmaTimeStamp { get; set; } = null!;
}
