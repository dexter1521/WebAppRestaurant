using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("op")]
[Index("Estado", Name = "estado")]
[Index("Ocupado", Name = "ocupado")]
[Index("Op1", Name = "op", IsUnique = true)]
public partial class Op
{
    [Column("op")]
    public int? Op1 { get; set; }

    [Column("OCUPADO")]
    public short? Ocupado { get; set; }

    [Column("TIPO_DOC")]
    [StringLength(3)]
    public string? TipoDoc { get; set; }

    [Column("F_EMISION", TypeName = "datetime")]
    public DateTime? FEmision { get; set; }

    [Column("IMPORTE")]
    public double? Importe { get; set; }

    [Column("COSTO")]
    public double? Costo { get; set; }

    [Column("ALMACEN")]
    public short? Almacen { get; set; }

    [Column("ESTADO")]
    [StringLength(2)]
    public string? Estado { get; set; }

    [Column("OBSERV")]
    public string? Observ { get; set; }

    [Column("DATOS")]
    [StringLength(255)]
    public string? Datos { get; set; }

    [Column("USUARIO")]
    [StringLength(10)]
    public string? Usuario { get; set; }

    [Column("USUFECHA", TypeName = "datetime")]
    public DateTime? Usufecha { get; set; }

    [Column("USUHORA")]
    [StringLength(8)]
    public string? Usuhora { get; set; }

    [Column("fechaentrega", TypeName = "datetime")]
    public DateTime? Fechaentrega { get; set; }

    [Column("automatico")]
    public short? Automatico { get; set; }

    [Column("ordencompra")]
    public int? Ordencompra { get; set; }

    [Column("cerrado")]
    public short Cerrado { get; set; }

    [Column("SSMA_TimeStamp")]
    public byte[] SsmaTimeStamp { get; set; } = null!;
}
