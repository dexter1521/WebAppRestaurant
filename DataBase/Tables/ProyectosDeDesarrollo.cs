using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Table("proyectosDeDesarrollo")]
public partial class ProyectosDeDesarrollo
{
    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("proyecto")]
    [StringLength(20)]
    public string Proyecto { get; set; } = null!;

    [Column("descripcion")]
    public string? Descripcion { get; set; }
}
