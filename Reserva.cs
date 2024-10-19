public class Reserva
{
    public string CodigoReserva { get; set; }
    public PacoteTuristico Pacote { get; set; }
    public Cliente Cliente { get; set; }
    private bool Status { get; set; } 

    public Reserva(string codigoReserva, PacoteTuristico pacote, Cliente cliente)
    {
        CodigoReserva = codigoReserva;
        Pacote = pacote;
        Cliente = cliente;
        Status = true; 
    }
    public void Cancelar()
    {
        Status = false;
        Pacote.Cancelar();
    }
}
