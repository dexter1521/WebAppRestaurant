using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("entradas")]
[Index("Ensamble", Name = "ensamble")]
[Index("Entrada1", Name = "entrada", IsUnique = true)]
[Index("Estado", Name = "estado")]
[Index("Ocupado", Name = "ocupado")]
[Index("Proveedor", Name = "proveedor")]
public partial class Entrada
{
    [Column("Entrada")]
    public int? Entrada1 { get; set; }

    [Column("OCUPADO")]
    public short? Ocupado { get; set; }

    [Column("TIPO_DOC")]
    [StringLength(3)]
    public string? TipoDoc { get; set; }

    [Column("FACTURA")]
    [StringLength(30)]
    public string? Factura { get; set; }

    [Column("F_EMISION", TypeName = "datetime")]
    public DateTime? FEmision { get; set; }

    [Column("F_VENC", TypeName = "datetime")]
    public DateTime? FVenc { get; set; }

    [Column("PROVEEDOR")]
    [StringLength(10)]
    public string? Proveedor { get; set; }

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
    [StringLength(255)]
    public string? Observ { get; set; }

    [Column("TIPO_CAM")]
    public double? TipoCam { get; set; }

    [Column("MONEDA")]
    [StringLength(5)]
    public string? Moneda { get; set; }

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

    [StringLength(20)]
    public string? Sucursal { get; set; }

    [Column("ensamble")]
    public short? Ensamble { get; set; }

    [Column("SSMA_TimeStamp")]
    public byte[] SsmaTimeStamp { get; set; } = null!;

    [Column("pedimentos")]
    public string? Pedimentos { get; set; }
}
