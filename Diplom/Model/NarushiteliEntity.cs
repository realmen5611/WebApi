using System.ComponentModel.DataAnnotations;

namespace Diplom.Model
{
    public class NarushiteliEntity
    {
        [Key]

        public int idNarushiteli {  get; set; }
        public string Familia { get; set; }
        public string Name { get; set; }
        public string Otchestvo { get; set; }
        public int idSanction {  get; set; }

    }
}
