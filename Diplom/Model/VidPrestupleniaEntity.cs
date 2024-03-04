using System.ComponentModel.DataAnnotations;

namespace Diplom.Model
{
    public class VidPrestupleniaEntity
    {
        [Key]

        public int idVidPrestuplenia { get; set; }
        public string vidPrestuplenia { get; set; }

    }
}
