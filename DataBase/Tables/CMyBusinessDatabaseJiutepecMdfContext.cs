using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

public partial class CMyBusinessDatabaseJiutepecMdfContext : DbContext
{
    public CMyBusinessDatabaseJiutepecMdfContext()
    {
    }

    public CMyBusinessDatabaseJiutepecMdfContext(DbContextOptions<CMyBusinessDatabaseJiutepecMdfContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Actualizacion> Actualizacions { get; set; }

    public virtual DbSet<Almacen> Almacens { get; set; }

    public virtual DbSet<Arreglo> Arreglos { get; set; }

    public virtual DbSet<Articlien> Articliens { get; set; }

    public virtual DbSet<Asistencium> Asistencia { get; set; }

    public virtual DbSet<Asociado> Asociados { get; set; }

    public virtual DbSet<Ayudum> Ayuda { get; set; }

    public virtual DbSet<Barra> Barras { get; set; }

    public virtual DbSet<CClaveUnidad> CClaveUnidads { get; set; }

    public virtual DbSet<CRegimenFiscal> CRegimenFiscals { get; set; }

    public virtual DbSet<CTipoDeComprobante> CTipoDeComprobantes { get; set; }

    public virtual DbSet<CTipoRelacion> CTipoRelacions { get; set; }

    public virtual DbSet<CTipofactor> CTipofactors { get; set; }

    public virtual DbSet<CUsoCfdi> CUsoCfdis { get; set; }

    public virtual DbSet<Caja> Cajas { get; set; }

    public virtual DbSet<Calle> Calles { get; set; }

    public virtual DbSet<Cambiocosto> Cambiocostos { get; set; }

    public virtual DbSet<Cancelacione> Cancelaciones { get; set; }

    public virtual DbSet<Catalogo> Catalogos { get; set; }

    public virtual DbSet<CfdDato> CfdDatos { get; set; }

    public virtual DbSet<CfdDomicilioexpedicion> CfdDomicilioexpedicions { get; set; }

    public virtual DbSet<CfdFolio> CfdFolios { get; set; }

    public virtual DbSet<Clavesadd> Clavesadds { get; set; }

    public virtual DbSet<Clavesaddpocket> Clavesaddpockets { get; set; }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<Clientspocket> Clientspockets { get; set; }

    public virtual DbSet<Cobdet> Cobdets { get; set; }

    public virtual DbSet<Cobrad> Cobrads { get; set; }

    public virtual DbSet<Cobranza> Cobranzas { get; set; }

    public virtual DbSet<Cobrocaja> Cobrocajas { get; set; }

    public virtual DbSet<CodigospostalesMexico> CodigospostalesMexicos { get; set; }

    public virtual DbSet<CodigospostalesMexicoCiudade> CodigospostalesMexicoCiudades { get; set; }

    public virtual DbSet<CodigospostalesMexicoEstado> CodigospostalesMexicoEstados { get; set; }

    public virtual DbSet<CodigospostalesMexicoMunicipio> CodigospostalesMexicoMunicipios { get; set; }

    public virtual DbSet<Colore> Colores { get; set; }

    public virtual DbSet<Colorxmodelo> Colorxmodelos { get; set; }

    public virtual DbSet<Componen> Componens { get; set; }

    public virtual DbSet<Compopt> Compopts { get; set; }

    public virtual DbSet<Comppart> Compparts { get; set; }

    public virtual DbSet<Compra> Compras { get; set; }

    public virtual DbSet<Concentradortarea> Concentradortareas { get; set; }

    public virtual DbSet<Concxc> Concxcs { get; set; }

    public virtual DbSet<Concxp> Concxps { get; set; }

    public virtual DbSet<Conegre> Conegres { get; set; }

    public virtual DbSet<Configpocketpc> Configpocketpcs { get; set; }

    public virtual DbSet<Coningre> Coningres { get; set; }

    public virtual DbSet<Conpre> Conpres { get; set; }

    public virtual DbSet<Consec> Consecs { get; set; }

    public virtual DbSet<Contacto> Contactos { get; set; }

    public virtual DbSet<Contacto1> Contactos1 { get; set; }

    public virtual DbSet<Contactoprov> Contactoprovs { get; set; }

    public virtual DbSet<Conteo> Conteos { get; set; }

    public virtual DbSet<ControlProc> ControlProcs { get; set; }

    public virtual DbSet<Corteszx> Corteszxes { get; set; }

    public virtual DbSet<CpcBotone> CpcBotones { get; set; }

    public virtual DbSet<CpcClasificacione> CpcClasificaciones { get; set; }

    public virtual DbSet<CpcPartida> CpcPartidas { get; set; }

    public virtual DbSet<Cuenxpag> Cuenxpags { get; set; }

    public virtual DbSet<Cuenxpdet> Cuenxpdets { get; set; }

    public virtual DbSet<Datospocket> Datospockets { get; set; }

    public virtual DbSet<Defform> Defforms { get; set; }

    public virtual DbSet<Defpol> Defpols { get; set; }

    public virtual DbSet<Defpoldet> Defpoldets { get; set; }

    public virtual DbSet<Derecho> Derechos { get; set; }

    public virtual DbSet<Deresp> Deresps { get; set; }

    public virtual DbSet<Design> Designs { get; set; }

    public virtual DbSet<Designcliente> Designclientes { get; set; }

    public virtual DbSet<Designe> Designes { get; set; }

    public virtual DbSet<Devolucionespocket> Devolucionespockets { get; set; }

    public virtual DbSet<Diremb> Dirembs { get; set; }

    public virtual DbSet<Econfig> Econfigs { get; set; }

    public virtual DbSet<Empleado> Empleados { get; set; }

    public virtual DbSet<Encuestum> Encuesta { get; set; }

    public virtual DbSet<Entpart> Entparts { get; set; }

    public virtual DbSet<Entrada> Entradas { get; set; }

    public virtual DbSet<Estacione> Estaciones { get; set; }

    public virtual DbSet<Estado> Estados { get; set; }

    public virtual DbSet<Etapa> Etapas { get; set; }

    public virtual DbSet<Etapascomp> Etapascomps { get; set; }

    public virtual DbSet<Etiquetasprod> Etiquetasprods { get; set; }

    public virtual DbSet<ExistenciaCaja01> ExistenciaCaja01s { get; set; }

    public virtual DbSet<ExistenciaCaja1> ExistenciaCaja1s { get; set; }

    public virtual DbSet<ExistenciaCaja2> ExistenciaCaja2s { get; set; }

    public virtual DbSet<ExistenciaEr> ExistenciaErs { get; set; }

    public virtual DbSet<ExistenciaEstacion01> ExistenciaEstacion01s { get; set; }

    public virtual DbSet<Existenciaalmacen> Existenciaalmacens { get; set; }

    public virtual DbSet<Fabricante> Fabricantes { get; set; }

    public virtual DbSet<FacElectronica> FacElectronicas { get; set; }

    public virtual DbSet<Favorito> Favoritos { get; set; }

    public virtual DbSet<Feconfig> Feconfigs { get; set; }

    public virtual DbSet<Firmaspocket> Firmaspockets { get; set; }

    public virtual DbSet<Flujo> Flujos { get; set; }

    public virtual DbSet<Forma> Formas { get; set; }

    public virtual DbSet<Formasdeltum> Formasdelta { get; set; }

    public virtual DbSet<Formasdepago> Formasdepagos { get; set; }

    public virtual DbSet<Formato> Formatos { get; set; }

    public virtual DbSet<Formatosdeltum> Formatosdelta { get; set; }

    public virtual DbSet<Formatosreferencia> Formatosreferencias { get; set; }

    public virtual DbSet<Gpoctum> Gpocta { get; set; }

    public virtual DbSet<Histcamb> Histcambs { get; set; }

    public virtual DbSet<HistorialRespaldo> HistorialRespaldos { get; set; }

    public virtual DbSet<Historicocolectora> Historicocolectoras { get; set; }

    public virtual DbSet<Histprod> Histprods { get; set; }

    public virtual DbSet<IdeProyecto> IdeProyectos { get; set; }

    public virtual DbSet<Ifactura> Ifacturas { get; set; }

    public virtual DbSet<Imc> Imcs { get; set; }

    public virtual DbSet<Impuesto> Impuestos { get; set; }

    public virtual DbSet<Invfi> Invfis { get; set; }

    public virtual DbSet<Invini> Invinis { get; set; }

    public virtual DbSet<Inviniadd> Inviniadds { get; set; }

    public virtual DbSet<Invinicial> Invinicials { get; set; }

    public virtual DbSet<Inviniprod> Inviniprods { get; set; }

    public virtual DbSet<Invpocket> Invpockets { get; set; }

    public virtual DbSet<Linea> Lineas { get; set; }

    public virtual DbSet<Lote> Lotes { get; set; }

    public virtual DbSet<Marca> Marcas { get; set; }

    public virtual DbSet<Materialarticulo> Materialarticulos { get; set; }

    public virtual DbSet<Materiale> Materiales { get; set; }

    public virtual DbSet<MbcodigosPostale> MbcodigosPostales { get; set; }

    public virtual DbSet<Mbdevolucione> Mbdevoluciones { get; set; }

    public virtual DbSet<MbdevolucionesPart> MbdevolucionesParts { get; set; }

    public virtual DbSet<Medio> Medios { get; set; }

    public virtual DbSet<Menu> Menus { get; set; }

    public virtual DbSet<Menudetalle> Menudetalles { get; set; }

    public virtual DbSet<Metodosdepago> Metodosdepagos { get; set; }

    public virtual DbSet<Modelo> Modelos { get; set; }

    public virtual DbSet<Moneda> Monedas { get; set; }

    public virtual DbSet<MontosTacaja1> MontosTacaja1s { get; set; }

    public virtual DbSet<MontosTacaja2> MontosTacaja2s { get; set; }

    public virtual DbSet<MontosTaestacion01> MontosTaestacion01s { get; set; }

    public virtual DbSet<Movimientosestacione> Movimientosestaciones { get; set; }

    public virtual DbSet<Movimientosestacionesdetalle> Movimientosestacionesdetalles { get; set; }

    public virtual DbSet<Movsinv> Movsinvs { get; set; }

    public virtual DbSet<Movsuc> Movsucs { get; set; }

    public virtual DbSet<Newprecio> Newprecios { get; set; }

    public virtual DbSet<Oferta> Ofertas { get; set; }

    public virtual DbSet<Op> Ops { get; set; }

    public virtual DbSet<Oppart> Opparts { get; set; }

    public virtual DbSet<Ordauto> Ordautos { get; set; }

    public virtual DbSet<Orden> Ordens { get; set; }

    public virtual DbSet<Ordpar> Ordpars { get; set; }

    public virtual DbSet<Ordserv> Ordservs { get; set; }

    public virtual DbSet<Paciente> Pacientes { get; set; }

    public virtual DbSet<Pago> Pagos { get; set; }

    public virtual DbSet<Pagodestajo> Pagodestajos { get; set; }

    public virtual DbSet<Pagodev> Pagodevs { get; set; }

    public virtual DbSet<Paise> Paises { get; set; }

    public virtual DbSet<ParametrosMalla> ParametrosMallas { get; set; }

    public virtual DbSet<Partcomp> Partcomps { get; set; }

    public virtual DbSet<PartidasMalla> PartidasMallas { get; set; }

    public virtual DbSet<Partinv> Partinvs { get; set; }

    public virtual DbSet<Partinvclaveadd> Partinvclaveadds { get; set; }

    public virtual DbSet<Partvtaopcione> Partvtaopciones { get; set; }

    public virtual DbSet<Partvtum> Partvta { get; set; }

    public virtual DbSet<Pedido> Pedidos { get; set; }

    public virtual DbSet<Pedidospocket> Pedidospockets { get; set; }

    public virtual DbSet<Pedpar> Pedpars { get; set; }

    public virtual DbSet<Pedrecurrente> Pedrecurrentes { get; set; }

    public virtual DbSet<Pendient> Pendients { get; set; }

    public virtual DbSet<Pendimprimir> Pendimprimirs { get; set; }

    public virtual DbSet<Periodo> Periodos { get; set; }

    public virtual DbSet<Periodosbm> Periodosbms { get; set; }

    public virtual DbSet<Precio> Precios { get; set; }

    public virtual DbSet<Precioscliente> Preciosclientes { get; set; }

    public virtual DbSet<Presup> Presups { get; set; }

    public virtual DbSet<Prod> Prods { get; set; }

    public virtual DbSet<ProdsDelSitio> ProdsDelSitios { get; set; }

    public virtual DbSet<Prodspocket> Prodspockets { get; set; }

    public virtual DbSet<Proveed> Proveeds { get; set; }

    public virtual DbSet<ProveedoresTiempoAire> ProveedoresTiempoAires { get; set; }

    public virtual DbSet<Provprod> Provprods { get; set; }

    public virtual DbSet<ProyectosDeDesarrollo> ProyectosDeDesarrollos { get; set; }

    public virtual DbSet<Punto> Puntos { get; set; }

    public virtual DbSet<Query> Queries { get; set; }

    public virtual DbSet<RClasificacion> RClasificacions { get; set; }

    public virtual DbSet<RComanda> RComandas { get; set; }

    public virtual DbSet<RComponente> RComponentes { get; set; }

    public virtual DbSet<RCuentasPorComensal> RCuentasPorComensals { get; set; }

    public virtual DbSet<RImpresora> RImpresoras { get; set; }

    public virtual DbSet<RMenu> RMenus { get; set; }

    public virtual DbSet<RMesa> RMesas { get; set; }

    public virtual DbSet<RSeleccioncomensal> RSeleccioncomensals { get; set; }

    public virtual DbSet<RSubclasificacion> RSubclasificacions { get; set; }

    public virtual DbSet<RVentasPorCobrar> RVentasPorCobrars { get; set; }

    public virtual DbSet<Recomendado> Recomendados { get; set; }

    public virtual DbSet<Relacion> Relacions { get; set; }

    public virtual DbSet<ReportesWeb> ReportesWebs { get; set; }

    public virtual DbSet<ReportesWebBusqueda> ReportesWebBusquedas { get; set; }

    public virtual DbSet<Requisa> Requisas { get; set; }

    public virtual DbSet<Reservacione> Reservaciones { get; set; }

    public virtual DbSet<Respaldo> Respaldos { get; set; }

    public virtual DbSet<Respue> Respues { get; set; }

    public virtual DbSet<Salida> Salidas { get; set; }

    public virtual DbSet<Salpart> Salparts { get; set; }

    public virtual DbSet<Seccione> Secciones { get; set; }

    public virtual DbSet<Series> Series { get; set; }

    public virtual DbSet<Servicio> Servicios { get; set; }

    public virtual DbSet<Sincronizacionenlinea> Sincronizacionenlineas { get; set; }

    public virtual DbSet<StatusDescarga> StatusDescargas { get; set; }

    public virtual DbSet<Sucexist> Sucexists { get; set; }

    public virtual DbSet<Sucprod> Sucprods { get; set; }

    public virtual DbSet<Sucursal> Sucursals { get; set; }

    public virtual DbSet<Sucursaltarea> Sucursaltareas { get; set; }

    public virtual DbSet<Suscripcione> Suscripciones { get; set; }

    public virtual DbSet<Talla> Tallas { get; set; }

    public virtual DbSet<Tallaxmodelo> Tallaxmodelos { get; set; }

    public virtual DbSet<Tarea> Tareas { get; set; }

    public virtual DbSet<Telefono> Telefonos { get; set; }

    public virtual DbSet<TerminalDeCobro> TerminalDeCobros { get; set; }

    public virtual DbSet<Tickettext> Tickettexts { get; set; }

    public virtual DbSet<TiempoAire> TiempoAires { get; set; }

    public virtual DbSet<TiempoAireR> TiempoAireRs { get; set; }

    public virtual DbSet<Tipo> Tipos { get; set; }

    public virtual DbSet<Tipominv> Tipominvs { get; set; }

    public virtual DbSet<Tipopend> Tipopends { get; set; }

    public virtual DbSet<Tiposdecambio> Tiposdecambios { get; set; }

    public virtual DbSet<Tiposprov> Tiposprovs { get; set; }

    public virtual DbSet<Tipotel> Tipotels { get; set; }

    public virtual DbSet<Tipoventum> Tipoventa { get; set; }

    public virtual DbSet<Turno> Turnos { get; set; }

    public virtual DbSet<Ubicacion> Ubicacions { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<Usuarioshuella> Usuarioshuellas { get; set; }

    public virtual DbSet<Usubarra> Usubarras { get; set; }

    public virtual DbSet<Usurep> Usureps { get; set; }

    public virtual DbSet<Usuventa> Usuventas { get; set; }

    public virtual DbSet<VFedatosArticulo> VFedatosArticulos { get; set; }

    public virtual DbSet<VFedatosArticuloTmp> VFedatosArticuloTmps { get; set; }

    public virtual DbSet<VFedatosFactura> VFedatosFacturas { get; set; }

    public virtual DbSet<VFedatosFe> VFedatosves { get; set; }

    public virtual DbSet<VFeseriesFactura> VFeseriesFacturas { get; set; }

    public virtual DbSet<Vale> Vales { get; set; }

    public virtual DbSet<Vend> Vends { get; set; }

    public virtual DbSet<Venta> Ventas { get; set; }

    public virtual DbSet<Zona> Zonas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-OOGIDH8\\SQLEXPRESS;Database=C:\\MyBusinessDatabase\\JIUTEPEC.mdf;User Id=sa;Password=lxc8040;Trusted_Connection=true;Encrypt=False;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("SQL_Latin1_General_CP1_CI_AI");

        modelBuilder.Entity<Almacen>(entity =>
        {
            entity.Property(e => e.Almacen1).ValueGeneratedNever();
            entity.Property(e => e.Usuhora).IsFixedLength();
        });

        modelBuilder.Entity<Arreglo>(entity =>
        {
            entity.Property(e => e.Arreglo1).IsFixedLength();
        });

        modelBuilder.Entity<Articlien>(entity =>
        {
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Ayudum>(entity =>
        {
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Caja>(entity =>
        {
            entity.Property(e => e.SerieDocumento).IsFixedLength();
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Calle>(entity =>
        {
            entity.Property(e => e.Calle1).IsFixedLength();
        });

        modelBuilder.Entity<Cambiocosto>(entity =>
        {
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Cancelacione>(entity =>
        {
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Clavesadd>(entity =>
        {
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Client>(entity =>
        {
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Clientspocket>(entity =>
        {
            entity.HasKey(e => e.Cliente).HasName("PK_clientsOnLine");
        });

        modelBuilder.Entity<Cobdet>(entity =>
        {
            entity.Property(e => e.Abono).HasDefaultValue(0);
            entity.Property(e => e.SerieDocumento)
                .HasDefaultValueSql("((0))")
                .IsFixedLength();
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();

            entity.HasOne(d => d.CobranzaNavigation).WithMany(p => p.Cobdets).HasConstraintName("FK_cobdet_cobranza");
        });

        modelBuilder.Entity<Cobrad>(entity =>
        {
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Cobranza>(entity =>
        {
            entity.Property(e => e.SerieDocumento)
                .HasDefaultValueSql("((0))")
                .IsFixedLength();
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();

            entity.HasOne(d => d.VentaNavigation).WithMany(p => p.Cobranzas).HasConstraintName("FK_cobranza_ventas");
        });

        modelBuilder.Entity<Cobrocaja>(entity =>
        {
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<CodigospostalesMexico>(entity =>
        {
            entity.Property(e => e.Cp).IsFixedLength();
        });

        modelBuilder.Entity<CodigospostalesMexicoCiudade>(entity =>
        {
            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.Ciudad).IsFixedLength();
        });

        modelBuilder.Entity<CodigospostalesMexicoEstado>(entity =>
        {
            entity.HasKey(e => e.Estado).HasName("PK_codigospostales_mexico_estados_1");

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<CodigospostalesMexicoMunicipio>(entity =>
        {
            entity.HasKey(e => new { e.Municipio, e.Estado }).HasName("PK_codigospostales_mexico_estados");

            entity.Property(e => e.Municipio).IsFixedLength();
            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<Componen>(entity =>
        {
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Comppart>(entity =>
        {
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Compra>(entity =>
        {
            entity.Property(e => e.Compra1).ValueGeneratedNever();
            entity.Property(e => e.Hora).IsFixedLength();
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Concxc>(entity =>
        {
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Conegre>(entity =>
        {
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Configpocketpc>(entity =>
        {
            entity.Property(e => e.Pocketpc).ValueGeneratedNever();
            entity.Property(e => e.Anchopapel).HasDefaultValue((short)0);
            entity.Property(e => e.Preciosporcliente).HasDefaultValue((short)0);
        });

        modelBuilder.Entity<Contacto>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Contacto1>(entity =>
        {
            entity.Property(e => e.Cliente).IsFixedLength();
        });

        modelBuilder.Entity<Contactoprov>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_contactosprov");

            entity.Property(e => e.Proveedor).IsFixedLength();
        });

        modelBuilder.Entity<Conteo>(entity =>
        {
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Corteszx>(entity =>
        {
            entity.ToTable("corteszx", tb => tb.HasTrigger("MMActualizaFlujo"));

            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<CpcPartida>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_cpc_partidas_1");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Cuenxpag>(entity =>
        {
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Cuenxpdet>(entity =>
        {
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Design>(entity =>
        {
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Designcliente>(entity =>
        {
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Designe>(entity =>
        {
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Diremb>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Econfig>(entity =>
        {
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Entpart>(entity =>
        {
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Entrada>(entity =>
        {
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Estacione>(entity =>
        {
            entity.Property(e => e.Configticket).HasDefaultValueSql("((0))");
            entity.Property(e => e.LectorHuella).HasDefaultValue((short)0);
            entity.Property(e => e.Scriptinicio).IsFixedLength();
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Etapa>(entity =>
        {
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Etapascomp>(entity =>
        {
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Etiquetasprod>(entity =>
        {
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<ExistenciaCaja01>(entity =>
        {
            entity.HasKey(e => e.Articulo).HasName("PK__existenciaCAJA01__282DF8C2");

            entity.Property(e => e.Articulo).IsFixedLength();
        });

        modelBuilder.Entity<ExistenciaCaja1>(entity =>
        {
            entity.HasKey(e => e.Articulo).HasName("PK__existenciaCAJA1__69B1A35C");

            entity.Property(e => e.Articulo).IsFixedLength();
        });

        modelBuilder.Entity<ExistenciaCaja2>(entity =>
        {
            entity.HasKey(e => e.Articulo).HasName("PK__existenciaCAJA2__6C8E1007");

            entity.Property(e => e.Articulo).IsFixedLength();
        });

        modelBuilder.Entity<ExistenciaEr>(entity =>
        {
            entity.HasKey(e => e.Articulo).HasName("PK__existenciaER__7C8480AE");

            entity.Property(e => e.Articulo).IsFixedLength();
        });

        modelBuilder.Entity<ExistenciaEstacion01>(entity =>
        {
            entity.HasKey(e => e.Articulo).HasName("PK__existenciaESTACI__787EE5A0");

            entity.Property(e => e.Articulo).IsFixedLength();
        });

        modelBuilder.Entity<Existenciaalmacen>(entity =>
        {
            entity.Property(e => e.Articulo).IsFixedLength();
        });

        modelBuilder.Entity<Fabricante>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__fabrican__3213E83FC7A3076B");
        });

        modelBuilder.Entity<FacElectronica>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__FacElectronica__03F0984C");
        });

        modelBuilder.Entity<Flujo>(entity =>
        {
            entity.Property(e => e.Fecha).HasDefaultValueSql("((0))");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Forma>(entity =>
        {
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Formasdeltum>(entity =>
        {
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Formato>(entity =>
        {
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Formatosdeltum>(entity =>
        {
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Histcamb>(entity =>
        {
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<HistorialRespaldo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__historialRespald__0B91BA14");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Historicocolectora>(entity =>
        {
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Histprod>(entity =>
        {
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Ifactura>(entity =>
        {
            entity.Property(e => e.AreaAcomodo).IsFixedLength();
            entity.Property(e => e.CantidadConCargo).IsFixedLength();
            entity.Property(e => e.CantidadSinCargo).IsFixedLength();
            entity.Property(e => e.ClasificacionFiscal).IsFixedLength();
            entity.Property(e => e.Cliente).IsFixedLength();
            entity.Property(e => e.CodigoArticulo).IsFixedLength();
            entity.Property(e => e.CodigoEan).IsFixedLength();
            entity.Property(e => e.CostoPrecioFarmacia).IsFixedLength();
            entity.Property(e => e.DescuentoAdicional).IsFixedLength();
            entity.Property(e => e.DescuentoVenta10).IsFixedLength();
            entity.Property(e => e.Fecha).IsFixedLength();
            entity.Property(e => e.Fechaentrega).IsFixedLength();
            entity.Property(e => e.ImporteIeps).IsFixedLength();
            entity.Property(e => e.ImporteIepsparaRenglon).IsFixedLength();
            entity.Property(e => e.ImporteIvaParaRenglon).IsFixedLength();
            entity.Property(e => e.ImporteTotalRenglon).IsFixedLength();
            entity.Property(e => e.ImporteVentaRenglon).IsFixedLength();
            entity.Property(e => e.Importeapagar).IsFixedLength();
            entity.Property(e => e.Importedescuento).IsFixedLength();
            entity.Property(e => e.Importeiva).IsFixedLength();
            entity.Property(e => e.Importetotal).IsFixedLength();
            entity.Property(e => e.IvadescuentoGlobal).IsFixedLength();
            entity.Property(e => e.IvadescuentoVenta10).IsFixedLength();
            entity.Property(e => e.Ivaglobal).IsFixedLength();
            entity.Property(e => e.Ivatasa10).IsFixedLength();
            entity.Property(e => e.MargenUnitario).IsFixedLength();
            entity.Property(e => e.NumeroDeBolsas).IsFixedLength();
            entity.Property(e => e.NumeroDeBultos).IsFixedLength();
            entity.Property(e => e.Numerofactura).IsFixedLength();
            entity.Property(e => e.Numerofacturasecciondepartamento).IsFixedLength();
            entity.Property(e => e.Numerofacturatienda).IsFixedLength();
            entity.Property(e => e.PrecioVenta).IsFixedLength();
            entity.Property(e => e.Proveedor).IsFixedLength();
            entity.Property(e => e.Referencias).IsFixedLength();
            entity.Property(e => e.Registros).IsFixedLength();
            entity.Property(e => e.Totalproductos).IsFixedLength();
            entity.Property(e => e.VentaNeta).IsFixedLength();
            entity.Property(e => e.Ventastasa0).IsFixedLength();
        });

        modelBuilder.Entity<Imc>(entity =>
        {
            entity.Property(e => e.Sexo).IsFixedLength();
        });

        modelBuilder.Entity<Impuesto>(entity =>
        {
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Invfi>(entity =>
        {
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Inviniadd>(entity =>
        {
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Invinicial>(entity =>
        {
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Inviniprod>(entity =>
        {
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Invpocket>(entity =>
        {
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Lote>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Materialarticulo>(entity =>
        {
            entity.Property(e => e.Material).IsFixedLength();
            entity.Property(e => e.Articulo).IsFixedLength();
        });

        modelBuilder.Entity<Materiale>(entity =>
        {
            entity.Property(e => e.Articulo).IsFixedLength();
            entity.Property(e => e.Impuesto).IsFixedLength();
        });

        modelBuilder.Entity<MbcodigosPostale>(entity =>
        {
            entity.ToView("MBCodigosPostales");

            entity.Property(e => e.Cp).IsFixedLength();
        });

        modelBuilder.Entity<Mbdevolucione>(entity =>
        {
            entity.ToView("MBDevoluciones");
        });

        modelBuilder.Entity<MbdevolucionesPart>(entity =>
        {
            entity.ToView("MBDevolucionesPart");

            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Modelo>(entity =>
        {
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Moneda>(entity =>
        {
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Movimientosestacionesdetalle>(entity =>
        {
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Movsinv>(entity =>
        {
            entity.HasKey(e => e.Consec).HasName("PK_movsinv_1");

            entity.Property(e => e.Hora).IsFixedLength();
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Movsuc>(entity =>
        {
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Oferta>(entity =>
        {
            entity.Property(e => e.Horafinal).IsFixedLength();
            entity.Property(e => e.Horainicial).IsFixedLength();
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Op>(entity =>
        {
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Oppart>(entity =>
        {
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Ordauto>(entity =>
        {
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Orden>(entity =>
        {
            entity.Property(e => e.Orden1).ValueGeneratedNever();
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Ordpar>(entity =>
        {
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Ordserv>(entity =>
        {
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Pago>(entity =>
        {
            entity.Property(e => e.Abono).ValueGeneratedNever();
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Pagodestajo>(entity =>
        {
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Pagodev>(entity =>
        {
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Paise>(entity =>
        {
            entity.Property(e => e.Codigo).IsFixedLength();
        });

        modelBuilder.Entity<Partcomp>(entity =>
        {
            entity.Property(e => e.IdEntrada).ValueGeneratedNever();
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Partinv>(entity =>
        {
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Partinvclaveadd>(entity =>
        {
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Partvtum>(entity =>
        {
            entity.Property(e => e.Prcantidad).HasDefaultValue(1m);
            entity.Property(e => e.SerieDocumento)
                .HasDefaultValueSql("((0))")
                .IsFixedLength();
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();

            entity.HasOne(d => d.VentaNavigation).WithMany(p => p.Partvta).HasConstraintName("FK_partvta_ventas");
        });

        modelBuilder.Entity<Pedido>(entity =>
        {
            entity.HasKey(e => e.Pedido1).HasName("PK_cotiza");

            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Pedpar>(entity =>
        {
            entity.HasKey(e => e.IdSalida).HasName("PK_cotizpar");

            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Pedrecurrente>(entity =>
        {
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Pendient>(entity =>
        {
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Precio>(entity =>
        {
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Presup>(entity =>
        {
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Prod>(entity =>
        {
            entity.Property(e => e.Autocodigo).ValueGeneratedOnAdd();
            entity.Property(e => e.Claveprodserv).HasDefaultValueSql("((0))");
            entity.Property(e => e.Claveunidad).HasDefaultValueSql("((2466))");
            entity.Property(e => e.Ensambladoenlinea).HasDefaultValue(0);
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();

            entity.HasOne(d => d.FabricanteNavigation).WithMany(p => p.Prods)
                .HasPrincipalKey(p => p.Fabricante1)
                .HasForeignKey(d => d.Fabricante)
                .HasConstraintName("FK_prods_fabricantes");

            entity.HasOne(d => d.LineaNavigation).WithMany(p => p.Prods).HasConstraintName("FK_prods_lineas");

            entity.HasOne(d => d.MarcaNavigation).WithMany(p => p.Prods).HasConstraintName("FK_prods_marcas");
        });

        modelBuilder.Entity<ProdsDelSitio>(entity =>
        {
            entity.Property(e => e.Validado).HasDefaultValue("NO");
        });

        modelBuilder.Entity<Proveed>(entity =>
        {
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Provprod>(entity =>
        {
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<ProyectosDeDesarrollo>(entity =>
        {
            entity.Property(e => e.Proyecto).IsFixedLength();
        });

        modelBuilder.Entity<Punto>(entity =>
        {
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<RClasificacion>(entity =>
        {
            entity.HasKey(e => e.Clasificacion).HasName("PK_menuclasificacion");

            entity.Property(e => e.Clasificacion).IsFixedLength();
        });

        modelBuilder.Entity<RComanda>(entity =>
        {
            entity.Property(e => e.Mesa).IsFixedLength();

            entity.HasOne(d => d.MesaNavigation).WithMany(p => p.RComanda).HasConstraintName("FK_r_comandas_r_mesas");
        });

        modelBuilder.Entity<RCuentasPorComensal>(entity =>
        {
            entity.Property(e => e.Mesa)
                .IsFixedLength()
                .UseCollation("Modern_Spanish_CI_AS");
        });

        modelBuilder.Entity<RImpresora>(entity =>
        {
            entity.Property(e => e.Impresora).IsFixedLength();
        });

        modelBuilder.Entity<RMenu>(entity =>
        {
            entity.Property(e => e.Clasificacion).IsFixedLength();
            entity.Property(e => e.Subclasificacion).IsFixedLength();

            entity.HasOne(d => d.ArticuloNavigation).WithMany(p => p.RMenus).HasConstraintName("FK_r_menu_prods");

            entity.HasOne(d => d.ClasificacionNavigation).WithMany(p => p.RMenus).HasConstraintName("FK_r_menu_r_clasificacion");

            entity.HasOne(d => d.SubclasificacionNavigation).WithMany(p => p.RMenus).HasConstraintName("FK_r_menu_r_subclasificacion");
        });

        modelBuilder.Entity<RMesa>(entity =>
        {
            entity.HasKey(e => e.Mesa).HasName("PK_mesas");

            entity.Property(e => e.Mesa).IsFixedLength();
            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.Impresora).IsFixedLength();
            entity.Property(e => e.Unionmesa).IsFixedLength();
        });

        modelBuilder.Entity<RSeleccioncomensal>(entity =>
        {
            entity.HasOne(d => d.IdComandaNavigation).WithMany(p => p.RSeleccioncomensals).HasConstraintName("FK_r_seleccioncomensal_r_comandas");

            entity.HasOne(d => d.IdMenuNavigation).WithMany(p => p.RSeleccioncomensals).HasConstraintName("FK_r_seleccioncomensal_r_menu");
        });

        modelBuilder.Entity<RSubclasificacion>(entity =>
        {
            entity.HasKey(e => e.Subclasificacion).HasName("PK_subclasificacionmenu");

            entity.Property(e => e.Subclasificacion).IsFixedLength();
            entity.Property(e => e.Clasificacion).IsFixedLength();

            entity.HasOne(d => d.ClasificacionNavigation).WithMany(p => p.RSubclasificacions).HasConstraintName("FK_subclasificacionmenu_subclasificacionmenu");
        });

        modelBuilder.Entity<RVentasPorCobrar>(entity =>
        {
            entity.Property(e => e.Mesa)
                .IsFixedLength()
                .UseCollation("Modern_Spanish_CI_AS");
        });

        modelBuilder.Entity<ReportesWeb>(entity =>
        {
            entity.HasKey(e => e.Reporte).HasName("PK__reportesWeb__21B6055D");
        });

        modelBuilder.Entity<Requisa>(entity =>
        {
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Reservacione>(entity =>
        {
            entity.Property(e => e.Mesa).IsFixedLength();
        });

        modelBuilder.Entity<Respue>(entity =>
        {
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Salida>(entity =>
        {
            entity.Property(e => e.Salida1).ValueGeneratedNever();
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Salpart>(entity =>
        {
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Seccione>(entity =>
        {
            entity.Property(e => e.Seccion).IsFixedLength();
        });

        modelBuilder.Entity<Series>(entity =>
        {
            entity.Property(e => e.Ocupado).HasDefaultValue((short)0);
        });

        modelBuilder.Entity<Sincronizacionenlinea>(entity =>
        {
            entity.Property(e => e.Dato).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<Sucexist>(entity =>
        {
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Sucprod>(entity =>
        {
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Suscripcione>(entity =>
        {
            entity.Property(e => e.Cliente).IsFixedLength();
            entity.Property(e => e.Cp).IsFixedLength();
            entity.Property(e => e.Factura).IsFixedLength();
            entity.Property(e => e.Modoentrega).IsFixedLength();
            entity.Property(e => e.SerieDocumento).IsFixedLength();
        });

        modelBuilder.Entity<Tickettext>(entity =>
        {
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<TiempoAireR>(entity =>
        {
            entity.Property(e => e.Estacion).IsFixedLength();
            entity.Property(e => e.Estatus).IsFixedLength();
        });

        modelBuilder.Entity<VFedatosArticulo>(entity =>
        {
            entity.ToView("v_FEDatosArticulo");

            entity.Property(e => e.SerieDocumento).IsFixedLength();
        });

        modelBuilder.Entity<VFedatosArticuloTmp>(entity =>
        {
            entity.ToView("v_FEDatosArticuloTmp");

            entity.Property(e => e.SerieDocumento).IsFixedLength();
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<VFedatosFactura>(entity =>
        {
            entity.ToView("v_FEDatosFactura");

            entity.Property(e => e.CdPais).IsFixedLength();
        });

        modelBuilder.Entity<VFedatosFe>(entity =>
        {
            entity.ToView("v_FEDatosFE");
        });

        modelBuilder.Entity<VFeseriesFactura>(entity =>
        {
            entity.ToView("v_FESeriesFactura");
        });

        modelBuilder.Entity<Vale>(entity =>
        {
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Vend>(entity =>
        {
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Venta>(entity =>
        {
            entity.Property(e => e.SerieDocumento)
                .HasDefaultValueSql("((0))")
                .IsFixedLength();
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.Sucremota).HasDefaultValue("Local");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
