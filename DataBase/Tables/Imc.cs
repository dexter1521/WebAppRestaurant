using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Table("imc")]
public partial class Imc
{
    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("nombre")]
    public string? Nombre { get; set; }

    [Column("edad")]
    public int? Edad { get; set; }

    [Column("sexo")]
    [StringLength(1)]
    public string? Sexo { get; set; }

    [Column("estatura")]
    public double? Estatura { get; set; }

    [Column("peso")]
    public double? Peso { get; set; }

    [Column("imc")]
    public double? Imc1 { get; set; }

    [Column("fecha", TypeName = "smalldatetime")]
    public DateTime? Fecha { get; set; }
}
