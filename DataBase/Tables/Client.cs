using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Table("clients")]
[Index("Cliente", Name = "cliente", IsUnique = true)]
[Index("Nuevo", Name = "nuevo")]
public partial class Client
{
    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("CLIENTE")]
    [StringLength(30)]
    public string Cliente { get; set; } = null!;

    [Column("NOMBRE")]
    public string? Nombre { get; set; }

    [Column("CALLE")]
    public string? Calle { get; set; }

    [Column("NUMERO")]
    [StringLength(15)]
    public string? Numero { get; set; }

    [Column("COLONIA")]
    public string? Colonia { get; set; }

    [Column("POBLA")]
    public string? Pobla { get; set; }

    [Column("CIUDAD")]
    public string? Ciudad { get; set; }

    [Column("ESTADO")]
    public string? Estado { get; set; }

    [Column("PAIS")]
    public string? Pais { get; set; }

    [Column("TELEFONO")]
    public string? Telefono { get; set; }

    [Column("DIAS")]
    public double Dias { get; set; }

    [Column("CREDITO")]
    public double Credito { get; set; }

    [Column("DESC1")]
    public double Desc1 { get; set; }

    [Column("DESC2")]
    public double Desc2 { get; set; }

    [Column("DESC3")]
    public double Desc3 { get; set; }

    [Column("DESC4")]
    public double Desc4 { get; set; }

    [Column("DESC5")]
    public double Desc5 { get; set; }

    [Column("RFC")]
    [StringLength(20)]
    public string? Rfc { get; set; }

    [Column("TIPO")]
    [StringLength(5)]
    public string? Tipo { get; set; }

    [Column("CONTACTO")]
    [StringLength(50)]
    public string? Contacto { get; set; }

    [Column("COBRADOR")]
    [StringLength(10)]
    public string? Cobrador { get; set; }

    [Column("VEND")]
    [StringLength(15)]
    public string? Vend { get; set; }

    [Column("PRECIO")]
    public double Precio { get; set; }

    [Column("CP")]
    [StringLength(5)]
    public string? Cp { get; set; }

    [Column("PROSPECT")]
    public short? Prospect { get; set; }

    [Column("REVISION")]
    [StringLength(50)]
    public string? Revision { get; set; }

    [Column("OBSERV")]
    [StringLength(250)]
    public string? Observ { get; set; }

    [Column("ZONA")]
    [StringLength(5)]
    public string? Zona { get; set; }

    [Column("CORREO")]
    [StringLength(50)]
    public string? Correo { get; set; }

    [Column("URL")]
    [StringLength(250)]
    public string? Url { get; set; }

    [Column("SALDO")]
    public double Saldo { get; set; }

    [Column("USUARIO")]
    [StringLength(10)]
    public string? Usuario { get; set; }

    [Column("USUHORA")]
    [StringLength(8)]
    public string? Usuhora { get; set; }

    [Column("USUFECHA", TypeName = "datetime")]
    public DateTime? Usufecha { get; set; }

    [Column("PROVEEDOR")]
    [StringLength(20)]
    public string? Proveedor { get; set; }

    [Column("CURB")]
    [StringLength(20)]
    public string? Curb { get; set; }

    [Column("CORTE")]
    public int Corte { get; set; }

    [Column("COBRO")]
    [StringLength(10)]
    public string? Cobro { get; set; }

    [Column("CONCEPTO")]
    [StringLength(100)]
    public string? Concepto { get; set; }

    [Column("INGRESO", TypeName = "datetime")]
    public DateTime? Ingreso { get; set; }

    [Column("bloqueado")]
    public short Bloqueado { get; set; }

    [Column("claveweb")]
    [StringLength(10)]
    public string? Claveweb { get; set; }

    [Column("emailcobranza")]
    [StringLength(100)]
    public string? Emailcobranza { get; set; }

    [Column("embarcar")]
    [StringLength(100)]
    public string? Embarcar { get; set; }

    [Column("foto")]
    [StringLength(100)]
    public string? Foto { get; set; }

    [Column("puntos")]
    public int Puntos { get; set; }

    [Column("recomendado")]
    [StringLength(30)]
    public string? Recomendado { get; set; }

    [Column("comision")]
    public double Comision { get; set; }

    [Column("nuevo")]
    [StringLength(30)]
    public string? Nuevo { get; set; }

    [Column("SSMA_TimeStamp")]
    public byte[] SsmaTimeStamp { get; set; } = null!;

    [Column("localidad")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Localidad { get; set; }

    [Column("numerointerior")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Numerointerior { get; set; }

    [Column("numeroexterior")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Numeroexterior { get; set; }

    [Column("celular")]
    [StringLength(10)]
    public string? Celular { get; set; }

    [Column("uso")]
    [StringLength(50)]
    public string? Uso { get; set; }
}
