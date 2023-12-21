using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Table("clavesadd")]
[Index("Articulo", Name = "IX_clavesadd")]
[Index("Articulo", Name = "articulo")]
[Index("Clave", Name = "clave", IsUnique = true)]
[Index("Exportado", Name = "exportado")]
public partial class Clavesadd
{
    [Key] [Dapper.Contrib.Extensions.Key]
    [StringLength(30)]
    public string Clave { get; set; } = null!;

    [StringLength(100)]
    public string Dato1 { get; set; } = null!;

    [StringLength(10)]
    public string Usuario { get; set; } = null!;

    [Column("usuFecha", TypeName = "datetime")]
    public DateTime UsuFecha { get; set; }

    [Column("usuHora")]
    [StringLength(8)]
    public string UsuHora { get; set; } = null!;

    [StringLength(20)]
    public string Dato2 { get; set; } = null!;

    [StringLength(30)]
    public string Articulo { get; set; } = null!;

    public double Cantidad { get; set; }

    [StringLength(40)]
    public string Unidad { get; set; } = null!;

    public double Existencia { get; set; }

    public short Libre { get; set; }

    public short Exportado { get; set; }

    public double Precio { get; set; }

    [Column("imagen")]
    [StringLength(100)]
    public string Imagen { get; set; } = null!;

    [Column("etiquetas")]
    public int Etiquetas { get; set; }

    [Column("SSMA_TimeStamp")]
    public byte[] SsmaTimeStamp { get; set; } = null!;
}
