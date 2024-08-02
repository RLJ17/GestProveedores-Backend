using Microsoft.EntityFrameworkCore;

namespace ProveedoresEY.Models
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options):base(options)
        {
            
        }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Datos iniciales para Usuarios
            modelBuilder.Entity<Usuario>().HasData(
                new Usuario { Id = 1, User = "admin", Password = "admin123" },
                new Usuario { Id = 2, User = "user", Password = "user123" }
            );

            // Datos iniciales para Proveedores
            modelBuilder.Entity<Proveedor>().HasData(
                new Proveedor
                {
                    Id = 1,
                    RazonSocial = "BRIT ENTERPRISES CORP.",
                    NombreComercial = "Brit Enterprises",
                    IdentificacionTributaria = "123456789",
                    NumeroTelefonico = "1234567890",
                    CorreoElectronico = "contact@britenterprises.com",
                    SitioWeb = "http://www.britenterprises.com",
                    DireccionFisica = "123 Main St, London, UK",
                    Pais = "United Kingdom",
                    FacturacionAnual = 5000000m,
                    FechaUltimaEdicion = DateTime.Now
                },
                new Proveedor
                {
                    Id = 2,
                    RazonSocial = "BRIT SKY SERVICES INC.",
                    NombreComercial = "Brit Sky",
                    IdentificacionTributaria = "234567890",
                    NumeroTelefonico = "2345678901",
                    CorreoElectronico = "info@britsky.com",
                    SitioWeb = "http://www.britsky.com",
                    DireccionFisica = "456 High St, New York, USA",
                    Pais = "United States",
                    FacturacionAnual = 10000000m,
                    FechaUltimaEdicion = DateTime.Now
                },
                new Proveedor
                {
                    Id = 3,
                    RazonSocial = "MIDWEEK LTD.",
                    NombreComercial = "Midweek",
                    IdentificacionTributaria = "345678901",
                    NumeroTelefonico = "3456789012",
                    CorreoElectronico = "support@midweek.com",
                    SitioWeb = "http://www.midweek.com",
                    DireccionFisica = "789 Park Ave, Paris, France",
                    Pais = "France",
                    FacturacionAnual = 7500000m,
                    FechaUltimaEdicion = DateTime.Now
                },
                new Proveedor
                {
                    Id = 4,
                    RazonSocial = "KINSLEY IMPEX LIMITED",
                    NombreComercial = "Kinsley Impex",
                    IdentificacionTributaria = "456789012",
                    NumeroTelefonico = "4567890123",
                    CorreoElectronico = "sales@kinsleyimpex.com",
                    SitioWeb = "http://www.kinsleyimpex.com",
                    DireccionFisica = "123 Trade St, Tokyo, Japan",
                    Pais = "Japan",
                    FacturacionAnual = 6000000m,
                    FechaUltimaEdicion = DateTime.Now
                },
                new Proveedor
                {
                    Id = 5,
                    RazonSocial = "ZARAZEN S.A.",
                    NombreComercial = "Zarazen",
                    IdentificacionTributaria = "567890123",
                    NumeroTelefonico = "5678901234",
                    CorreoElectronico = "contact@zarazen.com",
                    SitioWeb = "http://www.zarazen.com",
                    DireccionFisica = "456 Market St, Berlin, Germany",
                    Pais = "Germany",
                    FacturacionAnual = 8500000m,
                    FechaUltimaEdicion = DateTime.Now
                },
                new Proveedor
                {
                    Id = 6,
                    RazonSocial = "MR. HOLIDAY LIMITED",
                    NombreComercial = "Mr. Holiday",
                    IdentificacionTributaria = "678901234",
                    NumeroTelefonico = "6789012345",
                    CorreoElectronico = "info@mrholiday.com",
                    SitioWeb = "http://www.mrholiday.com",
                    DireccionFisica = "789 Vacation Rd, Sydney, Australia",
                    Pais = "Australia",
                    FacturacionAnual = 3000000m,
                    FechaUltimaEdicion = DateTime.Now
                },
                new Proveedor
                {
                    Id = 7,
                    RazonSocial = "THE HIGHFLIERS CLUB LIMITED",
                    NombreComercial = "Highfliers Club",
                    IdentificacionTributaria = "789012345",
                    NumeroTelefonico = "7890123456",
                    CorreoElectronico = "membership@highfliersclub.com",
                    SitioWeb = "http://www.highfliersclub.com",
                    DireccionFisica = "123 Luxury Ln, Dubai, UAE",
                    Pais = "United Arab Emirates",
                    FacturacionAnual = 9500000m,
                    FechaUltimaEdicion = DateTime.Now
                },
                new Proveedor
                {
                    Id = 8,
                    RazonSocial = "ALLUCK INDUSTRIAL LTD.",
                    NombreComercial = "Alluck Industrial",
                    IdentificacionTributaria = "890123456",
                    NumeroTelefonico = "8901234567",
                    CorreoElectronico = "service@alluckindustrial.com",
                    SitioWeb = "http://www.alluckindustrial.com",
                    DireccionFisica = "456 Manufacturing St, Seoul, South Korea",
                    Pais = "South Korea",
                    FacturacionAnual = 50000000m,
                    FechaUltimaEdicion = DateTime.Now
                }
            );
        }
    }
}
