using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("codigospostales_mexico")]
[Index("Ciudad", Name = "IX_codigospostales_mexico")]
[Index("Estado", Name = "IX_codigospostales_mexico_1")]
[Index("Municipio", Name = "IX_codigospostales_mexico_2")]
[Index("Cp", Name = "IX_codigospostales_mexico_3")]
public partial class CodigospostalesMexico
{
    [Column("CP")]
    [StringLength(10)]
    public string Cp { get; set; } = null!;

    [Column("municipio")]
    [StringLength(10)]
    public string? Municipio { get; set; }

    [Column("ciudad")]
    [StringLength(10)]
    public string? Ciudad { get; set; }

    [Column("estado")]
    [StringLength(10)]
    public string? Estado { get; set; }

    [Column("usuario")]
    public string? Usuario { get; set; }
}
