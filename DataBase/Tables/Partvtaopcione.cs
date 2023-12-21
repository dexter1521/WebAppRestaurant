using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("partvtaopciones")]
[Index("IdSalida", Name = "id_salida")]
public partial class Partvtaopcione
{
    [Column("id_salida")]
    public int? IdSalida { get; set; }

    [Column("articulo")]
    [StringLength(30)]
    public string? Articulo { get; set; }

    [Column("idopcion")]
    public int? Idopcion { get; set; }

    [Column("original")]
    [StringLength(30)]
    public string? Original { get; set; }
}
