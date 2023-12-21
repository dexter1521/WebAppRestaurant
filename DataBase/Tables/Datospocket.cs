using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("datospocket")]
public partial class Datospocket
{
    [Column("dato")]
    [StringLength(5)]
    public string Dato { get; set; } = null!;

    [Column("puerto")]
    public short Puerto { get; set; }

    [Column("ticket")]
    public short Ticket { get; set; }
}
