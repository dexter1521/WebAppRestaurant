using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Table("r_mesas")]
public partial class RMesa
{
    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("mesa")]
    [StringLength(10)]
    public string Mesa { get; set; } = null!;

    [Column("estado")]
    [StringLength(10)]
    public string? Estado { get; set; }

    [Column("comensales")]
    public int? Comensales { get; set; }

    [Column("mesero")]
    [StringLength(50)]
    public string? Mesero { get; set; }

    [Column("propina_porcentaje", TypeName = "smallmoney")]
    public decimal? PropinaPorcentaje { get; set; }

    [Column("propina_importe", TypeName = "smallmoney")]
    public decimal? PropinaImporte { get; set; }

    [Column("unionmesa")]
    [StringLength(10)]
    public string? Unionmesa { get; set; }

    [Column("impresora")]
    [StringLength(30)]
    public string? Impresora { get; set; }

    [Column("operadaPorComandera")]
    public short OperadaPorComandera { get; set; }

    [Column("activa")]
    public short Activa { get; set; }

    [InverseProperty("MesaNavigation")]
    public virtual ICollection<RComanda> RComanda { get; set; } = new List<RComanda>();
}
