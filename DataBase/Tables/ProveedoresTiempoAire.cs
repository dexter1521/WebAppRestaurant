using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Table("proveedoresTiempoAire")]
public partial class ProveedoresTiempoAire
{
    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("proveedor")]
    public int Proveedor { get; set; }

    [Column("nombre")]
    [StringLength(15)]
    public string Nombre { get; set; } = null!;
}
