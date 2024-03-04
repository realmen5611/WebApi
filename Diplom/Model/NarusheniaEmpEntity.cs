using System.ComponentModel.DataAnnotations;

namespace Diplom.Model
{
    public class NarusheniaEmpEntity
    {
        [Key]

        public int idNarusheniaEmp {  get; set; }
        public int idEmployee { get; set; }
        public string Narushenia { get; set; }
    }
}
