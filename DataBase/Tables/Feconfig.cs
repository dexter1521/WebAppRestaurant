using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Tables;

[Keyless]
[Table("feconfig")]
public partial class Feconfig
{
    [StringLength(50)]
    [Unicode(false)]
    public string? Requestor { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? Country { get; set; }

    [StringLength(13)]
    [Unicode(false)]
    public string? Entity { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? User { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Username { get; set; }

    [Unicode(false)]
    public string? Server { get; set; }

    [Unicode(false)]
    public string? FileLocation { get; set; }

    [Unicode(false)]
    public string? Certificado { get; set; }

    [Column("E_CdgPaisEmisor")]
    [StringLength(2)]
    [Unicode(false)]
    public string? ECdgPaisEmisor { get; set; }

    [Column("E_TipoDeComprobante")]
    [StringLength(20)]
    [Unicode(false)]
    public string? ETipoDeComprobante { get; set; }

    [Column("E_RFCEmisor")]
    [StringLength(15)]
    [Unicode(false)]
    public string? ERfcemisor { get; set; }

    [Column("E_RazonSocialEmisor")]
    [Unicode(false)]
    public string? ERazonSocialEmisor { get; set; }

    [Column("E_Usuario")]
    [StringLength(30)]
    [Unicode(false)]
    public string? EUsuario { get; set; }

    [Column("E_NumeroInterno")]
    [StringLength(20)]
    [Unicode(false)]
    public string? ENumeroInterno { get; set; }

    [Column("E_Calle")]
    [Unicode(false)]
    public string? ECalle { get; set; }

    [Column("E_NumeroExterior")]
    [StringLength(15)]
    [Unicode(false)]
    public string? ENumeroExterior { get; set; }

    [Column("E_Colonia")]
    [Unicode(false)]
    public string? EColonia { get; set; }

    [Column("E_Municipio")]
    [Unicode(false)]
    public string? EMunicipio { get; set; }

    [Column("E_Estado")]
    [Unicode(false)]
    public string? EEstado { get; set; }

    [Column("E_Pais")]
    [Unicode(false)]
    public string? EPais { get; set; }

    [Column("E_CodigoPostal")]
    [StringLength(10)]
    [Unicode(false)]
    public string? ECodigoPostal { get; set; }

    [Column("R_CdgPaisEmisor")]
    [StringLength(2)]
    [Unicode(false)]
    public string? RCdgPaisEmisor { get; set; }

    [Column("R_RFCEmisor")]
    [StringLength(15)]
    [Unicode(false)]
    public string? RRfcemisor { get; set; }

    [Column("R_Nombre")]
    [Unicode(false)]
    public string? RNombre { get; set; }

    [Column("R_Calle")]
    [Unicode(false)]
    public string? RCalle { get; set; }

    [Column("R_NumeroExterior")]
    [StringLength(15)]
    [Unicode(false)]
    public string? RNumeroExterior { get; set; }

    [Column("R_Colonia")]
    [Unicode(false)]
    public string? RColonia { get; set; }

    [Column("R_Municipio")]
    [Unicode(false)]
    public string? RMunicipio { get; set; }

    [Column("R_Estado")]
    [Unicode(false)]
    public string? REstado { get; set; }

    [Column("R_Pais")]
    [Unicode(false)]
    public string? RPais { get; set; }

    [Column("R_CodigoPostal")]
    [StringLength(10)]
    [Unicode(false)]
    public string? RCodigoPostal { get; set; }

    [Column("R_Moneda")]
    [StringLength(3)]
    [Unicode(false)]
    public string? RMoneda { get; set; }

    [Column("R_TipoDeCambioVenta")]
    [StringLength(15)]
    [Unicode(false)]
    public string? RTipoDeCambioVenta { get; set; }

    [Column("R_SubTotal")]
    [StringLength(15)]
    [Unicode(false)]
    public string? RSubTotal { get; set; }

    [Column("R_TotalTraslados")]
    [StringLength(15)]
    [Unicode(false)]
    public string? RTotalTraslados { get; set; }

    [Column("R_IVA15")]
    [StringLength(15)]
    [Unicode(false)]
    public string? RIva15 { get; set; }

    [Column("R_Total")]
    [StringLength(20)]
    [Unicode(false)]
    public string? RTotal { get; set; }

    [Column("R_TotalEnLetra")]
    [Unicode(false)]
    public string? RTotalEnLetra { get; set; }

    [Column("R_FormaDePago")]
    [Unicode(false)]
    public string? RFormaDePago { get; set; }

    [Unicode(false)]
    public string? CadenaOriginal { get; set; }
}
