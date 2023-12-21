using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("ofertas")]
[Index("Articulo", Name = "articulo")]
public partial class Oferta
{
    [Column("articulo")]
    [StringLength(15)]
    public string? Articulo { get; set; }

    [Column("fechainicial", TypeName = "datetime")]
    public DateTime? Fechainicial { get; set; }

    [Column("fechafinal", TypeName = "datetime")]
    public DateTime? Fechafinal { get; set; }

    [Column("horainicial")]
    [StringLength(6)]
    public string? Horainicial { get; set; }

    [Column("horafinal")]
    [StringLength(6)]
    public string? Horafinal { get; set; }

    [Column("formato")]
    [StringLength(35)]
    public string? Formato { get; set; }

    [Column("usuario")]
    [StringLength(10)]
    public string? Usuario { get; set; }

    [Column("usufecha", TypeName = "datetime")]
    public DateTime? Usufecha { get; set; }

    [Column("usuhora")]
    [StringLength(8)]
    public string? Usuhora { get; set; }

    [Column("porporcentaje")]
    public short? Porporcentaje { get; set; }

    [Column("porprecio")]
    public short? Porprecio { get; set; }

    [Column("porcentaje")]
    public double? Porcentaje { get; set; }

    [Column("precio1")]
    public double? Precio1 { get; set; }

    [Column("precio2")]
    public double? Precio2 { get; set; }

    [Column("precio3")]
    public double? Precio3 { get; set; }

    [Column("precio4")]
    public double? Precio4 { get; set; }

    [Column("precio5")]
    public double? Precio5 { get; set; }

    [Column("precio6")]
    public double? Precio6 { get; set; }

    [Column("precio7")]
    public double? Precio7 { get; set; }

    [Column("precio8")]
    public double? Precio8 { get; set; }

    [Column("precio9")]
    public double? Precio9 { get; set; }

    [Column("precio10")]
    public double? Precio10 { get; set; }

    [Column("porscript")]
    public short? Porscript { get; set; }

    public double? A01 { get; set; }

    [Column("SSMA_TimeStamp")]
    public byte[] SsmaTimeStamp { get; set; } = null!;
}
