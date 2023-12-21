using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Table("ifactura")]
public partial class Ifactura
{
    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("proveedor")]
    [StringLength(5)]
    public string? Proveedor { get; set; }

    [Column("fecha")]
    [StringLength(8)]
    public string? Fecha { get; set; }

    [Column("registros")]
    [StringLength(6)]
    public string? Registros { get; set; }

    [Column("cliente")]
    [StringLength(8)]
    public string? Cliente { get; set; }

    [Column("numerofactura")]
    [StringLength(10)]
    public string? Numerofactura { get; set; }

    [Column("numerofacturatienda")]
    [StringLength(3)]
    public string? Numerofacturatienda { get; set; }

    [Column("numerofacturasecciondepartamento")]
    [StringLength(15)]
    public string? Numerofacturasecciondepartamento { get; set; }

    [Column("fechaentrega")]
    [StringLength(8)]
    public string? Fechaentrega { get; set; }

    [Column("importeapagar")]
    [StringLength(12)]
    public string? Importeapagar { get; set; }

    [Column("importedescuento")]
    [StringLength(12)]
    public string? Importedescuento { get; set; }

    [Column("importetotal")]
    [StringLength(12)]
    public string? Importetotal { get; set; }

    [Column("importeiva")]
    [StringLength(12)]
    public string? Importeiva { get; set; }

    [Column("importeIEPS")]
    [StringLength(12)]
    public string? ImporteIeps { get; set; }

    [Column("totalproductos")]
    [StringLength(6)]
    public string? Totalproductos { get; set; }

    [Column("ventastasa0")]
    [StringLength(11)]
    public string? Ventastasa0 { get; set; }

    [Column("IVATasa10")]
    [StringLength(11)]
    public string? Ivatasa10 { get; set; }

    [StringLength(11)]
    public string? DescuentoVenta10 { get; set; }

    [Column("IVADescuentoVenta10")]
    [StringLength(11)]
    public string? IvadescuentoVenta10 { get; set; }

    [Column("IVAGlobal")]
    [StringLength(12)]
    public string? Ivaglobal { get; set; }

    [Column("IVADescuentoGlobal")]
    [StringLength(12)]
    public string? IvadescuentoGlobal { get; set; }

    [StringLength(4)]
    public string? NumeroDeBolsas { get; set; }

    [StringLength(5)]
    public string? NumeroDeBultos { get; set; }

    [StringLength(8)]
    public string? CodigoArticulo { get; set; }

    [StringLength(6)]
    public string? CantidadConCargo { get; set; }

    [StringLength(6)]
    public string? CantidadSinCargo { get; set; }

    [StringLength(5)]
    public string? DescuentoAdicional { get; set; }

    [StringLength(8)]
    public string? CostoPrecioFarmacia { get; set; }

    [StringLength(8)]
    public string? PrecioVenta { get; set; }

    [StringLength(8)]
    public string? ImporteTotalRenglon { get; set; }

    [StringLength(8)]
    public string? ImporteVentaRenglon { get; set; }

    [StringLength(8)]
    public string? ImporteIvaParaRenglon { get; set; }

    [Column("ImporteIEPSParaRenglon")]
    [StringLength(8)]
    public string? ImporteIepsparaRenglon { get; set; }

    [StringLength(1)]
    public string? AreaAcomodo { get; set; }

    [Column("CodigoEAN")]
    [StringLength(14)]
    public string? CodigoEan { get; set; }

    [StringLength(4)]
    public string? MargenUnitario { get; set; }

    [StringLength(1)]
    public string? ClasificacionFiscal { get; set; }

    [StringLength(1)]
    public string? Referencias { get; set; }

    [StringLength(1)]
    public string? VentaNeta { get; set; }
}
