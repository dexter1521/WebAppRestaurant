using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("pedrecurrente")]
[Index("Cliente", Name = "cliente")]
[Index("Id", Name = "id", IsUnique = true)]
[Index("Partida", Name = "partida")]
public partial class Pedrecurrente
{
    [Column("id")]
    public int? Id { get; set; }

    [Column("cliente")]
    [StringLength(15)]
    public string? Cliente { get; set; }

    [Column("articulo")]
    [StringLength(30)]
    public string? Articulo { get; set; }

    [Column("cantidad")]
    public double? Cantidad { get; set; }

    [Column("partida")]
    public int? Partida { get; set; }

    [Column("fechaentrega", TypeName = "datetime")]
    public DateTime? Fechaentrega { get; set; }

    [Column("SSMA_TimeStamp")]
    public byte[] SsmaTimeStamp { get; set; } = null!;
}
