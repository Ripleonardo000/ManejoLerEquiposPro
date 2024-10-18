using System.ComponentModel.DataAnnotations;

namespace ManejoEquiposPro.Models
{
    public class Equipo
    {
        [Key]
        public int IdEquipo { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string Ciudad { get; set; }

        [Required]

        public int titulos { get; set; }

        [Required]
        public Boolean AceptaExtranjero { get; set; }

         
    }
}
