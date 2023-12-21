using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Table("r_menu")]
public partial class RMenu
{
    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("clasificacion")]
    [StringLength(50)]
    public string? Clasificacion { get; set; }

    [Column("subclasificacion")]
    [StringLength(50)]
    public string? Subclasificacion { get; set; }

    [Column("articulo")]
    [StringLength(30)]
    public string? Articulo { get; set; }

    [Column("descripcion1")]
    public string? Descripcion1 { get; set; }

    [Column("descripcion2")]
    public string? Descripcion2 { get; set; }

    [Column("descripcion3")]
    public string? Descripcion3 { get; set; }

    [Column("imagen")]
    public string? Imagen { get; set; }

    [Column("precio", TypeName = "smallmoney")]
    public decimal? Precio { get; set; }

    [Column("incluirencarta")]
    public bool? Incluirencarta { get; set; }

    [Column("impresora")]
    [Unicode(false)]
    public string? Impresora { get; set; }

    [ForeignKey("Articulo")]
    [InverseProperty("RMenus")]
    public virtual Prod? ArticuloNavigation { get; set; }

    [ForeignKey("Clasificacion")]
    [InverseProperty("RMenus")]
    public virtual RClasificacion? ClasificacionNavigation { get; set; }

    [InverseProperty("IdMenuNavigation")]
    public virtual ICollection<RSeleccioncomensal> RSeleccioncomensals { get; set; } = new List<RSeleccioncomensal>();

    [ForeignKey("Subclasificacion")]
    [InverseProperty("RMenus")]
    public virtual RSubclasificacion? SubclasificacionNavigation { get; set; }
}
