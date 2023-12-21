using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("pagodev")]
[Index("Devolucion", Name = "devolucion", IsUnique = true)]
[Index("Pagado", Name = "pagado")]
public partial class Pagodev
{
    public int? Devolucion { get; set; }

    public double? Importe { get; set; }

    public short? Pagado { get; set; }

    [Column("SSMA_TimeStamp")]
    public byte[] SsmaTimeStamp { get; set; } = null!;
}
