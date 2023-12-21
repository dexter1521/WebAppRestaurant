using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Table("c_UsoCFDI")]
public partial class CUsoCfdi
{
    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("c_usocfdi")]
    [StringLength(9)]
    public string CUsocfdi1 { get; set; } = null!;

    [Column("descripcion")]
    [StringLength(350)]
    public string? Descripcion { get; set; }
}
