using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Table("r_componentes")]
public partial class RComponente
{
    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("id_menu")]
    public int IdMenu { get; set; }

    [Column("articulo")]
    public string? Articulo { get; set; }

    [Column("opcion1")]
    public string? Opcion1 { get; set; }

    [Column("opcion2")]
    public string? Opcion2 { get; set; }

    [Column("opcion3")]
    public string? Opcion3 { get; set; }
}
