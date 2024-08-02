using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProveedoresEY.DTOs;
using ProveedoresEY.Models;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace ProveedoresEY.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private DatabaseContext _context;
        private IConfiguration config;
        public UsuarioController(DatabaseContext databaseContext, IConfiguration config)
        {
            _context = databaseContext;
            this.config = config;
        }

        [HttpPost("login")]
        public async Task<ActionResult> Login(Usuario user)
        {
            var usuario = await _context.Usuarios.SingleOrDefaultAsync(u => u.User == user.User && u.Password == user.Password);
            if (usuario == null) return Unauthorized();
            string jwt = GenerateToken(user.User, 180);
            var cookieOptions = new CookieOptions
            {
                HttpOnly = false,
                Expires = DateTime.UtcNow.AddMonths(1),
                Secure = true, 
                SameSite = SameSiteMode.None
            };

            Response.Cookies.Append("jwt", jwt, cookieOptions);

            return Ok(new { token = jwt });
        }

        [HttpGet("logout")]
        public IActionResult Logout()
        {
            string jwt = GenerateToken("expiredUser", 1);
            var cookieOptions = new CookieOptions
            {
                HttpOnly = false,
                Expires = DateTime.UtcNow.AddSeconds(1),
                Secure = true,
                SameSite = SameSiteMode.None
            };

            Response.Cookies.Append("jwt", jwt, cookieOptions);

            return Ok(new { message = "Logged out successfully" });
        }



        private string GenerateToken(string user, int minutos) {
            var claims = new[]
            {
                new Claim(ClaimTypes.Name, user)
            };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("super_long_secret_key_ultrasecret_must_be_at_least_64_bytes_long_super_long_secret_key_ultrasecret")); //config.GetSection("JWT: Key").Value
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var securityToken = new JwtSecurityToken(claims: claims, expires:DateTime.Now.AddMinutes(minutos), signingCredentials: creds);
            string token = new JwtSecurityTokenHandler().WriteToken(securityToken);
            return token;
        }
    }
}
