public class Destino : IPesquisavel
{
    public string NomeLocal { get; set; }
    public string Pais { get; set; }
    public string CodigoDestino { get; set; }
    public string DescricaoDestino { get; set; }
    public Destino(string nomeLocal, string pais, string codigoDestino, string descricaoDestino)
    {
        NomeLocal = nomeLocal;
        Pais = pais;
        CodigoDestino = codigoDestino;
        DescricaoDestino = descricaoDestino;   
    }

    public void ExibirInformacoesDestino()
    {
        Console.WriteLine($"\nCodigo: {CodigoDestino}\nNome do Local: {NomeLocal}\nPais: {Pais}\nDescrição do destino: {DescricaoDestino}");
    }
}