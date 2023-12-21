using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("tiempoAire")]
public partial class TiempoAire
{
    [Column("idTrans")]
    [StringLength(10)]
    public string IdTrans { get; set; } = null!;

    [Column("montoRecarga")]
    public double MontoRecarga { get; set; }

    [Column("telefono")]
    [StringLength(10)]
    public string Telefono { get; set; } = null!;

    [Column("nota")]
    [StringLength(50)]
    public string Nota { get; set; } = null!;

    [Column("transID")]
    [StringLength(20)]
    public string TransId { get; set; } = null!;

    [Column("proveedor")]
    [StringLength(10)]
    public string Proveedor { get; set; } = null!;

    [Column("venta")]
    public int Venta { get; set; }

    [Column("usuario")]
    [StringLength(10)]
    public string Usuario { get; set; } = null!;

    [Column("usufecha", TypeName = "datetime")]
    public DateTime Usufecha { get; set; }

    [Column("usuhora")]
    [StringLength(8)]
    public string Usuhora { get; set; } = null!;
}
