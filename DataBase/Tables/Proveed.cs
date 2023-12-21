using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Table("proveed")]
[Index("Proveedor", Name = "proveedor", IsUnique = true)]
public partial class Proveed
{
    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("PROVEEDOR")]
    [StringLength(10)]
    public string Proveedor { get; set; } = null!;

    [Column("NOMBRE")]
    [StringLength(50)]
    public string? Nombre { get; set; }

    [Column("CALLE")]
    [StringLength(50)]
    public string? Calle { get; set; }

    [Column("COLONIA")]
    [StringLength(50)]
    public string? Colonia { get; set; }

    [Column("POBLA")]
    [StringLength(50)]
    public string? Pobla { get; set; }

    [Column("CIUDAD")]
    [StringLength(50)]
    public string? Ciudad { get; set; }

    [Column("ESTADO")]
    [StringLength(20)]
    public string? Estado { get; set; }

    [Column("PAIS")]
    [StringLength(20)]
    public string? Pais { get; set; }

    [Column("TELEFONO")]
    [StringLength(50)]
    public string? Telefono { get; set; }

    [Column("DIAS")]
    public double? Dias { get; set; }

    [Column("CREDITO")]
    public double? Credito { get; set; }

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

    [Column("CONTACTO")]
    [StringLength(50)]
    public string? Contacto { get; set; }

    [Column("RFC")]
    [StringLength(20)]
    public string? Rfc { get; set; }

    [Column("TIPO")]
    [StringLength(5)]
    public string? Tipo { get; set; }

    [Column("CP")]
    [StringLength(5)]
    public string? Cp { get; set; }

    [Column("REVISION")]
    [StringLength(50)]
    public string? Revision { get; set; }

    [Column("OBSERV")]
    [StringLength(255)]
    public string? Observ { get; set; }

    [Column("ZONA")]
    [StringLength(5)]
    public string? Zona { get; set; }

    [Column("URL")]
    [StringLength(250)]
    public string? Url { get; set; }

    [Column("MAIL")]
    [StringLength(50)]
    public string? Mail { get; set; }

    [Column("SALDO")]
    public double? Saldo { get; set; }

    [Column("USUARIO")]
    [StringLength(10)]
    public string? Usuario { get; set; }

    [Column("USUHORA")]
    [StringLength(8)]
    public string? Usuhora { get; set; }

    [Column("USUFECHA", TypeName = "datetime")]
    public DateTime? Usufecha { get; set; }

    public short? Externo { get; set; }

    public short? Interno { get; set; }

    [Column("curb")]
    [StringLength(20)]
    public string? Curb { get; set; }

    [Column("porcentajederetencion")]
    public double? Porcentajederetencion { get; set; }

    [Column("inicial")]
    public int? Inicial { get; set; }

    [Column("SSMA_TimeStamp")]
    public byte[] SsmaTimeStamp { get; set; } = null!;
}
