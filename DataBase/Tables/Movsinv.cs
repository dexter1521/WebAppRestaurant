using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Table("movsinv")]
[Index("Articulo", "FMovim", "EntSal", Name = "IX_movsinv")]
[Index("Articulo", Name = "articulo")]
[Index("FMovim", "Hora", Name = "f_movim")]
[Index("Movimiento", Name = "movimiento")]
[Index("Operacion", Name = "operacion")]
[Index("TipoMovim", Name = "tipo_movim")]
public partial class Movsinv
{
    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("CONSEC")]
    public int Consec { get; set; }

    [Column("OPERACION")]
    [StringLength(3)]
    public string? Operacion { get; set; }

    [Column("MOVIMIENTO")]
    public int? Movimiento { get; set; }

    [Column("ENT_SAL")]
    [StringLength(1)]
    public string? EntSal { get; set; }

    [Column("TIPO_MOVIM")]
    [StringLength(25)]
    public string? TipoMovim { get; set; }

    [Column("NO_REFEREN")]
    public int? NoReferen { get; set; }

    [Column("ARTICULO")]
    [StringLength(30)]
    public string? Articulo { get; set; }

    [Column("F_MOVIM", TypeName = "datetime")]
    public DateTime FMovim { get; set; }

    [Column("hora")]
    [StringLength(8)]
    public string? Hora { get; set; }

    [Column("CANTIDAD")]
    public double? Cantidad { get; set; }

    [Column("COSTO")]
    public double? Costo { get; set; }

    [Column("COSTOPROMEDIO")]
    public double? Costopromedio { get; set; }

    [Column("EXISTENCIA")]
    public double? Existencia { get; set; }

    [Column("VALOR")]
    public double? Valor { get; set; }

    [Column("ALMACEN")]
    public short? Almacen { get; set; }

    [Column("EXIST_ALM")]
    public double? ExistAlm { get; set; }

    [Column("PRECIO_VTA")]
    public double? PrecioVta { get; set; }

    [Column("POR_COSTEA")]
    public double? PorCostea { get; set; }

    [Column("PARTIDA")]
    public short? Partida { get; set; }

    public short? Cerrado { get; set; }

    [StringLength(10)]
    public string? Usuario { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UsuFecha { get; set; }

    [StringLength(8)]
    public string? UsuHora { get; set; }

    [Column("CLAVEADD")]
    [StringLength(30)]
    public string? Claveadd { get; set; }

    [Column("PRCANTIDAD")]
    public double? Prcantidad { get; set; }

    [Column("ID_SALIDA")]
    public int? IdSalida { get; set; }

    [Column("ID_ENTRADA")]
    public int? IdEntrada { get; set; }

    [Column("REORDENA")]
    public int? Reordena { get; set; }

    [Column("inicial")]
    public short? Inicial { get; set; }

    [Column("exportado")]
    public short? Exportado { get; set; }

    [Column("verificado")]
    public short? Verificado { get; set; }

    [Column("inventariofisico")]
    public int? Inventariofisico { get; set; }

    [Column("donativo")]
    public double? Donativo { get; set; }

    [Column("precio_vta_original")]
    public double? PrecioVtaOriginal { get; set; }

    [Column("afectacosto")]
    public short? Afectacosto { get; set; }

    [Column("SSMA_TimeStamp")]
    public byte[] SsmaTimeStamp { get; set; } = null!;
}
