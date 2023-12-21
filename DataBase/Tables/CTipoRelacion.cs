using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Table("c_TipoRelacion")]
public partial class CTipoRelacion
{
    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("c_tiporelacion")]
    [StringLength(9)]
    public string CTiporelacion1 { get; set; } = null!;

    [Column("descripcion")]
    [StringLength(350)]
    public string? Descripcion { get; set; }
}
