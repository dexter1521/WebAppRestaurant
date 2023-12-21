using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("sincronizacionenlinea")]
public partial class Sincronizacionenlinea
{
    [Column("dato")]
    [StringLength(15)]
    public string Dato { get; set; } = null!;

    [Column("valor")]
    public byte Valor { get; set; }
}
