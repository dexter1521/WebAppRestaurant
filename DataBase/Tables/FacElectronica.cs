using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Table("FacElectronica")]
public partial class FacElectronica
{
    [Key] [Dapper.Contrib.Extensions.Key]
    [StringLength(50)]
    [Unicode(false)]
    public string Id { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? Folio { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NumAprob { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? Año { get; set; }
}
