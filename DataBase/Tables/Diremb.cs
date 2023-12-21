using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Table("diremb")]
[Index("Claveembarque", Name = "IX_diremb")]
[Index("Id", Name = "id", IsUnique = true)]
public partial class Diremb
{
    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("cliente")]
    [StringLength(30)]
    public string? Cliente { get; set; }

    public string? Direccion { get; set; }

    [Column("claveembarque")]
    [StringLength(30)]
    public string? Claveembarque { get; set; }

    [Column("SSMA_TimeStamp")]
    public byte[] SsmaTimeStamp { get; set; } = null!;
}
