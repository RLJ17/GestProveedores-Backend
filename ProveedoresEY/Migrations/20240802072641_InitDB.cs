using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProveedoresEY.Migrations
{
    /// <inheritdoc />
    public partial class InitDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Proveedores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RazonSocial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NombreComercial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdentificacionTributaria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroTelefonico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CorreoElectronico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SitioWeb = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DireccionFisica = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pais = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FacturacionAnual = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FechaUltimaEdicion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proveedores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Proveedores",
                columns: new[] { "Id", "CorreoElectronico", "DireccionFisica", "FacturacionAnual", "FechaUltimaEdicion", "IdentificacionTributaria", "NombreComercial", "NumeroTelefonico", "Pais", "RazonSocial", "SitioWeb" },
                values: new object[,]
                {
                    { 1, "contact@britenterprises.com", "123 Main St, London, UK", 5000000m, new DateTime(2024, 8, 2, 2, 26, 41, 132, DateTimeKind.Local).AddTicks(1586), "123456789", "Brit Enterprises", "1234567890", "United Kingdom", "BRIT ENTERPRISES CORP.", "http://www.britenterprises.com" },
                    { 2, "info@britsky.com", "456 High St, New York, USA", 10000000m, new DateTime(2024, 8, 2, 2, 26, 41, 132, DateTimeKind.Local).AddTicks(1596), "234567890", "Brit Sky", "2345678901", "United States", "BRIT SKY SERVICES INC.", "http://www.britsky.com" },
                    { 3, "support@midweek.com", "789 Park Ave, Paris, France", 7500000m, new DateTime(2024, 8, 2, 2, 26, 41, 132, DateTimeKind.Local).AddTicks(1627), "345678901", "Midweek", "3456789012", "France", "MIDWEEK LTD.", "http://www.midweek.com" },
                    { 4, "sales@kinsleyimpex.com", "123 Trade St, Tokyo, Japan", 6000000m, new DateTime(2024, 8, 2, 2, 26, 41, 132, DateTimeKind.Local).AddTicks(1629), "456789012", "Kinsley Impex", "4567890123", "Japan", "KINSLEY IMPEX LIMITED", "http://www.kinsleyimpex.com" },
                    { 5, "contact@zarazen.com", "456 Market St, Berlin, Germany", 8500000m, new DateTime(2024, 8, 2, 2, 26, 41, 132, DateTimeKind.Local).AddTicks(1630), "567890123", "Zarazen", "5678901234", "Germany", "ZARAZEN S.A.", "http://www.zarazen.com" },
                    { 6, "info@mrholiday.com", "789 Vacation Rd, Sydney, Australia", 3000000m, new DateTime(2024, 8, 2, 2, 26, 41, 132, DateTimeKind.Local).AddTicks(1632), "678901234", "Mr. Holiday", "6789012345", "Australia", "MR. HOLIDAY LIMITED", "http://www.mrholiday.com" },
                    { 7, "membership@highfliersclub.com", "123 Luxury Ln, Dubai, UAE", 9500000m, new DateTime(2024, 8, 2, 2, 26, 41, 132, DateTimeKind.Local).AddTicks(1634), "789012345", "Highfliers Club", "7890123456", "United Arab Emirates", "THE HIGHFLIERS CLUB LIMITED", "http://www.highfliersclub.com" },
                    { 8, "service@alluckindustrial.com", "456 Manufacturing St, Seoul, South Korea", 50000000m, new DateTime(2024, 8, 2, 2, 26, 41, 132, DateTimeKind.Local).AddTicks(1635), "890123456", "Alluck Industrial", "8901234567", "South Korea", "ALLUCK INDUSTRIAL LTD.", "http://www.alluckindustrial.com" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Password", "User" },
                values: new object[,]
                {
                    { 1, "admin123", "admin" },
                    { 2, "user123", "user" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Proveedores");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
