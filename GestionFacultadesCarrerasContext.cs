using Microsoft.EntityFrameworkCore;

public class GestionFacultadesCarrerasContext(DbContextOptions<GestionFacultadesCarrerasContext> options) : DbContext(options)
{
    public DbSet<GestionFacultadesCarreras.Models.Carrera> Carrera { get; set; } = default!;
    public DbSet<GestionFacultadesCarreras.Models.Facultad> Facultad { get; set; } = default!;
}
