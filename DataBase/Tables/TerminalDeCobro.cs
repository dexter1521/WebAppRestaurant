using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Table("terminalDeCobro")]
public partial class TerminalDeCobro
{
    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("idDelCliente")]
    public int IdDelCliente { get; set; }

    [Column("cuenta")]
    public long? Cuenta { get; set; }

    [Column("monto")]
    public double Monto { get; set; }

    [Column("propina")]
    public double Propina { get; set; }

    [Column("total")]
    public double Total { get; set; }

    [Column("idTransaccion")]
    public long? IdTransaccion { get; set; }

    [Column("idTransaccionPuntoClave")]
    public long? IdTransaccionPuntoClave { get; set; }

    [Column("tipoOperacion")]
    public short TipoOperacion { get; set; }

    [Column("numeroDeAutorizacion")]
    public long? NumeroDeAutorizacion { get; set; }

    [Column("mensaje")]
    [Unicode(false)]
    public string? Mensaje { get; set; }

    [Column("formaDeLectura")]
    public short? FormaDeLectura { get; set; }

    [Column("afiliacion")]
    public long? Afiliacion { get; set; }

    [Column("debitoCredito")]
    [StringLength(20)]
    [Unicode(false)]
    public string? DebitoCredito { get; set; }

    [Column("marcaTarjeta")]
    [StringLength(20)]
    [Unicode(false)]
    public string? MarcaTarjeta { get; set; }

    [Column("emisoraDeTarjeta")]
    [StringLength(50)]
    public string? EmisoraDeTarjeta { get; set; }

    [Column("idTerminal")]
    public int IdTerminal { get; set; }

    [Column("tipo_doc")]
    [StringLength(20)]
    [Unicode(false)]
    public string? TipoDoc { get; set; }

    [Column("numero_doc")]
    public long? NumeroDoc { get; set; }

    [Column("f_emision", TypeName = "datetime")]
    public DateTime FEmision { get; set; }

    [Column("usuario")]
    [StringLength(10)]
    public string Usuario { get; set; } = null!;

    [Column("usuhora")]
    [StringLength(8)]
    public string Usuhora { get; set; } = null!;
}
