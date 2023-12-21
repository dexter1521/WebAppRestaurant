using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Table("clientspocket")]
public partial class Clientspocket
{
    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("cliente")]
    [StringLength(30)]
    public string Cliente { get; set; } = null!;

    [Column("nombre")]
    public string Nombre { get; set; } = null!;

    [Column("calle")]
    public string? Calle { get; set; }

    [Column("colonia")]
    public string? Colonia { get; set; }

    [Column("telefono")]
    public string? Telefono { get; set; }

    [Column("cp")]
    [StringLength(5)]
    public string? Cp { get; set; }

    [Column("rfc")]
    [StringLength(20)]
    public string? Rfc { get; set; }

    [Column("saldo")]
    public double? Saldo { get; set; }

    [Column("dias")]
    public int? Dias { get; set; }

    [Column("credito")]
    public double? Credito { get; set; }
}
