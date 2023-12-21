using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Table("estaciones")]
[Index("Estacion", Name = "estacion", IsUnique = true)]
public partial class Estacione
{
    [Key] [Dapper.Contrib.Extensions.Key]
    [StringLength(10)]
    public string Estacion { get; set; } = null!;

    [StringLength(5)]
    public string? Moneda { get; set; }

    public short Almacen { get; set; }

    [StringLength(30)]
    public string? Venta { get; set; }

    public short Lector { get; set; }

    [StringLength(50)]
    public string? ImpFact { get; set; }

    public int TantosFac { get; set; }

    [StringLength(50)]
    public string? ImpRem { get; set; }

    public int TantosRem { get; set; }

    public int TantosDev { get; set; }

    [StringLength(50)]
    public string? ImpDev { get; set; }

    public short CobroFac { get; set; }

    public short CobroRem { get; set; }

    [StringLength(5)]
    public string? CommPort { get; set; }

    [StringLength(3)]
    public string? DigitoComm { get; set; }

    public short VentaRapida { get; set; }

    public int Velocidad { get; set; }

    [Column("AGENTE")]
    public short Agente { get; set; }

    [Column("RPRODS")]
    public short Rprods { get; set; }

    [Column("RCLIENTES")]
    public short Rclientes { get; set; }

    [Column("MUSICA")]
    public short Musica { get; set; }

    public short Cajon { get; set; }

    [StringLength(1)]
    public string? CambiarDoc { get; set; }

    [Column("COMPRARAPIDA")]
    public short Comprarapida { get; set; }

    [Column("PAGACOMPRA")]
    public short Pagacompra { get; set; }

    public int PartFac { get; set; }

    [Column("MONITOR")]
    public short Monitor { get; set; }

    public short SerieLote { get; set; }

    public short Pagos { get; set; }

    public short Precant { get; set; }

    public short ConcentraVentas { get; set; }

    [Column("servidor")]
    public short Servidor { get; set; }

    [StringLength(254)]
    public string? Bitacora { get; set; }

    public short Gastos { get; set; }

    public short Viaje { get; set; }

    [Column("cobroencaja")]
    public short Cobroencaja { get; set; }

    [Column("vencomp")]
    public short Vencomp { get; set; }

    public short Incrementos { get; set; }

    [StringLength(4)]
    public string? CallerId { get; set; }

    [Column("unidadespunto")]
    public short Unidadespunto { get; set; }

    [Column("recestaciones")]
    public short Recestaciones { get; set; }

    [Column("existenciapunto")]
    public short Existenciapunto { get; set; }

    [Column("enventa")]
    public short Enventa { get; set; }

    [Column("porsurt")]
    public short Porsurt { get; set; }

    [Column("autorizapedido")]
    public short Autorizapedido { get; set; }

    [Column("intereses")]
    public short Intereses { get; set; }

    [Column("decimales")]
    public short Decimales { get; set; }

    [Column("ndecimales")]
    public double Ndecimales { get; set; }

    [Column("scajon")]
    [StringLength(250)]
    public string? Scajon { get; set; }

    [Column("pcajon")]
    [StringLength(4)]
    public string? Pcajon { get; set; }

    [Column("bascula")]
    public short Bascula { get; set; }

    [Column("procbascula")]
    [StringLength(20)]
    public string? Procbascula { get; set; }

    [Column("pbascula")]
    [StringLength(4)]
    public string? Pbascula { get; set; }

    [Column("torreta")]
    public short Torreta { get; set; }

    [Column("proctorreta")]
    [StringLength(20)]
    public string? Proctorreta { get; set; }

    [Column("ptorreta")]
    [StringLength(4)]
    public string? Ptorreta { get; set; }

    [Column("inventario")]
    public short Inventario { get; set; }

    [Column("precios")]
    public short Precios { get; set; }

    [Column("lectorserial")]
    public short Lectorserial { get; set; }

    [Column("proclector")]
    [StringLength(20)]
    public string? Proclector { get; set; }

    [Column("plector")]
    [StringLength(4)]
    public string? Plector { get; set; }

    public short Desconectado { get; set; }

    public short Imagen { get; set; }

    [Column("informacion")]
    public short Informacion { get; set; }

    public short ProcDesc { get; set; }

    public short PuntoDeVenta { get; set; }

    [Column("cliente")]
    public short Cliente { get; set; }

    public short PorUsuario { get; set; }

    [Column("sucursales")]
    public short Sucursales { get; set; }

    [Column("pticket")]
    [StringLength(40)]
    public string? Pticket { get; set; }

    [Column("ticket")]
    public short Ticket { get; set; }

    [Column("ticketcorte")]
    public short Ticketcorte { get; set; }

    [Column("configticket")]
    [StringLength(10)]
    public string? Configticket { get; set; }

    [Column("ietiquetas")]
    public short Ietiquetas { get; set; }

    [Column("ietiquetasmarca")]
    [StringLength(10)]
    public string? Ietiquetasmarca { get; set; }

    [Column("ietiquetaspuerto")]
    [StringLength(5)]
    public string? Ietiquetaspuerto { get; set; }

    [Column("basculalector")]
    public short Basculalector { get; set; }

    [Column("vbascula")]
    public int Vbascula { get; set; }

    [Column("bitbascula")]
    public short Bitbascula { get; set; }

    [Column("paridadbascula")]
    [StringLength(15)]
    public string? Paridadbascula { get; set; }

    [Column("vtorreta")]
    public int Vtorreta { get; set; }

    [Column("bittorreta")]
    public short Bittorreta { get; set; }

    [Column("paridadtorreta")]
    [StringLength(15)]
    public string? Paridadtorreta { get; set; }

    [Column("agregaprod")]
    public short Agregaprod { get; set; }

    [Column("vendedor")]
    public short Vendedor { get; set; }

    [Column("busquedagrafica")]
    public short Busquedagrafica { get; set; }

    [Column("impsalidas")]
    [StringLength(50)]
    public string? Impsalidas { get; set; }

    [Column("tantossalidas")]
    public int Tantossalidas { get; set; }

    public short PrecioDeCliente { get; set; }

    [Column("presentacion")]
    public short Presentacion { get; set; }

    [Column("cobranza")]
    public short Cobranza { get; set; }

    public short Duplicado { get; set; }

    [Column("unaventapendiente")]
    public short Unaventapendiente { get; set; }

    [Column("comodin")]
    public short Comodin { get; set; }

    [Column("pagosparciales")]
    public short Pagosparciales { get; set; }

    [Column("cobrohora")]
    public short Cobrohora { get; set; }

    [Column("horas")]
    public int Horas { get; set; }

    [Column("comodinobligatorio")]
    public short Comodinobligatorio { get; set; }

    [Column("columnadescuento")]
    public short Columnadescuento { get; set; }

    [Column("columnapresentacion")]
    public short Columnapresentacion { get; set; }

    [Column("leyendacomodin")]
    [StringLength(30)]
    public string? Leyendacomodin { get; set; }

    [Column("basculaestabilizacion")]
    public short Basculaestabilizacion { get; set; }

    public short Trazar { get; set; }

    [Column("verificador")]
    public short Verificador { get; set; }

    [Column("solicitarseries")]
    public short Solicitarseries { get; set; }

    [Column("solicitarlotes")]
    public short Solicitarlotes { get; set; }

    [Column("touchscreen")]
    public short Touchscreen { get; set; }

    [Column("conimpuesto")]
    public short Conimpuesto { get; set; }

    [Column("ventasportelefono")]
    public short Ventasportelefono { get; set; }

    [Column("bloquear")]
    public short Bloquear { get; set; }

    [Column("miservidor")]
    [StringLength(100)]
    public string? Miservidor { get; set; }

    [Column("scriptinicio")]
    [StringLength(30)]
    public string? Scriptinicio { get; set; }

    [Column("SSMA_TimeStamp")]
    public byte[] SsmaTimeStamp { get; set; } = null!;

    [Column("preferentementeefectivo")]
    public short Preferentementeefectivo { get; set; }

    [Column("serieFactura")]
    [StringLength(20)]
    public string? SerieFactura { get; set; }

    [Column("serieNC")]
    [StringLength(20)]
    public string? SerieNc { get; set; }

    [Column("serieTicketFactura")]
    [StringLength(20)]
    public string? SerieTicketFactura { get; set; }

    [Column("serieRemision")]
    [StringLength(20)]
    public string? SerieRemision { get; set; }

    [Column("serieTicket")]
    [StringLength(20)]
    public string? SerieTicket { get; set; }

    [Column("terminalCobro")]
    public short TerminalCobro { get; set; }

    [Column("idStoreTerminal")]
    [StringLength(100)]
    public string? IdStoreTerminal { get; set; }

    [Column("numeroTerminal")]
    public int NumeroTerminal { get; set; }

    [Column("tipoTerminal")]
    [StringLength(100)]
    public string? TipoTerminal { get; set; }

    [Column("tiempoAire")]
    public short TiempoAire { get; set; }

    [Column("serieTiempoAire")]
    [StringLength(15)]
    public string? SerieTiempoAire { get; set; }

    [Column("usuarioTiempoAire")]
    [StringLength(20)]
    public string? UsuarioTiempoAire { get; set; }

    [Column("passwordTiempoAire")]
    [StringLength(20)]
    public string? PasswordTiempoAire { get; set; }

    [Column("cajeroTiempoAire")]
    [StringLength(8)]
    public string? CajeroTiempoAire { get; set; }

    [Column("mensajeTerminal")]
    [StringLength(100)]
    public string? MensajeTerminal { get; set; }

    [Column("mensajeTiempoAire")]
    [StringLength(100)]
    public string? MensajeTiempoAire { get; set; }

    [Column("lectorHuella")]
    public short? LectorHuella { get; set; }

    [Column("modeloLectorHuella")]
    [StringLength(100)]
    public string? ModeloLectorHuella { get; set; }

    [Column("FactEInPOS")]
    public short? FactEinPos { get; set; }
}
