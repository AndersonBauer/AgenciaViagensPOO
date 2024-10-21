public abstract class ServicoViagem
{   
    //Colocando propriedades
    protected string CodigoServico { get; set; } //Codigo só poderá ser usado nessa classe ou em classes derivadas por conta do protected
    public string DescricaoServico { get; set; }
    public ServicoViagem(string codigoServico, string descricaoServico)
    {
        CodigoServico = codigoServico;
        DescricaoServico = descricaoServico;
    }
    
    //Colocando métodos abstratos
    public abstract void Reservar();
    public abstract void Cancelar();
}