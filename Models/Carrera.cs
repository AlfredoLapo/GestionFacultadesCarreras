using System.ComponentModel.DataAnnotations;

namespace GestionFacultadesCarreras.Models
{
    public class Carrera
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre de la carrera es obligatorio.")]
        [StringLength(100, ErrorMessage = "El nombre no puede exceder los 100 caracteres.")]
        [Display(Name = "Nombre de la Carrera")]
        public string Nombre { get; set; } = string.Empty;

        [Required(ErrorMessage = "La duración en semestres es obligatoria.")]
        [Range(1, 12, ErrorMessage = "La duración debe estar entre 1 y 12 semestres.")]
        [Display(Name = "Duración (Semestres)")]
        public int DuracionSemestres { get; set; }

        [Required(ErrorMessage = "La modulación es obligatoria.")]
        [StringLength(50, ErrorMessage = "La modulación no puede exceder los 50 caracteres.")]
        [Display(Name = "Modulación")]
        public string Modulacion { get; set; } = string.Empty;
    }
}