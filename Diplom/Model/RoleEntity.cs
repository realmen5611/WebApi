using System.ComponentModel.DataAnnotations;

namespace Diplom.Model
{
    public class RoleEntity
    {
        [Key]
        public int idRole { get; set; }
        public string Role { get; set; }
    }
}
