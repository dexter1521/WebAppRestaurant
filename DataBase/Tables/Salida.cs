using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Table("salidas")]
[Index("Cliente", Name = "cliente")]
[Index("Empleado", Name = "empleado")]
[Index("Ensamble", Name = "ensamble")]
[Index("Estado", Name = "estado")]
[Index("Ocupado", Name = "ocupado")]
[Index("Paraempleado", Name = "paraempleado")]
[Index("Salida1", Name = "salida", IsUnique = true)]
[Index("Traspaso", Name = "traspaso")]
public partial class Salida
{
    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("Salida")]
    public int Salida1 { get; set; }

    [Column("ocupado")]
    public short? Ocupado { get; set; }

    [Column("tipo_doc")]
    [StringLength(3)]
    public string? TipoDoc { get; set; }

    [Column("F_EMISION", TypeName = "datetime")]
    public DateTime? FEmision { get; set; }

    [Column("IMPORTE")]
    public double? Importe { get; set; }

    [Column("COSTO")]
    public double? Costo { get; set; }

    [Column("ALMACEN")]
    public short? Almacen { get; set; }

    [Column("ESTADO")]
    [StringLength(2)]
    public string? Estado { get; set; }

    [Column("OBSERV")]
    [StringLength(255)]
    public string? Observ { get; set; }

    [Column("DATOS")]
    [StringLength(255)]
    public string? Datos { get; set; }

    [Column("USUARIO")]
    [StringLength(10)]
    public string? Usuario { get; set; }

    [Column("USUFECHA", TypeName = "datetime")]
    public DateTime? Usufecha { get; set; }

    [Column("USUHORA")]
    [StringLength(8)]
    public string? Usuhora { get; set; }

    [Column("traspaso")]
    public int? Traspaso { get; set; }

    [Column("almt")]
    public int? Almt { get; set; }

    [Column("estraspaso")]
    public short? Estraspaso { get; set; }

    [Column("sucursal")]
    [StringLength(20)]
    public string? Sucursal { get; set; }

    [Column("esparasucursal")]
    public short? Esparasucursal { get; set; }

    [Column("entsuc")]
    public int? Entsuc { get; set; }

    [Column("folio")]
    public int? Folio { get; set; }

    [Column("estacion")]
    [StringLength(20)]
    public string? Estacion { get; set; }

    [Column("traspasoaestacion")]
    public short? Traspasoaestacion { get; set; }

    [Column("estaciontraspaso")]
    [StringLength(20)]
    public string? Estaciontraspaso { get; set; }

    [Column("cliente")]
    [StringLength(15)]
    public string? Cliente { get; set; }

    [Column("fecharetorno", TypeName = "datetime")]
    public DateTime? Fecharetorno { get; set; }

    [Column("ensamble")]
    public short? Ensamble { get; set; }

    [Column("empleado")]
    [StringLength(20)]
    public string? Empleado { get; set; }

    [Column("paraempleado")]
    public short? Paraempleado { get; set; }

    [Column("direccionembarque")]
    public string? Direccionembarque { get; set; }

    [Column("SSMA_TimeStamp")]
    public byte[] SsmaTimeStamp { get; set; } = null!;

    [Column("pedimentos")]
    public string? Pedimentos { get; set; }
}
