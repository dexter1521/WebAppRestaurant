using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Table("codigospostales_mexico_estados")]
public partial class CodigospostalesMexicoEstado
{
    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("estado")]
    [StringLength(10)]
    public string Estado { get; set; } = null!;

    [Column("nombre")]
    [StringLength(50)]
    public string? Nombre { get; set; }
}
