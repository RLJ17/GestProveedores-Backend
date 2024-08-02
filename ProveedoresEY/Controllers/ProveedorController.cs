using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProveedoresEY.DTOs;
using ProveedoresEY.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization;

namespace ProveedoresEY.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ProveedorController : ControllerBase
    {
        private DatabaseContext _context;

        public ProveedorController(DatabaseContext databaseContext)
        {
            _context = databaseContext;
        }

        [HttpGet("all")]
        public async Task<ActionResult<IEnumerable<Proveedor>>> Get()
        {
            var proveedores = await _context.Proveedores.OrderByDescending(p => p.FechaUltimaEdicion).ToListAsync();
            return Ok(proveedores);
        }
            

        [HttpGet("{id}")]
        public async Task<ActionResult<ProveedorDto>> GetByID(int id)
        {
            var p = await _context.Proveedores.FindAsync(id);
            if (p == null) return NotFound();
            var proveedorDto = new ProveedorDto
            {
                RazonSocial = p.RazonSocial,
                NombreComercial = p.NombreComercial,
                IdentificacionTributaria = p.IdentificacionTributaria,
                Pais = p.Pais,
                FacturacionAnual = p.FacturacionAnual
            };
            return Ok(proveedorDto);
        }

        [HttpPost]
        public async Task<ActionResult<Proveedor>> Create(Proveedor p)
        {
            p.FechaUltimaEdicion = DateTime.UtcNow;
            await _context.Proveedores.AddAsync(p);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetByID), new {id = p.Id}, p);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<Proveedor>> Update(int id, Proveedor pNew)
        {
            var proveedor = await _context.Proveedores.FindAsync(id);
            if (proveedor == null) return NotFound();
            proveedor.RazonSocial = pNew.RazonSocial;
            proveedor.NombreComercial = pNew.NombreComercial;
            proveedor.IdentificacionTributaria = pNew.IdentificacionTributaria;
            proveedor.NumeroTelefonico = pNew.NumeroTelefonico;
            proveedor.CorreoElectronico = pNew.CorreoElectronico;
            proveedor.SitioWeb = pNew.SitioWeb;
            proveedor.DireccionFisica = pNew.DireccionFisica;
            proveedor.Pais = pNew.Pais;
            proveedor.FacturacionAnual = pNew.FacturacionAnual;
            proveedor.FechaUltimaEdicion = DateTime.UtcNow;
            await _context.SaveChangesAsync();
            return Ok(proveedor);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var proveedor = await _context.Proveedores.FindAsync(id);
            if (proveedor == null) return NotFound();
            _context.Proveedores.Remove(proveedor);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }

}

