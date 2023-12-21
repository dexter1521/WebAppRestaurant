using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("r_ventasPorCobrar")]
public partial class RVentasPorCobrar
{
    [Column("mesa")]
    [StringLength(10)]
    public string Mesa { get; set; } = null!;

    [Column("venta")]
    public int Venta { get; set; }

    [Column("comensal")]
    public int Comensal { get; set; }

    [Column("importe")]
    public double Importe { get; set; }
}
