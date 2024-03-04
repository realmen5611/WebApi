using System.ComponentModel.DataAnnotations;

namespace Diplom.Model
{
    public class PolEntity
    {
        [Key]

        public int idPol { get; set; }
        public string Pol { get; set; }

    }
}
