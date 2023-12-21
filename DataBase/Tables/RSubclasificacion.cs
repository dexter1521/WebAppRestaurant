using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Table("r_subclasificacion")]
public partial class RSubclasificacion
{
    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("subclasificacion")]
    [StringLength(50)]
    public string Subclasificacion { get; set; } = null!;

    [Column("clasificacion")]
    [StringLength(50)]
    public string? Clasificacion { get; set; }

    [Column("descripcion")]
    public string? Descripcion { get; set; }

    [ForeignKey("Clasificacion")]
    [InverseProperty("RSubclasificacions")]
    public virtual RClasificacion? ClasificacionNavigation { get; set; }

    [InverseProperty("SubclasificacionNavigation")]
    public virtual ICollection<RMenu> RMenus { get; set; } = new List<RMenu>();
}
