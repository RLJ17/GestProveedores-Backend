using System.ComponentModel.DataAnnotations;

namespace ProveedoresEY.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        [Required] public string User { get; set; } = null!;
        [Required] public string Password { get; set; } = null!;
    }
}
