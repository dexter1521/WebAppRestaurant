using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("ParametrosMalla")]
public partial class ParametrosMalla
{
    [Column("id")]
    public int? Id { get; set; }

    [Column("cClave")]
    [StringLength(50)]
    public string? CClave { get; set; }

    [StringLength(10)]
    public string? Usuario { get; set; }

    [Column("nAlmacen")]
    public int? NAlmacen { get; set; }

    [StringLength(50)]
    public string? Modo { get; set; }

    [Column("En_Venta")]
    public int? EnVenta { get; set; }

    [Column("Por_Surtir")]
    public int? PorSurtir { get; set; }

    public int? BolSalida { get; set; }

    public int? Operacion { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Proveedor { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Modulo { get; set; }
}
