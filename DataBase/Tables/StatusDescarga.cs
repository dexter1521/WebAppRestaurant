using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("statusDescarga")]
public partial class StatusDescarga
{
    [Column("paso1")]
    public short Paso1 { get; set; }

    [Column("paso2")]
    public short Paso2 { get; set; }
}
