using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("TiempoAireR")]
public partial class TiempoAireR
{
    [StringLength(50)]
    [Unicode(false)]
    public string? TimeStamp { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Proveedor { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? Numero { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal? Monto { get; set; }

    [StringLength(20)]
    public string? Estacion { get; set; }

    [StringLength(10)]
    public string? Estatus { get; set; }
}
