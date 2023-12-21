using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Table("r_comandas")]
public partial class RComanda
{
    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("mesa")]
    [StringLength(10)]
    public string? Mesa { get; set; }

    [Column("articulo")]
    public string? Articulo { get; set; }

    [Column("comensal")]
    public int? Comensal { get; set; }

    [Column("precio", TypeName = "smallmoney")]
    public decimal? Precio { get; set; }

    [Column("confirmado")]
    public int? Confirmado { get; set; }

    [Column("encaja")]
    public int? Encaja { get; set; }

    [Column("eliminado")]
    public short Eliminado { get; set; }

    [ForeignKey("Mesa")]
    [InverseProperty("RComanda")]
    public virtual RMesa? MesaNavigation { get; set; }

    [InverseProperty("IdComandaNavigation")]
    public virtual ICollection<RSeleccioncomensal> RSeleccioncomensals { get; set; } = new List<RSeleccioncomensal>();
}
