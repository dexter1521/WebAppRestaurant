using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("oppart")]
[Index("Articulo", Name = "articulo")]
[Index("IdEntrada", Name = "id_entrada", IsUnique = true)]
[Index("Op", Name = "op")]
public partial class Oppart
{
    [Column("op")]
    public int? Op { get; set; }

    [Column("TIPO_DOC")]
    [StringLength(3)]
    public string? TipoDoc { get; set; }

    [Column("NO_REFEREN")]
    public int? NoReferen { get; set; }

    [Column("ARTICULO")]
    [StringLength(30)]
    public string? Articulo { get; set; }

    [Column("CANTIDAD")]
    public double? Cantidad { get; set; }

    [Column("PRECIO")]
    public double? Precio { get; set; }

    [Column("OBSERV")]
    [StringLength(255)]
    public string? Observ { get; set; }

    [Column("PARTIDA")]
    public int? Partida { get; set; }

    [Column("ID_ENTRADA")]
    public int? IdEntrada { get; set; }

    [StringLength(10)]
    public string? Usuario { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UsuFecha { get; set; }

    [StringLength(8)]
    public string? UsuHora { get; set; }

    [Column("terminado")]
    public double? Terminado { get; set; }

    [Column("SSMA_TimeStamp")]
    public byte[] SsmaTimeStamp { get; set; } = null!;
}
