using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Table("concxc")]
[Index("ClaveCon", Name = "clave_con")]
[Index("Verificado", Name = "verificado")]
public partial class Concxc
{
    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("CLAVE_CON")]
    [StringLength(3)]
    public string ClaveCon { get; set; } = null!;

    [Column("DESCRIP")]
    [StringLength(40)]
    public string? Descrip { get; set; }

    [Column("TIPO_CXC")]
    [StringLength(1)]
    public string? TipoCxc { get; set; }

    [Column("FIJO")]
    public short? Fijo { get; set; }

    [Column("INGRESO")]
    public short? Ingreso { get; set; }

    [Column("FORMATO")]
    [StringLength(35)]
    public string? Formato { get; set; }

    [Column("USUARIO")]
    [StringLength(10)]
    public string? Usuario { get; set; }

    [Column("USUFECHA", TypeName = "datetime")]
    public DateTime? Usufecha { get; set; }

    [Column("USUHORA")]
    [StringLength(8)]
    public string? Usuhora { get; set; }

    [Column("COMISION")]
    public double? Comision { get; set; }

    [Column("verificado")]
    public short? Verificado { get; set; }

    [Column("moneda")]
    [StringLength(5)]
    public string? Moneda { get; set; }

    [Column("SSMA_TimeStamp")]
    public byte[] SsmaTimeStamp { get; set; } = null!;

    [Column("solicitarcuenta")]
    public int? Solicitarcuenta { get; set; }
}
