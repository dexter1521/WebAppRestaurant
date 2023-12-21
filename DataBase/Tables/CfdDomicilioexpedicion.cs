using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("cfd_domicilioexpedicion")]
public partial class CfdDomicilioexpedicion
{
    [Column("calle")]
    [StringLength(100)]
    public string? Calle { get; set; }

    [Column("numerointerior")]
    [StringLength(100)]
    public string? Numerointerior { get; set; }

    [Column("numeroexterior")]
    [StringLength(100)]
    public string? Numeroexterior { get; set; }

    [Column("colonia")]
    [StringLength(100)]
    public string? Colonia { get; set; }

    [Column("localidad")]
    [StringLength(100)]
    public string? Localidad { get; set; }

    [Column("municipio")]
    [StringLength(100)]
    public string? Municipio { get; set; }

    [Column("cp")]
    [StringLength(10)]
    public string? Cp { get; set; }

    [Column("pais")]
    [StringLength(30)]
    public string? Pais { get; set; }

    [Column("estado")]
    [StringLength(30)]
    public string? Estado { get; set; }
}
