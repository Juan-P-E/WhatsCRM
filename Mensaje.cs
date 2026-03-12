public class Mensaje
{
    public int Id { get; set; }
    public int ConversacionId { get; set; }
    public string Texto { get; set; } = "";
    public DateTime Fecha { get; set; } = DateTime.Now;
}