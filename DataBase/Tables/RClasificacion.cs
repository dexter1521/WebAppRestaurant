using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Table("r_clasificacion")]
public partial class RClasificacion
{
    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("clasificacion")]
    [StringLength(50)]
    public string Clasificacion { get; set; } = null!;

    [Column("descripcion")]
    public string? Descripcion { get; set; }

    [Column("incluirencarta")]
    public bool? Incluirencarta { get; set; }

    [InverseProperty("ClasificacionNavigation")]
    public virtual ICollection<RMenu> RMenus { get; set; } = new List<RMenu>();

    [InverseProperty("ClasificacionNavigation")]
    public virtual ICollection<RSubclasificacion> RSubclasificacions { get; set; } = new List<RSubclasificacion>();
}
