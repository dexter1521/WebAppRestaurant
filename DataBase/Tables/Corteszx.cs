using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("corteszx")]
public partial class Corteszx
{
    [Column("numeroCorte")]
    public int? NumeroCorte { get; set; }

    [Column("corte")]
    public string? Corte { get; set; }

    [Column("cadenaSalida")]
    public string? CadenaSalida { get; set; }

    [Column("totalVentas")]
    public double? TotalVentas { get; set; }

    [Column("estacion")]
    public string? Estacion { get; set; }

    [Column("usufecha", TypeName = "datetime")]
    public DateTime? Usufecha { get; set; }

    [Column("usuhora")]
    public string? Usuhora { get; set; }

    [Column("totalIngresos")]
    public double? TotalIngresos { get; set; }

    [Column("totalEgresos")]
    public double? TotalEgresos { get; set; }

    [Column("totalCaja")]
    public double? TotalCaja { get; set; }

    public double? Impuesto { get; set; }

    [Column("redondeo")]
    public double? Redondeo { get; set; }

    [Column("ventasCredito")]
    public double? VentasCredito { get; set; }

    [Column("valesEmitidos")]
    public double? ValesEmitidos { get; set; }

    [Column("valesCambio")]
    public double? ValesCambio { get; set; }

    [Column("ingresosCobranza")]
    public double? IngresosCobranza { get; set; }

    [Column("totalVentasUnidades")]
    public double? TotalVentasUnidades { get; set; }

    [Column("clientesAtendidos")]
    public int? ClientesAtendidos { get; set; }

    [Column("cajero")]
    public string? Cajero { get; set; }

    [Column("ventasGrabadas")]
    public double? VentasGrabadas { get; set; }

    [Column("ventasImpuesto10")]
    public double? VentasImpuesto10 { get; set; }

    [Column("impuesto10")]
    public double? Impuesto10 { get; set; }

    [Column("ventasImpuesto15")]
    public double? VentasImpuesto15 { get; set; }

    [Column("impuesto15")]
    public double? Impuesto15 { get; set; }

    [Column("numero")]
    public int? Numero { get; set; }

    [Column("importeCajero")]
    public double? ImporteCajero { get; set; }

    [Column("sucursal")]
    public string? Sucursal { get; set; }

    [Column("exportado")]
    public short? Exportado { get; set; }

    [Column("SSMA_TimeStamp")]
    public byte[] SsmaTimeStamp { get; set; } = null!;
}
