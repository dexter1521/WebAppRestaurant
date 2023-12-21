using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Table("existenciaESTACION01")]
public partial class ExistenciaEstacion01
{
    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("articulo")]
    [StringLength(30)]
    [Unicode(false)]
    public string Articulo { get; set; } = null!;
}
