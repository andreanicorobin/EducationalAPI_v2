using Microsoft.EntityFrameworkCore;
using WebEducational_API.Infrastructure.Model;

public class EducationalDbContext : DbContext
{
    public EducationalDbContext(DbContextOptions<EducationalDbContext> options) : base(options) { }

    public DbSet<Estudiante> Estudiantes { get; set; }
    public DbSet<Profesor> Profesores { get; set; }
    public DbSet<Materia> Materias { get; set; }
    public DbSet<Inscripcion> Inscripciones { get; set; }
}
