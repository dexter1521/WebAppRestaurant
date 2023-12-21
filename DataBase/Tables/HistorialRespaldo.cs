using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Table("historialRespaldos")]
public partial class HistorialRespaldo
{
    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("estacion")]
    [StringLength(30)]
    [Unicode(false)]
    public string Estacion { get; set; } = null!;

    [Column("ubicacionBD")]
    [StringLength(100)]
    [Unicode(false)]
    public string UbicacionBd { get; set; } = null!;

    [Column("ubicacionDestino")]
    [StringLength(100)]
    [Unicode(false)]
    public string UbicacionDestino { get; set; } = null!;

    [Column("ubicacionAdicional")]
    [StringLength(100)]
    [Unicode(false)]
    public string UbicacionAdicional { get; set; } = null!;

    [Column("nombreArchivo")]
    [StringLength(30)]
    [Unicode(false)]
    public string NombreArchivo { get; set; } = null!;

    [Column("hora")]
    [StringLength(15)]
    [Unicode(false)]
    public string Hora { get; set; } = null!;

    [Column("fecha")]
    [StringLength(30)]
    [Unicode(false)]
    public string Fecha { get; set; } = null!;
}
