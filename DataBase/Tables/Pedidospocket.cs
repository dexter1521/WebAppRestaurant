using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("pedidospocket")]
[Index("Articulo", Name = "articulo")]
[Index("Cliente", Name = "cliente")]
public partial class Pedidospocket
{
    [Column("cliente")]
    [StringLength(15)]
    public string Cliente { get; set; } = null!;

    [Column("articulo")]
    [StringLength(30)]
    public string Articulo { get; set; } = null!;

    [Column("cantidad")]
    public double Cantidad { get; set; }

    [Column("usuario")]
    [StringLength(15)]
    public string Usuario { get; set; } = null!;

    [Column("fecha")]
    [StringLength(10)]
    public string Fecha { get; set; } = null!;

    [Column("hora")]
    [StringLength(10)]
    public string Hora { get; set; } = null!;

    [Column("precio")]
    public double Precio { get; set; }

    [Column("impuesto")]
    public double Impuesto { get; set; }

    [Column("donativo")]
    public double Donativo { get; set; }

    [Column("almacen")]
    public short Almacen { get; set; }

    [Column("prcantidad")]
    public short Prcantidad { get; set; }

    [Column("clave")]
    [StringLength(30)]
    public string Clave { get; set; } = null!;

    [Column("presentacion")]
    public short Presentacion { get; set; }
}
