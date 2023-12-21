using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("salpart")]
[Index("Articulo", Name = "articulo")]
[Index("Claveadd", Name = "claveadd")]
[Index("Ensamble", Name = "ensamble")]
[Index("IdSalida", Name = "id_salida", IsUnique = true)]
[Index("Salida", Name = "salida")]
public partial class Salpart
{
    [Column("SALIDA")]
    public int? Salida { get; set; }

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

    [Column("ID_SALIDA")]
    public int? IdSalida { get; set; }

    [StringLength(10)]
    public string? Usuario { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UsuFecha { get; set; }

    [StringLength(8)]
    public string? UsuHora { get; set; }

    [Column("PRCANTIDAD")]
    public int? Prcantidad { get; set; }

    [Column("PRDESCRIP")]
    [StringLength(40)]
    public string? Prdescrip { get; set; }

    [Column("CLAVEADD")]
    [StringLength(30)]
    public string? Claveadd { get; set; }

    [Column("costo")]
    public double? Costo { get; set; }

    [Column("ensamble")]
    public short? Ensamble { get; set; }

    [Column("SSMA_TimeStamp")]
    public byte[] SsmaTimeStamp { get; set; } = null!;
}
