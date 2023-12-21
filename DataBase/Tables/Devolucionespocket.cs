using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("devolucionespocket")]
[Index("Articulo", Name = "articulo")]
[Index("Cliente", Name = "cliente")]
public partial class Devolucionespocket
{
    [Column("cliente")]
    [StringLength(30)]
    public string Cliente { get; set; } = null!;

    [Column("articulo")]
    [StringLength(30)]
    public string Articulo { get; set; } = null!;

    [Column("descrip")]
    [StringLength(200)]
    public string Descrip { get; set; } = null!;

    [Column("cantidad")]
    public double Cantidad { get; set; }

    [Column("precio")]
    public double Precio { get; set; }

    [Column("impuesto")]
    public double Impuesto { get; set; }

    [Column("presentacion")]
    [StringLength(30)]
    public string Presentacion { get; set; } = null!;

    [Column("usuario")]
    [StringLength(10)]
    public string Usuario { get; set; } = null!;

    [Column("usufecha", TypeName = "datetime")]
    public DateTime Usufecha { get; set; }

    [Column("usuhora")]
    [StringLength(8)]
    public string Usuhora { get; set; } = null!;
}
