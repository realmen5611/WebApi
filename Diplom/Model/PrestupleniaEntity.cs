using System.ComponentModel.DataAnnotations;

namespace Diplom.Model
{
    public class PrestupleniaEntity
    {
        [Key]

        public int idPrestuplenia { get; set; }
        public int idVidPrestuplenia { get; set; }
        public string Prestuplenie { get; set; }
        public bool Vipolnenie { get; set; }
        public int idNarushiteli { get; set; }
        public int idEmployee {  get; set; }
    }
}
