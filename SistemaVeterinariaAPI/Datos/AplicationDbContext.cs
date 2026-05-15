namespace SistemaVeterinariaAPI.Datos;
using Microsoft.EntityFrameworkCore;
using SistemaVeterinariaAPI.Entidades;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<Dueño> Dueños => Set<Dueño>();
    public DbSet<Animales> Animales => Set<Animales>();
    public DbSet<TipoAnimal> TipoAnimales => Set<TipoAnimal>(); 
    public DbSet<Raza> Razas => Set<Raza>();
    public DbSet<Atencion> Atenciones => Set<Atencion>();
    public DbSet<Tratamiento> Tratamientos => Set<Tratamiento>();
    public DbSet<Medicamento> Medicamentos => Set<Medicamento>();
    
}
