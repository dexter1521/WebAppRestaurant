using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("ControlProc")]
public partial class ControlProc
{
    [Column("ControlProc")]
    public short? ControlProc1 { get; set; }
}
