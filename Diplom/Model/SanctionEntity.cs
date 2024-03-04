using System.ComponentModel.DataAnnotations;

namespace Diplom.Model
{
    public class SanctionEntity
    {
        [Key]

        public int idSanction {  get; set; }
        public string Sanction {  get; set; }
    }
}
