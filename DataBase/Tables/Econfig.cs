using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Table("econfig")]
[Index("Empresa", Name = "empresa", IsUnique = true)]
public partial class Econfig
{
    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("EMPRESA")]
    [StringLength(100)]
    public string Empresa { get; set; } = null!;

    [StringLength(250)]
    public string? Direccion1 { get; set; }

    [Column("direccion2")]
    [StringLength(250)]
    public string? Direccion2 { get; set; }

    [Column("telefonos")]
    [StringLength(250)]
    public string? Telefonos { get; set; }

    [Column("cp")]
    [StringLength(5)]
    public string? Cp { get; set; }

    [Column("web")]
    [StringLength(250)]
    public string? Web { get; set; }

    [Column("email")]
    [StringLength(250)]
    public string? Email { get; set; }

    [Column("USUARIO")]
    [StringLength(10)]
    public string? Usuario { get; set; }

    [Column("clave")]
    [StringLength(10)]
    public string? Clave { get; set; }

    [Column("MONEDA")]
    [StringLength(5)]
    public string? Moneda { get; set; }

    [Column("LEYENDA")]
    [StringLength(50)]
    public string? Leyenda { get; set; }

    [Column("NOMBRE")]
    [StringLength(20)]
    public string? Nombre { get; set; }

    [Column("INVENTARIO")]
    public short? Inventario { get; set; }

    [Column("POLIZASG")]
    public short? Polizasg { get; set; }

    [Column("COSTEO")]
    [StringLength(8)]
    public string? Costeo { get; set; }

    [Column("FORMATO")]
    [StringLength(50)]
    public string? Formato { get; set; }

    [Column("FDINERO")]
    [StringLength(50)]
    public string? Fdinero { get; set; }

    [Column("IP")]
    [StringLength(30)]
    public string? Ip { get; set; }

    public int? Puerto { get; set; }

    public int? Niveles { get; set; }

    public int? Nivel1 { get; set; }

    public int? Nivel2 { get; set; }

    public int? Nivel3 { get; set; }

    public int? Nivel4 { get; set; }

    public int? Nivel5 { get; set; }

    [Column("POLIZAS")]
    [StringLength(3)]
    public string? Polizas { get; set; }

    public short? Servidor { get; set; }

    [Column("SUCURSAL")]
    [StringLength(50)]
    public string? Sucursal { get; set; }

    [Column("IPIntranet")]
    [StringLength(50)]
    public string? Ipintranet { get; set; }

    public double? H { get; set; }

    public double? S { get; set; }

    [Column("productos")]
    [StringLength(250)]
    public string? Productos { get; set; }

    [Column("weblocal")]
    [StringLength(250)]
    public string? Weblocal { get; set; }

    [Column("usarweblocal")]
    public short? Usarweblocal { get; set; }

    [Column("maximominimo")]
    public short? Maximominimo { get; set; }

    [Column("unsoloconteo")]
    public short? Unsoloconteo { get; set; }

    [Column("PASSWORD")]
    [StringLength(10)]
    public string? Password { get; set; }

    [Column("avanzado")]
    public short? Avanzado { get; set; }

    [Column("foliounicoremisiones")]
    public short? Foliounicoremisiones { get; set; }

    [Column("RFC")]
    [StringLength(250)]
    public string? Rfc { get; set; }

    [Column("logotipo")]
    [StringLength(250)]
    public string? Logotipo { get; set; }

    [Column("SSMA_TimeStamp")]
    public byte[] SsmaTimeStamp { get; set; } = null!;

    [Column("municipio")]
    [StringLength(30)]
    public string? Municipio { get; set; }

    [Column("pais")]
    [StringLength(30)]
    public string? Pais { get; set; }

    [Column("estado")]
    [StringLength(30)]
    public string? Estado { get; set; }

    [Column("localidad")]
    [StringLength(30)]
    public string? Localidad { get; set; }

    public short? FacturaE { get; set; }

    [Column("VENTA")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Venta { get; set; }
}
