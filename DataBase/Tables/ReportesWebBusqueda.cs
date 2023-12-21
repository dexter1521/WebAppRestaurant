using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("reportesWebBusquedas")]
public partial class ReportesWebBusqueda
{
    [Column("busqueda")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Busqueda { get; set; }

    [Column("leyenda1")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Leyenda1 { get; set; }

    [Column("leyenda2")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Leyenda2 { get; set; }

    [Column("query")]
    [StringLength(1200)]
    [Unicode(false)]
    public string? Query { get; set; }

    [Column("claveReturned")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ClaveReturned { get; set; }

    [Column("descripcion")]
    [StringLength(250)]
    [Unicode(false)]
    public string? Descripcion { get; set; }

    [Column("titulo")]
    [StringLength(250)]
    [Unicode(false)]
    public string? Titulo { get; set; }

    [Column("buscarClave")]
    public int? BuscarClave { get; set; }

    [Column("queryBusqueda")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? QueryBusqueda { get; set; }
}
