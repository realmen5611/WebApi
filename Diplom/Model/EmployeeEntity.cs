using Org.BouncyCastle.Asn1.Mozilla;
using System.ComponentModel.DataAnnotations;

namespace Diplom.Model
{
    public class EmployeeEntity
    {
        [Key]

        public int idEmployee { get; set; }
        public int idUser { get; set; }
        public string Familia { get; set; }
        public string Name { get; set; }
        public string Otchestvo { get; set; }
        public string NumberTelephone { get; set; }
        public int IdPol { get; set; }
        public int IdDolshnost {  get; set; }

    }
}
