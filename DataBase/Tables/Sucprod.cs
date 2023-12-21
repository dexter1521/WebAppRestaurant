using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("sucprod")]
[Index("Activo", Name = "activo")]
[Index("Articulo", Name = "articulo")]
[Index("Sucursal", Name = "sucursal")]
public partial class Sucprod
{
    [StringLength(30)]
    public string? Articulo { get; set; }

    [StringLength(20)]
    public string? Sucursal { get; set; }

    public short? Activo { get; set; }

    public double? Precio1 { get; set; }

    public double? Util1 { get; set; }

    public double? Precio2 { get; set; }

    public double? Util2 { get; set; }

    public double? Precio3 { get; set; }

    public double? Util3 { get; set; }

    public double? Precio4 { get; set; }

    public double? Util4 { get; set; }

    public double? Precio5 { get; set; }

    public double? Util5 { get; set; }

    public double? Precio6 { get; set; }

    public double? Util6 { get; set; }

    public double? Precio7 { get; set; }

    public double? Util7 { get; set; }

    public double? Precio8 { get; set; }

    public double? Util8 { get; set; }

    public double? Precio9 { get; set; }

    public double? Util9 { get; set; }

    public double? Precio10 { get; set; }

    public double? Util10 { get; set; }

    public double? Cantidad1 { get; set; }

    public double? Cantidad2 { get; set; }

    public double? Cantidad3 { get; set; }

    public double? Cantidad4 { get; set; }

    public double? Cantidad5 { get; set; }

    public double? Cantidad6 { get; set; }

    public double? Cantidad7 { get; set; }

    public double? Cantidad8 { get; set; }

    public double? Cantidad9 { get; set; }

    public double? Cantidad10 { get; set; }

    [Column("SSMA_TimeStamp")]
    public byte[] SsmaTimeStamp { get; set; } = null!;
}
