using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Table("configpocketpc")]
public partial class Configpocketpc
{
    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("pocketpc")]
    public int Pocketpc { get; set; }

    [Column("imprimirventa")]
    public short Imprimirventa { get; set; }

    [Column("imprimircobranza")]
    public short Imprimircobranza { get; set; }

    [Column("imprimirdevolucion")]
    public short Imprimirdevolucion { get; set; }

    [Column("imprimirinventario")]
    public short Imprimirinventario { get; set; }

    [Column("imprimirreportes")]
    public short Imprimirreportes { get; set; }

    [Column("puerto")]
    [StringLength(5)]
    public string Puerto { get; set; } = null!;

    [Column("ticketsventa")]
    public short Ticketsventa { get; set; }

    [Column("ticketscredito")]
    public short Ticketscredito { get; set; }

    [Column("ticketsdevolucion")]
    public short Ticketsdevolucion { get; set; }

    [Column("piepaginaventa")]
    [StringLength(255)]
    public string Piepaginaventa { get; set; } = null!;

    [Column("piepaginacredito")]
    [StringLength(255)]
    public string Piepaginacredito { get; set; } = null!;

    [Column("preciosporvolumen")]
    public short Preciosporvolumen { get; set; }

    [Column("preciosporpresentacion")]
    public short Preciosporpresentacion { get; set; }

    [Column("cambiarprecios")]
    public short Cambiarprecios { get; set; }

    [Column("altaclientes")]
    public short Altaclientes { get; set; }

    [Column("cobranza")]
    public short Cobranza { get; set; }

    [Column("devoluciones")]
    public short Devoluciones { get; set; }

    [Column("inventariofisico")]
    public short Inventariofisico { get; set; }

    [Column("reportes")]
    public short Reportes { get; set; }

    [Column("sincronizarenlinea")]
    public short Sincronizarenlinea { get; set; }

    [Column("ip")]
    [StringLength(15)]
    public string Ip { get; set; } = null!;

    [Column("firma")]
    [StringLength(20)]
    public string Firma { get; set; } = null!;

    [Column("anchopapel")]
    public short? Anchopapel { get; set; }

    [Column("preciosporcliente")]
    public short? Preciosporcliente { get; set; }
}
