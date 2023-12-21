using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Table("c_TipoDeComprobante")]
public partial class CTipoDeComprobante
{
    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("c_tipodecomprobante")]
    [StringLength(9)]
    public string CTipodecomprobante1 { get; set; } = null!;

    [Column("descripcion")]
    [StringLength(350)]
    public string? Descripcion { get; set; }
}
