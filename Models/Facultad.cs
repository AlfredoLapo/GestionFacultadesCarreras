using System.ComponentModel.DataAnnotations;

namespace GestionFacultadesCarreras.Models
{
    public class Facultad
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "El nombre de la facultad es obligatorio.")]
        [StringLength(150, ErrorMessage = "El nombre no puede exceder los 150 caracteres.")]
        public string Nombre { get; set; } = "";


        [StringLength(10)]
        public string? Telefono_Contacto { get; set; }

        public ICollection<Carrera> Carreras { get; set; } = new List<Carrera>();

    }
}
