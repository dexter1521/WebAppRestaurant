using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Table("sucursal")]
public partial class Sucursal
{
    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("Sucursal")]
    [StringLength(30)]
    public string Sucursal1 { get; set; } = null!;

    public string? Descrip { get; set; }

    public string? Usuario { get; set; }

    [Column("usuFecha", TypeName = "datetime")]
    public DateTime? UsuFecha { get; set; }

    [Column("usuHora")]
    public string? UsuHora { get; set; }

    public string? Direccion { get; set; }

    [Column("ip")]
    public string? Ip { get; set; }

    [Column("basedatos")]
    public string? Basedatos { get; set; }

    [Column("usuariodb")]
    public string? Usuariodb { get; set; }

    [Column("passworddb")]
    public string? Passworddb { get; set; }

    [Column("driver")]
    public string? Driver { get; set; }

    [Column("puerto")]
    public string? Puerto { get; set; }

    [Column("precios")]
    public string? Precios { get; set; }

    [Column("ventas")]
    public string? Ventas { get; set; }

    [Column("proveedor")]
    public string? Proveedor { get; set; }

    [Column("email")]
    public string? Email { get; set; }

    [Column("cliente")]
    public string? Cliente { get; set; }

    [Column("pais")]
    [StringLength(30)]
    public string? Pais { get; set; }

    [Column("calle")]
    [StringLength(100)]
    public string? Calle { get; set; }

    [Column("numeroexterior")]
    [StringLength(50)]
    public string? Numeroexterior { get; set; }

    [Column("numerointerior")]
    [StringLength(50)]
    public string? Numerointerior { get; set; }

    [Column("colonia")]
    [StringLength(50)]
    public string? Colonia { get; set; }

    [Column("localidad")]
    [StringLength(50)]
    public string? Localidad { get; set; }

    [Column("municipio")]
    [StringLength(50)]
    public string? Municipio { get; set; }

    [Column("cp")]
    [StringLength(50)]
    public string? Cp { get; set; }

    [Column("serie")]
    [StringLength(50)]
    public string? Serie { get; set; }

    [Column("almacen")]
    [StringLength(50)]
    public string? Almacen { get; set; }

    [Column("estado")]
    [StringLength(50)]
    public string? Estado { get; set; }

    [Column("usaremisor")]
    public int? Usaremisor { get; set; }
}
