using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Table("reportesWeb")]
public partial class ReportesWeb
{
    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("reporte")]
    [StringLength(50)]
    [Unicode(false)]
    public string Reporte { get; set; } = null!;

    [Column("descripcion")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Descripcion { get; set; }

    [Column("busqueda1")]
    [StringLength(50)]
    [Unicode(false)]
    public string Busqueda1 { get; set; } = null!;

    [Column("busqueda2")]
    [StringLength(50)]
    [Unicode(false)]
    public string Busqueda2 { get; set; } = null!;

    [Column("busqueda3")]
    [StringLength(50)]
    [Unicode(false)]
    public string Busqueda3 { get; set; } = null!;

    [Column("busqueda4")]
    [StringLength(50)]
    [Unicode(false)]
    public string Busqueda4 { get; set; } = null!;

    [Column("numeroFiltros")]
    public int NumeroFiltros { get; set; }

    [Column("query")]
    [StringLength(1500)]
    [Unicode(false)]
    public string Query { get; set; } = null!;

    [Column("condicion1")]
    [StringLength(200)]
    [Unicode(false)]
    public string Condicion1 { get; set; } = null!;

    [Column("condicion2")]
    [StringLength(200)]
    [Unicode(false)]
    public string Condicion2 { get; set; } = null!;

    [Column("condicion3")]
    [StringLength(200)]
    [Unicode(false)]
    public string Condicion3 { get; set; } = null!;

    [Column("condicion4")]
    [StringLength(200)]
    [Unicode(false)]
    public string Condicion4 { get; set; } = null!;

    [Column("titulo")]
    [StringLength(180)]
    [Unicode(false)]
    public string Titulo { get; set; } = null!;

    [Column("catalogo")]
    [StringLength(180)]
    [Unicode(false)]
    public string? Catalogo { get; set; }

    [Column("total1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Total1 { get; set; }

    [Column("total2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Total2 { get; set; }

    [Column("total3")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Total3 { get; set; }

    [Column("total4")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Total4 { get; set; }

    [Column("queryTotales")]
    [StringLength(1500)]
    [Unicode(false)]
    public string? QueryTotales { get; set; }

    [Column("numeroTotales")]
    public int? NumeroTotales { get; set; }

    [Column("acumulado")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Acumulado { get; set; }

    [Column("encabezado1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Encabezado1 { get; set; }

    [Column("encabezado2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Encabezado2 { get; set; }

    [Column("encabezado3")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Encabezado3 { get; set; }
}
