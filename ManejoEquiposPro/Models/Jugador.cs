using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManejoEquiposPro.Models
{
    public class Jugador
    {

        [Key]
        public int IdJugador { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string Posicion { get; set; }
        [Required]
        public int Edad {  get; set; }

        public Equipo Equipo { get; set; }

        [ForeignKey("Equipo")]
        public int IdEquipo { get; set; }
    }
}
