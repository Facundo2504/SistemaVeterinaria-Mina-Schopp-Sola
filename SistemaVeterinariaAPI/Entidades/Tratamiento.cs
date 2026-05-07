namespace SistemaVeterinariaAPI.Entidades;
public class Tratamiento
{
    public int Id { get; set; }
    public int AtencionId { get; set; }
    public Atencion? Atencion { get; set; }
    public DateTime FechaTratamiento { get; set; }
    public string Descripcion { get; set; } = string.Empty;
}