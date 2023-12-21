using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("periodos")]
[Index("Id", Name = "id", IsUnique = true)]
[Index("MonthCol", Name = "monthcol")]
[Index("YearCol", Name = "yearcol")]
public partial class Periodo
{
    [Column("ID")]
    public int? Id { get; set; }

    [Column("YearCOL")]
    public int? YearCol { get; set; }

    [Column("MonthCOL")]
    public int? MonthCol { get; set; }

    public short? Activo { get; set; }

    public short? Trabajo { get; set; }

    [StringLength(10)]
    public string? Usuario { get; set; }

    [Column("usuFecha", TypeName = "datetime")]
    public DateTime? UsuFecha { get; set; }

    [Column("usuHora")]
    [StringLength(8)]
    public string? UsuHora { get; set; }
}
