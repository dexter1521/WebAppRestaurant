using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("pendient")]
[Index("FIni", Name = "f_ini")]
[Index("Id", Name = "id", IsUnique = true)]
[Index("Idcontacto", Name = "idcontacto")]
[Index("Para", Name = "para")]
[Index("Usuario", Name = "usuario")]
public partial class Pendient
{
    [Column("ID")]
    public int? Id { get; set; }

    [Column("PENDIENTE")]
    [StringLength(100)]
    public string? Pendiente { get; set; }

    [Column("OBSERV")]
    public string? Observ { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Fecha { get; set; }

    [StringLength(8)]
    public string? Hora { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaR { get; set; }

    [StringLength(8)]
    public string? HoraR { get; set; }

    [Column("IDContacto")]
    public int? Idcontacto { get; set; }

    [StringLength(20)]
    public string? Articulo { get; set; }

    [StringLength(20)]
    public string? Tipo { get; set; }

    [Column("ESTADO")]
    [StringLength(2)]
    public string? Estado { get; set; }

    [Column("F_ini")]
    [StringLength(50)]
    public string? FIni { get; set; }

    public short? Inte { get; set; }

    public short? Ins { get; set; }

    public short? Pag { get; set; }

    [StringLength(10)]
    public string? Para { get; set; }

    [StringLength(10)]
    public string? Usuario { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UsuFecha { get; set; }

    [StringLength(8)]
    public string? UsuHora { get; set; }

    [Column("SSMA_TimeStamp")]
    public byte[] SsmaTimeStamp { get; set; } = null!;
}
