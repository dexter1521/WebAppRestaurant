using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("cfd_datos")]
public partial class CfdDato
{
    [Column("nombre")]
    [StringLength(100)]
    public string? Nombre { get; set; }

    [Column("rfc")]
    [StringLength(50)]
    public string? Rfc { get; set; }

    [Column("calle")]
    [StringLength(100)]
    public string? Calle { get; set; }

    [Column("CP")]
    [StringLength(10)]
    public string? Cp { get; set; }

    [Column("colonia")]
    [StringLength(50)]
    public string? Colonia { get; set; }

    [Column("estado")]
    [StringLength(50)]
    public string? Estado { get; set; }

    [Column("localidad")]
    [StringLength(50)]
    public string? Localidad { get; set; }

    [Column("municipio")]
    [StringLength(50)]
    public string? Municipio { get; set; }

    [Column("numeroExterior")]
    [StringLength(50)]
    public string? NumeroExterior { get; set; }

    [Column("numeroInterior")]
    [StringLength(50)]
    public string? NumeroInterior { get; set; }

    [Column("certificado")]
    public string? Certificado { get; set; }

    [Column("archivokey")]
    public string? Archivokey { get; set; }

    [Column("clave")]
    [StringLength(50)]
    public string? Clave { get; set; }

    [Column("serie")]
    [StringLength(50)]
    public string? Serie { get; set; }

    [Column("directoriocomprobantes")]
    public string? Directoriocomprobantes { get; set; }

    [Column("mail")]
    [StringLength(100)]
    public string? Mail { get; set; }

    [Column("serienc")]
    [StringLength(50)]
    public string? Serienc { get; set; }

    [Column("llaveprivada")]
    [StringLength(250)]
    public string? Llaveprivada { get; set; }

    [Column("urlwebservice")]
    [StringLength(200)]
    public string? Urlwebservice { get; set; }

    [Column("tipoFactura")]
    [StringLength(10)]
    public string? TipoFactura { get; set; }

    [Column("mododeprueba")]
    public int? Mododeprueba { get; set; }

    [Column("regimenfiscal")]
    [StringLength(100)]
    public string? Regimenfiscal { get; set; }

    [Column("formato")]
    [StringLength(250)]
    public string? Formato { get; set; }

    [Column("registroPatronal")]
    [StringLength(100)]
    public string? RegistroPatronal { get; set; }

    [Column("serienom")]
    [StringLength(100)]
    public string? Serienom { get; set; }

    [Column("formatonom")]
    [StringLength(250)]
    public string? Formatonom { get; set; }

    [Column("curp")]
    [StringLength(250)]
    public string? Curp { get; set; }

    [Column("regimennomina")]
    [StringLength(250)]
    public string? Regimennomina { get; set; }
}
