using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("designe")]
[Index("Formato", Name = "formato", IsUnique = true)]
public partial class Designe
{
    [StringLength(35)]
    public string? Formato { get; set; }

    public string? Codigo { get; set; }

    [Column("SSMA_TimeStamp")]
    public byte[] SsmaTimeStamp { get; set; } = null!;
}
