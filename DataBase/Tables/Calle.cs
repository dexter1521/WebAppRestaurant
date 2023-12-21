using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Table("calles")]
public partial class Calle
{
    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("calle")]
    [StringLength(50)]
    public string Calle1 { get; set; } = null!;
}
