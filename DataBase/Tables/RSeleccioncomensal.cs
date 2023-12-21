using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Table("r_seleccioncomensal")]
public partial class RSeleccioncomensal
{
    [Key] [Dapper.Contrib.Extensions.Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("id_comanda")]
    public int? IdComanda { get; set; }

    [Column("id_menu")]
    public int? IdMenu { get; set; }

    [Column("componente")]
    public string? Componente { get; set; }

    [Column("opcion1")]
    public string? Opcion1 { get; set; }

    [Column("opcion2")]
    public string? Opcion2 { get; set; }

    [Column("opcion3")]
    public string? Opcion3 { get; set; }

    [Column("seleccion")]
    public string? Seleccion { get; set; }

    [Column("notas")]
    public string? Notas { get; set; }

    [ForeignKey("IdComanda")]
    [InverseProperty("RSeleccioncomensals")]
    public virtual RComanda? IdComandaNavigation { get; set; }

    [ForeignKey("IdMenu")]
    [InverseProperty("RSeleccioncomensals")]
    public virtual RMenu? IdMenuNavigation { get; set; }
}
