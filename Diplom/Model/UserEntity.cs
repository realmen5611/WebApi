using System.ComponentModel.DataAnnotations;

namespace Diplom.Model
{
    public class UserEntity
    {
        [Key]

        public int idUser { get; set; }
        public int idRole { get; set; }
        public string Login {  get; set; }
        public string Password {  get; set; }

        public RoleEntity Role { get; set; }
    }
}
