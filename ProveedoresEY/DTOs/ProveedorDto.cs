namespace ProveedoresEY.DTOs
{
    public class ProveedorDto
    {
        public required string RazonSocial { get; set; }
        public required string NombreComercial { get; set; }
        public required string IdentificacionTributaria { get; set; }
        public required string Pais { get; set; }
        public decimal FacturacionAnual { get; set; }
    }
}
