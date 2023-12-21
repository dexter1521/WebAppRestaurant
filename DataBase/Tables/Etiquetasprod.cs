using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("etiquetasprod")]
[Index("Etiqueta", Name = "etiqueta")]
[Index("Foliopago", Name = "foliopago")]
[Index("Id", Name = "id", IsUnique = true)]
public partial class Etiquetasprod
{
    [Column("id")]
    public int? Id { get; set; }

    [Column("orden")]
    public int? Orden { get; set; }

    [Column("etapa")]
    [StringLength(5)]
    public string? Etapa { get; set; }

    [Column("articulo")]
    [StringLength(30)]
    public string? Articulo { get; set; }

    [Column("etiqueta")]
    [StringLength(30)]
    public string? Etiqueta { get; set; }

    [Column("id_entrada")]
    public int? IdEntrada { get; set; }

    [Column("etapaid")]
    public int? Etapaid { get; set; }

    [Column("empleado")]
    [StringLength(20)]
    public string? Empleado { get; set; }

    [Column("fecha", TypeName = "datetime")]
    public DateTime? Fecha { get; set; }

    [Column("hora")]
    [StringLength(8)]
    public string? Hora { get; set; }

    [Column("lectura")]
    public short? Lectura { get; set; }

    [Column("costo")]
    public double? Costo { get; set; }

    [Column("terminal")]
    public short? Terminal { get; set; }

    [Column("numerotira")]
    public int? Numerotira { get; set; }

    [Column("terminado")]
    public short? Terminado { get; set; }

    [Column("manoobra")]
    public double? Manoobra { get; set; }

    [Column("pagado")]
    public short? Pagado { get; set; }

    [Column("foliopago")]
    public int? Foliopago { get; set; }

    [Column("SSMA_TimeStamp")]
    public byte[] SsmaTimeStamp { get; set; } = null!;
}
