using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("r_cuentasPorComensal")]
public partial class RCuentasPorComensal
{
    [Column("mesa")]
    [StringLength(10)]
    public string Mesa { get; set; } = null!;

    [Column("comensal")]
    public int Comensal { get; set; }

    [Column("descuento")]
    public double Descuento { get; set; }

    [Column("importe")]
    public double Importe { get; set; }

    [Column("impresa")]
    public short Impresa { get; set; }
}
