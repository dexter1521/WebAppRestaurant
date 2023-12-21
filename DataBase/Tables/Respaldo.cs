using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("respaldos")]
public partial class Respaldo
{
    [Column("estacion")]
    [StringLength(30)]
    [Unicode(false)]
    public string Estacion { get; set; } = null!;

    [Column("basededatos")]
    [StringLength(50)]
    [Unicode(false)]
    public string Basededatos { get; set; } = null!;

    [Column("destino")]
    [StringLength(50)]
    [Unicode(false)]
    public string Destino { get; set; } = null!;

    [Column("destinoAdicional")]
    [StringLength(50)]
    [Unicode(false)]
    public string? DestinoAdicional { get; set; }

    [Column("unaVez")]
    public byte? UnaVez { get; set; }

    [Column("enFecha", TypeName = "datetime")]
    public DateTime? EnFecha { get; set; }

    [Column("unaCadaDia")]
    public int? UnaCadaDia { get; set; }

    [Column("unaCadaTiempo")]
    [StringLength(20)]
    [Unicode(false)]
    public string? UnaCadaTiempo { get; set; }

    [Column("unaCada_ultimaFecha", TypeName = "datetime")]
    public DateTime UnaCadaUltimaFecha { get; set; }

    [Column("porSemana")]
    [StringLength(100)]
    [Unicode(false)]
    public string? PorSemana { get; set; }

    [Column("hora")]
    public int Hora { get; set; }

    [Column("minuto")]
    public int Minuto { get; set; }

    [Column("am_pm")]
    [StringLength(5)]
    [Unicode(false)]
    public string? AmPm { get; set; }
}
