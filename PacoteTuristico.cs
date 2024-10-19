using System.Xml.Serialization;

public class PacoteTuristico : ServicoViagem, IReservavel, IPesquisavel
{
    public Destino Destino { get; set; }
    public string CodigoPacote { get; set; }
    public DateTime DataInicio { get; set; }
    public DateTime DataFim { get; set; }
    public decimal Preco { get; set; }
    public int VagasDisponiveis { get; set; }
    public PacoteTuristico(string codigoServico,string codigoPacote, string descricaoServico,Destino destino, DateTime dataInicio, DateTime dataFim, decimal preco, int vagasDisponiveis)
    :base(codigoServico, descricaoServico)
    {
        Destino = destino;
        DataInicio = dataInicio;
        DataFim = dataFim;
        Preco = preco;
        VagasDisponiveis = vagasDisponiveis;
        CodigoPacote = codigoPacote;

    }

    public override void Reservar()
    {
        if(VagasDisponiveis > 0)
        {
            VagasDisponiveis -= 1;
            Console.WriteLine("\nReserva confirmada. ");
        }else{
            Console.WriteLine("\nInfelizmente não temos vagas disponiveis no momento.");
        }
    }
    public override void Cancelar()
    {
        VagasDisponiveis += 1;
        Console.WriteLine("\nReserva cancelada");
    }
}