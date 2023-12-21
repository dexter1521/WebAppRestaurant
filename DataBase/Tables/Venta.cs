using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Table("ventas")]
[Index("Uuid", Name = "IX_UUID")]
[Index("Caja", Name = "caja")]
[Index("Cierre", Name = "cierre")]
[Index("Cliente", Name = "cliente")]
[Index("Corte", Name = "corte")]
[Index("SerieDocumento", "TipoDoc", "NoReferen", "Ticket", Name = "documento", IsUnique = true)]
[Index("Estado", Name = "estado")]
[Index("FEmision", Name = "f_emision")]
[Index("Fechacierre", Name = "fechacierre")]
[Index("OrigenDev", Name = "origendev")]
[Index("Pagado", Name = "pagado")]
[Index("Paraconcentrador", Name = "paraconcentrador")]
[Index("Sucremota", Name = "sucremota")]
[Index("Ticket", Name = "ticket")]
[Index("Vend", Name = "vend")]
[Index("Venta1", Name = "venta", IsUnique = true)]
[Index("Ventaref", Name = "ventaref")]
[Index("Ventaremota", Name = "ventaremota")]
[Index("VentaSuc", Name = "ventasuc")]
public partial class Venta
{
    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("VENTA")]
    public int Venta1 { get; set; }

    [Column("OCUPADO")]
    public short? Ocupado { get; set; }

    [Column("TIPO_DOC")]
    [StringLength(3)]
    public string? TipoDoc { get; set; }

    [Column("serieDocumento")]
    [StringLength(30)]
    public string? SerieDocumento { get; set; }

    [Column("NO_REFEREN")]
    public int? NoReferen { get; set; }

    [Column("F_EMISION", TypeName = "datetime")]
    public DateTime? FEmision { get; set; }

    [Column("F_VENC", TypeName = "datetime")]
    public DateTime? FVenc { get; set; }

    [Column("CLIENTE")]
    [StringLength(30)]
    public string? Cliente { get; set; }

    [Column("VEND")]
    [StringLength(15)]
    public string? Vend { get; set; }

    [Column("IMPORTE")]
    public double? Importe { get; set; }

    [Column("DESCUENTO")]
    public double? Descuento { get; set; }

    [Column("IMPUESTO")]
    public double? Impuesto { get; set; }

    [Column("PRECIO")]
    public short? Precio { get; set; }

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

    [Column("DESC1")]
    public double? Desc1 { get; set; }

    [Column("DESC2")]
    public double? Desc2 { get; set; }

    [Column("DESC3")]
    public double? Desc3 { get; set; }

    [Column("DESC4")]
    public double? Desc4 { get; set; }

    [Column("DESC5")]
    public double? Desc5 { get; set; }

    [Column("DATOS")]
    [Unicode(false)]
    public string? Datos { get; set; }

    [Column("ENFAC")]
    public short Enfac { get; set; }

    [Column("VENTAREF")]
    public int? Ventaref { get; set; }

    [Column("CIERRE")]
    public short Cierre { get; set; }

    [Column("cierretienda")]
    public short Cierretienda { get; set; }

    [Column("DESGLOSE")]
    public short? Desglose { get; set; }

    [Column("COBRANZA")]
    public int? Cobranza { get; set; }

    [Column("USUARIO")]
    [StringLength(10)]
    public string? Usuario { get; set; }

    [Column("USUFECHA", TypeName = "datetime")]
    public DateTime? Usufecha { get; set; }

    [Column("USUHORA")]
    [StringLength(8)]
    public string? Usuhora { get; set; }

    [Column("AUTO")]
    public short? Auto { get; set; }

    [StringLength(30)]
    public string? Relacion { get; set; }

    [Column("PEDCLI")]
    [StringLength(20)]
    public string? Pedcli { get; set; }

    [Column("PEMB")]
    [StringLength(40)]
    public string? Pemb { get; set; }

    [Column("DATEMB")]
    [StringLength(255)]
    public string? Datemb { get; set; }

    [StringLength(255)]
    public string? AplicarDes { get; set; }

    [StringLength(20)]
    public string? TipoVenta { get; set; }

    public short? Exportado { get; set; }

    [Column("SUCURSAL")]
    [StringLength(20)]
    public string? Sucursal { get; set; }

    public int? VentaSuc { get; set; }

    public double? Pago1 { get; set; }

    public double? Pago2 { get; set; }

    [StringLength(3)]
    public string? Concepto1 { get; set; }

    [StringLength(3)]
    public string? Concepto2 { get; set; }

    public double? Pago3 { get; set; }

    [StringLength(3)]
    public string? Concepto3 { get; set; }

    public double? Comision { get; set; }

    public int? VentaOrigen { get; set; }

    public short? Diario { get; set; }

    [StringLength(20)]
    public string? Caja { get; set; }

    public int? OrigenDev { get; set; }

    [StringLength(1)]
    public string? Corte { get; set; }

    [StringLength(1)]
    public string? Impreso { get; set; }

    [Column("BANCO")]
    [StringLength(30)]
    public string? Banco { get; set; }

    [StringLength(50)]
    public string? NumeroCheque { get; set; }

    [Column("estacion")]
    [StringLength(20)]
    public string? Estacion { get; set; }

    [Column("interes")]
    public double? Interes { get; set; }

    [Column("redondeo")]
    public double? Redondeo { get; set; }

    public short Ticket { get; set; }

    [Column("importar")]
    public short? Importar { get; set; }

    [Column("sucremota")]
    [StringLength(20)]
    public string Sucremota { get; set; } = null!;

    [Column("ventaremota")]
    public int? Ventaremota { get; set; }

    [Column("comodin")]
    [StringLength(20)]
    public string? Comodin { get; set; }

    [Column("iespecial")]
    public double? Iespecial { get; set; }

    [Column("nodesglosedetalle")]
    public short? Nodesglosedetalle { get; set; }

    [StringLength(5)]
    public string? Transporte { get; set; }

    [StringLength(10)]
    public string? Repartidor { get; set; }

    [Column("horasalida")]
    [StringLength(19)]
    public string? Horasalida { get; set; }

    [Column("horaregreso")]
    [StringLength(19)]
    public string? Horaregreso { get; set; }

    [Column("comisiontel")]
    public double? Comisiontel { get; set; }

    [Column("verificado")]
    public short? Verificado { get; set; }

    [Column("donativo")]
    public double? Donativo { get; set; }

    [Column("pagado")]
    public short? Pagado { get; set; }

    [Column("comisionvendedor")]
    public double? Comisionvendedor { get; set; }

    [Column("comodin1")]
    [StringLength(20)]
    public string? Comodin1 { get; set; }

    [Column("comodin2")]
    [StringLength(20)]
    public string? Comodin2 { get; set; }

    [Column("comodin3")]
    [StringLength(20)]
    public string? Comodin3 { get; set; }

    [Column("comodin4")]
    [StringLength(20)]
    public string? Comodin4 { get; set; }

    [Column("pago4")]
    public double? Pago4 { get; set; }

    [Column("concepto4")]
    [StringLength(3)]
    public string? Concepto4 { get; set; }

    [Column("pregunta1")]
    public short? Pregunta1 { get; set; }

    [Column("pregunta2")]
    public short? Pregunta2 { get; set; }

    [Column("pregunta3")]
    public short? Pregunta3 { get; set; }

    [Column("pregunta4")]
    public short? Pregunta4 { get; set; }

    [Column("pregunta5")]
    public short? Pregunta5 { get; set; }

    [Column("fechacierre", TypeName = "datetime")]
    public DateTime? Fechacierre { get; set; }

    [Column("businessintelligence")]
    public short Businessintelligence { get; set; }

    [Column("SSMA_TimeStamp")]
    public byte[] SsmaTimeStamp { get; set; } = null!;

    [Column("pedido")]
    public int? Pedido { get; set; }

    [Column("cambioDeEstado")]
    public short CambioDeEstado { get; set; }

    [Column("placas")]
    [StringLength(30)]
    public string? Placas { get; set; }

    [Column("kilometraje")]
    public int? Kilometraje { get; set; }

    [Column("color")]
    [StringLength(15)]
    public string? Color { get; set; }

    [Column("serie")]
    [StringLength(30)]
    public string? Serie { get; set; }

    [Column("motor")]
    [StringLength(30)]
    public string? Motor { get; set; }

    [Column("tipo")]
    [StringLength(30)]
    public string? Tipo { get; set; }

    [Column("marca")]
    [StringLength(20)]
    public string? Marca { get; set; }

    [Column("modelo")]
    public int? Modelo { get; set; }

    [Column("horaentrega")]
    [StringLength(5)]
    public string? Horaentrega { get; set; }

    [Column("propina", TypeName = "smallmoney")]
    public decimal? Propina { get; set; }

    [Column("paraconcentrador")]
    public short? Paraconcentrador { get; set; }

    [Column("FE_Emitir")]
    [StringLength(1)]
    [Unicode(false)]
    public string? FeEmitir { get; set; }

    [Column("FE_Fecha")]
    [StringLength(20)]
    [Unicode(false)]
    public string? FeFecha { get; set; }

    [Column("FE_Serie")]
    [StringLength(10)]
    [Unicode(false)]
    public string? FeSerie { get; set; }

    [Column("FE_Folio")]
    [StringLength(10)]
    [Unicode(false)]
    public string? FeFolio { get; set; }

    [Column("FE_Status")]
    [StringLength(20)]
    [Unicode(false)]
    public string? FeStatus { get; set; }

    [Column("facturaelectronica")]
    public string? Facturaelectronica { get; set; }

    [Column("facturado")]
    public int? Facturado { get; set; }

    [Column("seriefactura")]
    [StringLength(50)]
    public string? Seriefactura { get; set; }

    [Column("foliofactura")]
    public int? Foliofactura { get; set; }

    [Column("archivoFE")]
    public string? ArchivoFe { get; set; }

    [Column("tocken")]
    [StringLength(50)]
    public string? Tocken { get; set; }

    [Column("noAprobacion")]
    [StringLength(20)]
    public string? NoAprobacion { get; set; }

    [Column("importeletra")]
    [StringLength(200)]
    public string? Importeletra { get; set; }

    [Column("foliocaducidad", TypeName = "smalldatetime")]
    public DateTime? Foliocaducidad { get; set; }

    [Column("pedimentos")]
    public string? Pedimentos { get; set; }

    [Column("UUID")]
    [StringLength(50)]
    public string? Uuid { get; set; }

    [Column("ComprobanteXML")]
    public string? ComprobanteXml { get; set; }

    [InverseProperty("VentaNavigation")]
    public virtual ICollection<Cobranza> Cobranzas { get; set; } = new List<Cobranza>();

    [InverseProperty("VentaNavigation")]
    public virtual ICollection<Partvtum> Partvta { get; set; } = new List<Partvtum>();
}
