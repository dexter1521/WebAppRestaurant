using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[PrimaryKey("Municipio", "Estado")]
[Table("codigospostales_mexico_municipios")]
public partial class CodigospostalesMexicoMunicipio
{
    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("municipio")]
    [StringLength(10)]
    public string Municipio { get; set; } = null!;

    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("estado")]
    [StringLength(10)]
    public string Estado { get; set; } = null!;

    [Column("nombre")]
    [StringLength(50)]
    public string? Nombre { get; set; }
}
