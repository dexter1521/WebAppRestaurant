using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Table("prods")]
[Index("Acaja", Name = "acaja")]
[Index("Clasificacion", Name = "clasificacion")]
[Index("Color", Name = "color")]
[Index("Recalcular", Name = "recalcular")]
[Index("Servicio", Name = "servicio")]
[Index("Talla", Name = "talla")]
public partial class Prod
{
    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("ARTICULO")]
    [StringLength(30)]
    public string Articulo { get; set; } = null!;

    [Column("DESCRIP")]
    public string? Descrip { get; set; }

    [Column("LINEA")]
    [StringLength(15)]
    public string? Linea { get; set; }

    [Column("MARCA")]
    [StringLength(15)]
    public string? Marca { get; set; }

    [Column("PRECIO1")]
    public double Precio1 { get; set; }

    [Column("PRECIO2")]
    public double Precio2 { get; set; }

    [Column("PRECIO3")]
    public double Precio3 { get; set; }

    [Column("PRECIO4")]
    public double Precio4 { get; set; }

    [Column("PRECIO5")]
    public double Precio5 { get; set; }

    [Column("PRECIO6")]
    public double Precio6 { get; set; }

    [Column("PRECIO7")]
    public double Precio7 { get; set; }

    [Column("PRECIO8")]
    public double Precio8 { get; set; }

    [Column("PRECIO9")]
    public double Precio9 { get; set; }

    [Column("PRECIO10")]
    public double Precio10 { get; set; }

    [Column("EXISTENCIA")]
    public double Existencia { get; set; }

    [Column("COSTO_U")]
    public double CostoU { get; set; }

    [Column("COSTO")]
    public double Costo { get; set; }

    [Column("UNIDAD")]
    [StringLength(20)]
    public string? Unidad { get; set; }

    [Column("POR_RECIB")]
    public double PorRecib { get; set; }

    [Column("POR_SURT")]
    public double PorSurt { get; set; }

    [Column("IMPUESTO")]
    [StringLength(5)]
    public string Impuesto { get; set; } = null!;

    [Column("MINIMO")]
    public double Minimo { get; set; }

    [Column("MAXIMO")]
    public double Maximo { get; set; }

    [Column("OBSERV")]
    public string? Observ { get; set; }

    [Column("COSTO_STD")]
    public double CostoStd { get; set; }

    [Column("KIT")]
    public short Kit { get; set; }

    [Column("SERIE")]
    public short Serie { get; set; }

    [Column("LOTE")]
    public short Lote { get; set; }

    [Column("INVENT")]
    public short Invent { get; set; }

    [Column("IMAGEN")]
    [StringLength(250)]
    public string? Imagen { get; set; }

    [Column("PARAVENTA")]
    public short Paraventa { get; set; }

    [Column("URL")]
    [StringLength(250)]
    public string? Url { get; set; }

    public short Curso { get; set; }

    [Column("USUARIO")]
    [StringLength(10)]
    public string? Usuario { get; set; }

    [Column("USUHORA")]
    [StringLength(8)]
    public string? Usuhora { get; set; }

    [Column("USUFECHA", TypeName = "datetime")]
    public DateTime? Usufecha { get; set; }

    public short Exportado { get; set; }

    [Column("EN_VENTA")]
    public double EnVenta { get; set; }

    public short Recalcular { get; set; }

    public short Granel { get; set; }

    public double Peso { get; set; }

    public short BajoCosto { get; set; }

    public short Bloqueado { get; set; }

    public double U1 { get; set; }

    public double U2 { get; set; }

    public double U3 { get; set; }

    public double U4 { get; set; }

    public double U5 { get; set; }

    public double U6 { get; set; }

    public double U7 { get; set; }

    public double U8 { get; set; }

    public double U9 { get; set; }

    public double U10 { get; set; }

    public short Acaja { get; set; }

    [Column("MODIFICAPRECIO")]
    [StringLength(1)]
    public string? Modificaprecio { get; set; }

    public short Fraccionario { get; set; }

    [Column("IESPECIAL")]
    public double Iespecial { get; set; }

    [Column("UBICACION")]
    [StringLength(20)]
    public string? Ubicacion { get; set; }

    public double C2 { get; set; }

    public double C3 { get; set; }

    public double C4 { get; set; }

    public double C5 { get; set; }

    public double C6 { get; set; }

    public double C7 { get; set; }

    public double C8 { get; set; }

    public double C9 { get; set; }

    public double C10 { get; set; }

    public double Movimientos { get; set; }

    [StringLength(30)]
    public string? Clasificacion { get; set; }

    [Column("ROP")]
    public double Rop { get; set; }

    [Column("rotacion")]
    public double Rotacion { get; set; }

    [Column("clasifant")]
    [StringLength(10)]
    public string? Clasifant { get; set; }

    [Column("eoq")]
    public double Eoq { get; set; }

    [Column("etiquetas")]
    public int Etiquetas { get; set; }

    [Column("modelo")]
    [StringLength(9)]
    public string? Modelo { get; set; }

    [Column("color")]
    [StringLength(5)]
    public string? Color { get; set; }

    [Column("talla")]
    [StringLength(5)]
    public string? Talla { get; set; }

    [Column("speso")]
    public short Speso { get; set; }

    [Column("etiqueta")]
    [StringLength(20)]
    public string? Etiqueta { get; set; }

    [Column("numero")]
    public int Numero { get; set; }

    [Column("carton")]
    public int Carton { get; set; }

    [Column("ubicaetiq")]
    [StringLength(10)]
    public string? Ubicaetiq { get; set; }

    [Column("unidadrecibe")]
    [StringLength(10)]
    public string? Unidadrecibe { get; set; }

    [Column("unidadempaque")]
    [StringLength(10)]
    public string? Unidadempaque { get; set; }

    [Column("sinvolumen")]
    public short Sinvolumen { get; set; }

    public short Presentacion { get; set; }

    public short Servicio { get; set; }

    [Column("numeroservicios")]
    public int Numeroservicios { get; set; }

    [Column("claveproveedor")]
    [StringLength(20)]
    public string? Claveproveedor { get; set; }

    [Column("dp")]
    public double Dp { get; set; }

    [Column("familia")]
    [StringLength(20)]
    public string? Familia { get; set; }

    [Column("subfamilia")]
    [StringLength(20)]
    public string? Subfamilia { get; set; }

    [Column("subfam1")]
    [StringLength(20)]
    public string? Subfam1 { get; set; }

    [Column("subfam2")]
    [StringLength(20)]
    public string? Subfam2 { get; set; }

    public double Entradas { get; set; }

    public double Salidas { get; set; }

    [Column("cantent")]
    public double Cantent { get; set; }

    [Column("cantsal")]
    public double Cantsal { get; set; }

    [Column("pronostico")]
    public double Pronostico { get; set; }

    [Column("oferta")]
    public short Oferta { get; set; }

    [Column("costoentrada")]
    public double Costoentrada { get; set; }

    [Column("costosalida")]
    public double Costosalida { get; set; }

    [Column("unidadesentrada")]
    public double Unidadesentrada { get; set; }

    [Column("unidadessalida")]
    public double Unidadessalida { get; set; }

    [Column("donativo")]
    public double Donativo { get; set; }

    [Column("costopeps")]
    public double Costopeps { get; set; }

    [Column("costoueps")]
    public double Costoueps { get; set; }

    [Column("contenido")]
    [StringLength(10)]
    public string? Contenido { get; set; }

    [Column("presentacionextra")]
    [StringLength(10)]
    public string? Presentacionextra { get; set; }

    [Column("pesoextra")]
    public double Pesoextra { get; set; }

    [Column("autor")]
    [StringLength(20)]
    public string? Autor { get; set; }

    [Column("tema")]
    [StringLength(20)]
    public string? Tema { get; set; }

    [Column("editorial")]
    [StringLength(20)]
    public string? Editorial { get; set; }

    [Column("fabricante")]
    [StringLength(20)]
    public string? Fabricante { get; set; }

    [Column("preciousd")]
    public double Preciousd { get; set; }

    [Column("costousd")]
    public double Costousd { get; set; }

    [Column("puntos")]
    public int Puntos { get; set; }

    [Column("autocodigo")]
    public int Autocodigo { get; set; }

    [Column("inventariopiezas")]
    public double? Inventariopiezas { get; set; }

    [Column("diasstockmaximo")]
    public int? Diasstockmaximo { get; set; }

    [Column("diasstockminimo")]
    public int? Diasstockminimo { get; set; }

    [Column("requerimiento")]
    public int? Requerimiento { get; set; }

    [Column("tiempoAire")]
    public short TiempoAire { get; set; }

    [Column("SSMA_TimeStamp")]
    public byte[] SsmaTimeStamp { get; set; } = null!;

    [Column("ensambladoenlinea")]
    public int? Ensambladoenlinea { get; set; }

    [Column("iepslitro", TypeName = "smallmoney")]
    public decimal? Iepslitro { get; set; }

    [Column("claveprodserv")]
    [StringLength(50)]
    [Unicode(false)]
    public string Claveprodserv { get; set; } = null!;

    [Column("claveunidad")]
    [StringLength(50)]
    [Unicode(false)]
    public string Claveunidad { get; set; } = null!;

    [ForeignKey("Fabricante")]
    [InverseProperty("Prods")]
    public virtual Fabricante? FabricanteNavigation { get; set; }

    [ForeignKey("Linea")]
    [InverseProperty("Prods")]
    public virtual Linea? LineaNavigation { get; set; }

    [ForeignKey("Marca")]
    [InverseProperty("Prods")]
    public virtual Marca? MarcaNavigation { get; set; }

    [InverseProperty("ArticuloNavigation")]
    public virtual ICollection<RMenu> RMenus { get; set; } = new List<RMenu>();
}
