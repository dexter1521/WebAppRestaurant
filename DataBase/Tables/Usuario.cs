using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Table("usuarios")]
[Index("Usuario1", Name = "usuario", IsUnique = true)]
public partial class Usuario
{
    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("USUARIO")]
    [StringLength(10)]
    public string Usuario1 { get; set; } = null!;

    [Column("clave")]
    [StringLength(50)]
    public string? Clave { get; set; }

    [Column("NOMBRE")]
    [StringLength(50)]
    public string? Nombre { get; set; }

    [Column("AREA")]
    [StringLength(30)]
    public string? Area { get; set; }

    [Column("DERECHOS")]
    [StringLength(250)]
    public string? Derechos { get; set; }

    [Column("FOTO")]
    [StringLength(250)]
    public string? Foto { get; set; }

    [Column("SUPERVISOR")]
    public short? Supervisor { get; set; }

    [Column("ACTIVOS")]
    public int? Activos { get; set; }

    [Column("SACAR")]
    public short? Sacar { get; set; }

    [StringLength(10)]
    public string? Opera { get; set; }

    [Column("FACTURAR")]
    public short? Facturar { get; set; }

    [Column("COBRAR")]
    public short? Cobrar { get; set; }

    [Column("FACTURAS")]
    public short? Facturas { get; set; }

    [Column("DEVOLUC")]
    public short? Devoluc { get; set; }

    [Column("PAGOS")]
    public short? Pagos { get; set; }

    [Column("COTIZA")]
    public short? Cotiza { get; set; }

    [Column("COBRANZA")]
    public short? Cobranza { get; set; }

    [Column("CAMFECHA")]
    public short? Camfecha { get; set; }

    [Column("NUMPOLIZA")]
    public short? Numpoliza { get; set; }

    [Column("PERIODOS")]
    public short? Periodos { get; set; }

    [Column("MODIFICAPRECIO")]
    [StringLength(255)]
    public string? Modificaprecio { get; set; }

    public short? Existencia { get; set; }

    [Column("existsalidas")]
    public short? Existsalidas { get; set; }

    [Column("gerenciales")]
    public short? Gerenciales { get; set; }

    [Column("vendedor")]
    [StringLength(15)]
    public string? Vendedor { get; set; }

    [Column("surtirpedidos")]
    public short? Surtirpedidos { get; set; }

    [Column("cobrador")]
    [StringLength(15)]
    public string? Cobrador { get; set; }
}
