using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
public partial class VFedatosFe
{
    [Column("venta")]
    public int Venta { get; set; }

    [Column("no_referen")]
    public int? NoReferen { get; set; }

    [Column("cliente")]
    [StringLength(30)]
    public string? Cliente { get; set; }

    [Column("nombre")]
    public string? Nombre { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Importe { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Impuesto { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Total { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Fecha { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string Serie { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string Folio { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string Estatus { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string? Emitir { get; set; }
}
