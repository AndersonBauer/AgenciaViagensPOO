public class Cliente
{
    protected string Nome { get; set; }
    public string IdCliente { get; set; }
    protected string Contato { get; set; }
    public Cliente(string nome, string idCliente, string contato)
    {
        Nome = nome;
        IdCliente = idCliente;
        Contato = contato;
    }

    public void ExibirInformacoesCliente()
    {
        Console.WriteLine($"\nId: {IdCliente}\nNome: {Nome}\nContato: {Contato}\n");
    }
}