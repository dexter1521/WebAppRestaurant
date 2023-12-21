using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Table("r_impresoras")]
public partial class RImpresora
{
    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("impresora")]
    [StringLength(30)]
    public string Impresora { get; set; } = null!;

    [Column("impresora_windows")]
    public string? ImpresoraWindows { get; set; }
}
