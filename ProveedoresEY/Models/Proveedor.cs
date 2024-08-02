using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProveedoresEY.Models
{
    public class Proveedor
    {
        public int Id { get; set; }
        [Required] public string RazonSocial { get; set; } = null!;
        [Required] public string NombreComercial { get; set; } = null!;
        [Required] public string IdentificacionTributaria { get; set; } = null!;
        [Required][Phone] public string NumeroTelefonico { get; set; } = null!;
        [Required][EmailAddress] public string CorreoElectronico { get; set; } = null!;
        [Url] public string SitioWeb { get; set; } = string.Empty;
        [Required] public string DireccionFisica { get; set; } = null!;
        [Required] public string Pais { get; set; } = null!;

        [Required][DataType(DataType.Currency)][Range(0, double.MaxValue)][Column(TypeName = "decimal(18,2)")]
        public decimal FacturacionAnual { get; set; }

        [Required][DataType(DataType.DateTime)]
        public DateTime FechaUltimaEdicion { get; set; }
    }


}
