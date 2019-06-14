using System.ComponentModel.DataAnnotations.Schema;

namespace Jwt_DotNetCore.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        public int UsuarioId { get; set; }  
        public string Login {get ; set; }
        public string Senha {get ; set; }
        public string Email {get ; set; }
    }
}