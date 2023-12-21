using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("respues")]
[Index("Id", Name = "id", IsUnique = true)]
[Index("IdPendiente", Name = "idpendiente")]
[Index("Usuario", Name = "usuario")]
public partial class Respue
{
    public int? Id { get; set; }

    public int? IdPendiente { get; set; }

    [StringLength(100)]
    public string? Respuesta { get; set; }

    public string? Observ { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Fecha { get; set; }

    [StringLength(8)]
    public string? Hora { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaT { get; set; }

    [StringLength(8)]
    public string? HoraT { get; set; }

    public short? Solucion { get; set; }

    public short? Ultimo { get; set; }

    [Column("TLlamada")]
    [StringLength(50)]
    public string? Tllamada { get; set; }

    [StringLength(10)]
    public string? Usuario { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UsuFecha { get; set; }

    [StringLength(8)]
    public string? UsuHora { get; set; }

    [Column("SSMA_TimeStamp")]
    public byte[] SsmaTimeStamp { get; set; } = null!;
}
