using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("tickettext")]
[Index("Id", Name = "id", IsUnique = true)]
public partial class Tickettext
{
    public string? TextHeader { get; set; }

    [Column("textend")]
    public string? Textend { get; set; }

    [Column("id")]
    public int? Id { get; set; }

    [Column("SSMA_TimeStamp")]
    public byte[] SsmaTimeStamp { get; set; } = null!;
}
