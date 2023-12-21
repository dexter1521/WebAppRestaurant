using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
public partial class VFeseriesFactura
{
    [StringLength(20)]
    public string SerieDocumento { get; set; } = null!;
}
