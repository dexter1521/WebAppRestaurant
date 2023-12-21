using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("series")]
[Index("Articulo", Name = "articulo")]
[Index("Consec", Name = "consec")]
[Index("Consecsalida", Name = "consecsalida")]
[Index("Documento", Name = "documento")]
[Index("Id", Name = "id", IsUnique = true)]
[Index("Serie", Name = "serie")]
public partial class Series
{
    [Column("id")]
    public int? Id { get; set; }

    [Column("articulo")]
    [StringLength(30)]
    public string? Articulo { get; set; }

    [Column("serie")]
    [StringLength(50)]
    public string? Serie { get; set; }

    [Column("id_salida")]
    public int? IdSalida { get; set; }

    [Column("id_entrada")]
    public int? IdEntrada { get; set; }

    [StringLength(30)]
    public string? Documento { get; set; }

    [Column("numeroDocumento")]
    public int? NumeroDocumento { get; set; }

    [Column("puerto")]
    [StringLength(30)]
    public string? Puerto { get; set; }

    [Column("pedimento")]
    [StringLength(30)]
    public string? Pedimento { get; set; }

    [Column("fecha", TypeName = "datetime")]
    public DateTime? Fecha { get; set; }

    [Column("usufecha", TypeName = "datetime")]
    public DateTime? Usufecha { get; set; }

    [Column("usuhora")]
    [StringLength(10)]
    public string? Usuhora { get; set; }

    [Column("usuario")]
    [StringLength(10)]
    public string? Usuario { get; set; }

    [Column("tipo_doc")]
    [StringLength(3)]
    public string? TipoDoc { get; set; }

    [Column("no_referen")]
    public int? NoReferen { get; set; }

    [Column("numerooperacion")]
    public int? Numerooperacion { get; set; }

    [Column("consec")]
    public int? Consec { get; set; }

    [Column("consecsalida")]
    public int? Consecsalida { get; set; }

    [Column("entregado")]
    public short? Entregado { get; set; }

    [Column("numero")]
    [StringLength(40)]
    public string? Numero { get; set; }

    [Column("id_salida_serie")]
    public int? IdSalidaSerie { get; set; }

    [Column("ocupado")]
    public short? Ocupado { get; set; }

    [Column("entrada")]
    public short Entrada { get; set; }
}
