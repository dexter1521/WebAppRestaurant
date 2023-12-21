using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Table("c_RegimenFiscal")]
public partial class CRegimenFiscal
{
    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("clave")]
    [StringLength(3)]
    public string Clave { get; set; } = null!;

    [Column("descripcion")]
    [StringLength(350)]
    public string? Descripcion { get; set; }
}
