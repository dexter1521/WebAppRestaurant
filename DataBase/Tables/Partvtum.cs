using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Table("partvta")]
[Index("A01", Name = "a01")]
[Index("Articulo", Name = "articulo")]
[Index("IdEntrada", Name = "id_entrada")]
[Index("IdSalida", Name = "id_salida", IsUnique = true)]
[Index("NoReferen", Name = "no_referen")]
[Index("Partida", Name = "partida")]
[Index("TipoDoc", Name = "tipo_doc")]
[Index("Venta", Name = "venta")]
[Index("Verificado", Name = "verificado")]
public partial class Partvtum
{
    [Column("VENTA")]
    public int? Venta { get; set; }

    [Column("TIPO_DOC")]
    [StringLength(3)]
    public string? TipoDoc { get; set; }

    [Column("serieDocumento")]
    [StringLength(10)]
    public string SerieDocumento { get; set; } = null!;

    [Column("NO_REFEREN")]
    public int? NoReferen { get; set; }

    [Column("ARTICULO")]
    [StringLength(30)]
    public string? Articulo { get; set; }

    [Column("CANTIDAD")]
    public double Cantidad { get; set; }

    [Column("PRECIO")]
    public double Precio { get; set; }

    [Column("COSTO")]
    public double Costo { get; set; }

    [Column("DESCUENTO")]
    public double Descuento { get; set; }

    [Column("IMPUESTO")]
    public float Impuesto { get; set; }

    [Column("OBSERV")]
    public string? Observ { get; set; }

    [Column("PARTIDA")]
    public int? Partida { get; set; }

    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("ID_SALIDA")]
    public int IdSalida { get; set; }

    [StringLength(10)]
    public string? Usuario { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UsuFecha { get; set; }

    [StringLength(8)]
    public string? UsuHora { get; set; }

    [Column("ALMACEN")]
    public int Almacen { get; set; }

    [Column("LISTA")]
    public int Lista { get; set; }

    [StringLength(30)]
    public string? Clave { get; set; }

    [Column("PRCANTIDAD", TypeName = "smallmoney")]
    public decimal? Prcantidad { get; set; }

    [Column("PRDESCRIP")]
    [StringLength(40)]
    public string? Prdescrip { get; set; }

    [Column("estado")]
    [StringLength(2)]
    public string? Estado { get; set; }

    public double PrecioBase { get; set; }

    [StringLength(10)]
    public string? Autorizado { get; set; }

    [StringLength(20)]
    public string? Caja { get; set; }

    public double Devolucion { get; set; }

    public double DevConf { get; set; }

    [Column("ID_entrada")]
    public int IdEntrada { get; set; }

    public short Invent { get; set; }

    [Column("importe")]
    public double Importe { get; set; }

    [Column("kit")]
    public short Kit { get; set; }

    [Column("costo_u")]
    public double CostoU { get; set; }

    [Column("iespecial")]
    public double Iespecial { get; set; }

    [Column("puntadas")]
    public int Puntadas { get; set; }

    [Column("colores")]
    public int Colores { get; set; }

    [Column("verificado")]
    public short Verificado { get; set; }

    [Column("donativo")]
    public double Donativo { get; set; }

    public double A01 { get; set; }

    [Column("peso")]
    public double? Peso { get; set; }

    [Column("lote")]
    [StringLength(30)]
    public string? Lote { get; set; }

    [Column("SSMA_TimeStamp")]
    public byte[] SsmaTimeStamp { get; set; } = null!;

    [Column("iepslitro", TypeName = "smallmoney")]
    public decimal? Iepslitro { get; set; }

    [ForeignKey("Venta")]
    [InverseProperty("Partvta")]
    public virtual Venta? VentaNavigation { get; set; }
}
