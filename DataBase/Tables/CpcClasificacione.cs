using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Table("cpc_clasificaciones")]
public partial class CpcClasificacione
{
    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("clasificacion")]
    [StringLength(30)]
    public string Clasificacion { get; set; } = null!;

    [Column("descripcion")]
    [StringLength(50)]
    public string? Descripcion { get; set; }
}
