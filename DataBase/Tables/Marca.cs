using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Table("marcas")]
[Index("Marca1", Name = "marca", IsUnique = true)]
public partial class Marca
{
    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("Marca")]
    [StringLength(15)]
    public string Marca1 { get; set; } = null!;

    [StringLength(50)]
    public string? Descrip { get; set; }

    [StringLength(10)]
    public string? Usuario { get; set; }

    [Column("usuFecha", TypeName = "datetime")]
    public DateTime? UsuFecha { get; set; }

    [Column("usuHora")]
    [StringLength(8)]
    public string? UsuHora { get; set; }

    [InverseProperty("MarcaNavigation")]
    public virtual ICollection<Prod> Prods { get; set; } = new List<Prod>();
}
