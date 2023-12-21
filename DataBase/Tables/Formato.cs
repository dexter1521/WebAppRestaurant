using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("formatos")]
[Index("Catalogo", Name = "catalogo")]
[Index("Formato1", Name = "formato", IsUnique = true)]
public partial class Formato
{
    [StringLength(20)]
    public string? Catalogo { get; set; }

    public string? Codigo { get; set; }

    [StringLength(100)]
    public string? Descrip { get; set; }

    [Column("Formato")]
    [StringLength(35)]
    public string? Formato1 { get; set; }

    [Column("GRUPO")]
    [StringLength(20)]
    public string? Grupo { get; set; }

    [StringLength(255)]
    public string? Observ { get; set; }

    [StringLength(20)]
    public string? Tipo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UsuFecha { get; set; }

    [StringLength(8)]
    public string? UsuHora { get; set; }

    [StringLength(10)]
    public string? Usuario { get; set; }

    [Column("SSMA_TimeStamp")]
    public byte[] SsmaTimeStamp { get; set; } = null!;
}
