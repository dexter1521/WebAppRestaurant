using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Table("c_tipofactor")]
public partial class CTipofactor
{
    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("c_tipo")]
    [StringLength(10)]
    public string CTipo { get; set; } = null!;
}
