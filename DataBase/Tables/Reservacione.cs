using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Table("reservaciones")]
[Index("Mesa", "Fecha", Name = "IX_reservaciones")]
public partial class Reservacione
{
    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("mesa")]
    [StringLength(10)]
    public string? Mesa { get; set; }

    [Column("fecha", TypeName = "smalldatetime")]
    public DateTime? Fecha { get; set; }

    [Column("tolerancia")]
    public int? Tolerancia { get; set; }

    [Column("reservado")]
    [StringLength(50)]
    public string? Reservado { get; set; }
}
