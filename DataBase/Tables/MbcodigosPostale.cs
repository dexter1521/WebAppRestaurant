using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
public partial class MbcodigosPostale
{
    [Column("CP")]
    [StringLength(10)]
    public string Cp { get; set; } = null!;

    [StringLength(50)]
    public string Ciudad { get; set; } = null!;

    [StringLength(50)]
    public string? Municipio { get; set; }

    [StringLength(50)]
    public string? Estado { get; set; }
}
