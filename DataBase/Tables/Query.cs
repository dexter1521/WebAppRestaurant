using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("query")]
[Index("Query1", Name = "query", IsUnique = true)]
public partial class Query
{
    [Column("Query")]
    [StringLength(240)]
    public string? Query1 { get; set; }

    [Column("sqlcol")]
    [StringLength(255)]
    public string? Sqlcol { get; set; }

    public short? Systema { get; set; }

    public int? Retorno { get; set; }

    [StringLength(10)]
    public string? Usuario { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UsuFecha { get; set; }

    [StringLength(8)]
    public string? Hora { get; set; }

    [StringLength(20)]
    public string? Procedimiento { get; set; }

    public int? Largo1 { get; set; }

    public int? Largo2 { get; set; }

    public int? Largo3 { get; set; }

    [StringLength(20)]
    public string? Retorno2 { get; set; }

    [StringLength(20)]
    public string? Formato1 { get; set; }

    [StringLength(20)]
    public string? Formato2 { get; set; }
}
