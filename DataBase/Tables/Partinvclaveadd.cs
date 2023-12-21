using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("partinvclaveadd")]
[Index("Articulo", Name = "articulo")]
[Index("Clave", Name = "clave")]
[Index("Inventario", Name = "inventario")]
public partial class Partinvclaveadd
{
    [Column("INVENTARIO")]
    public int? Inventario { get; set; }

    [Column("ARTICULO")]
    [StringLength(30)]
    public string? Articulo { get; set; }

    [Column("DESCRIP")]
    [StringLength(50)]
    public string? Descrip { get; set; }

    [Column("EXISTENCIA")]
    public double? Existencia { get; set; }

    [Column("EREAL")]
    public double? Ereal { get; set; }

    [Column("AJUSTE")]
    public double? Ajuste { get; set; }

    [Column("ALMACEN")]
    [StringLength(255)]
    public string? Almacen { get; set; }

    [Column("USUARIO")]
    [StringLength(10)]
    public string? Usuario { get; set; }

    [Column("USUFECHA", TypeName = "datetime")]
    public DateTime? Usufecha { get; set; }

    [Column("USUHORA")]
    [StringLength(8)]
    public string? Usuhora { get; set; }

    [Column("MARCA")]
    [StringLength(5)]
    public string? Marca { get; set; }

    public double? Entradas { get; set; }

    public double? Salidas { get; set; }

    public double? Costo { get; set; }

    [StringLength(30)]
    public string? Clave { get; set; }

    [Column("SSMA_TimeStamp")]
    public byte[] SsmaTimeStamp { get; set; } = null!;
}
