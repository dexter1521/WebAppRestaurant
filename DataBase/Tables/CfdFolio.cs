using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Table("cfd_folios")]
public partial class CfdFolio
{
    [Key] [Dapper.Contrib.Extensions.Key]
    public long Id { get; set; }

    [StringLength(100)]
    public string? Serie { get; set; }

    public long? RangoInferior { get; set; }

    public long? RangoSuperior { get; set; }

    [Column("numeroAutorizacion")]
    [StringLength(50)]
    public string? NumeroAutorizacion { get; set; }

    [Column("anoAprobacion")]
    [StringLength(50)]
    public string? AnoAprobacion { get; set; }

    [Column("ultimoFolioUsado")]
    public long? UltimoFolioUsado { get; set; }

    [Column("certificado")]
    [StringLength(250)]
    public string? Certificado { get; set; }

    [Column("llaveprivada")]
    [StringLength(250)]
    public string? Llaveprivada { get; set; }

    [Column("clave")]
    [StringLength(250)]
    public string? Clave { get; set; }

    [Column("fechaCaducidad", TypeName = "smalldatetime")]
    public DateTime? FechaCaducidad { get; set; }
}
