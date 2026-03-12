public class Conversacion
{
    public int Id { get; set; }
    public int ClienteId { get; set; }
    public DateTime FechaInicio { get; set; } = DateTime.Now;
}