namespace GestionFacultadesCarreras.Models
{
    public class Carrera
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public int DuracionSemestres { get; set; }
        public string Modulacion { get; set; } = string.Empty;
    }
}
