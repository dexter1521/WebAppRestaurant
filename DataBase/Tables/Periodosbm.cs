using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("periodosbm")]
public partial class Periodosbm
{
    [Column(TypeName = "datetime")]
    public DateTime? VentasFechaIni { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? VentasFechaFin { get; set; }

    public short? VentasPorDias { get; set; }

    public int? VentasDias { get; set; }

    public short? VentasTodo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ComprasFechaIni { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ComprasFechaFin { get; set; }

    public short? ComprasPorDias { get; set; }

    public int? ComprasDias { get; set; }

    public short? ComprasTodo { get; set; }

    [Column("ESFechaIni", TypeName = "datetime")]
    public DateTime? EsfechaIni { get; set; }

    [Column("ESFechaFin", TypeName = "datetime")]
    public DateTime? EsfechaFin { get; set; }

    [Column("ESPorDias")]
    public short? EsporDias { get; set; }

    [Column("ESDias")]
    public int? Esdias { get; set; }

    [Column("ESTodo")]
    public short? Estodo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CobranzaIni { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CobranzaFin { get; set; }

    public short? SoloSaldo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CobroIni { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CobroFin { get; set; }

    public short? SoloCobroSaldo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CuenxpagIni { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CuenxpagFin { get; set; }

    public short? SoloCuenxpagSaldo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PagoIni { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PagoFin { get; set; }

    public short? SoloPagoSaldo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PedidosIni { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PedidosFin { get; set; }

    public short? PedidosAuto { get; set; }

    public int? PedidosDias { get; set; }

    public short? PedidosTodo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? OrdenIni { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? OrdenFin { get; set; }

    public short? OrdenAuto { get; set; }

    public int? OrdenDias { get; set; }

    public short? OrdenTodo { get; set; }

    public short? SoloDia { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FlujoIni { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FlujoFin { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PresupIni { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PresupFin { get; set; }

    [Column("PSoloDia")]
    public short? PsoloDia { get; set; }
}
