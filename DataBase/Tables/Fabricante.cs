using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Table("fabricantes")]
[Index("Fabricante1", Name = "fabricante", IsUnique = true)]
public partial class Fabricante
{
    [Column("fabricante")]
    [StringLength(20)]
    public string Fabricante1 { get; set; } = null!;

    [Column("nombre")]
    [StringLength(100)]
    public string? Nombre { get; set; }

    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("id")]
    public int Id { get; set; }

    [InverseProperty("FabricanteNavigation")]
    public virtual ICollection<Prod> Prods { get; set; } = new List<Prod>();
}
