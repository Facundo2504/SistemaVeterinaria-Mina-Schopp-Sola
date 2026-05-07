namespace SistemaVeterinariaAPI.Entidades;
public class Atencion
{
    public int Id { get; set; }
    public int AnimalId { get; set; }
    public Animales? Animal { get; set; }
    public DateTime FechaAtencion { get; set; }
    public string Descripcion { get; set; } = string.Empty;
}