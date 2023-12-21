using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Table("consec")]
[Index("Dato", Name = "dato", IsUnique = true)]
public partial class Consec
{
    [Key] [Dapper.Contrib.Extensions.Key]
    [StringLength(40)]
    public string Dato { get; set; } = null!;

    [Column("Consec")]
    public int Consec1 { get; set; }
}
