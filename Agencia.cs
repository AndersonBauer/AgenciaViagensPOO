using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using Microsoft.VisualBasic;
public class Agencia 
{
    private List<Destino> Destinos;
    private List<Cliente> Clientes;
    private List<PacoteTuristico> PacotesTuristicos;
    private List<Reserva> Reservas;

    public Agencia()
    {
        Reservas = new List<Reserva>();
        Destinos = new List<Destino>();
        Clientes = new List<Cliente>();
        PacotesTuristicos = new List<PacoteTuristico>();
    }
    public void CadastrarDestino(Destino Destino)
    {   
        // percorendo a lista de destinos para ver se nao tem uma destino ja cadastrado ou se esta nulo
        foreach(var destino in Destinos)
        {
            if(destino == Destino)
            {
                Console.WriteLine("Esse destino já está cadastrado.");
                return;
            }
        }
        foreach(var destino in Destinos)
        {
            if(destino == null)
            {
                Console.WriteLine("Destino inválido. Não pode ser nulo");
                return;
            }
        }
        Destinos.Add(Destino);
        Console.WriteLine("Destino cadastrado com sucesso.");
    }
    public void ConsultarDestinoPorCodigo(string codigoDestino)
    {
        foreach (var destino in Destinos )
        {
            if (destino.CodigoDestino == codigoDestino)
            {
                destino.ExibirInformacoesDestino();
                return;
            }
        }
        Console.WriteLine("Destino com o codigo informado não foi encontrado.");
    }
    public void ListarDestino()
    {
        if (Destinos.Count == 0)
        {
            Console.WriteLine("Não ha destinos cadastrados");
            return;
        }
        foreach(var destino in Destinos)
        {
            destino.ExibirInformacoesDestino();
        }
    }
    public void CadastrarCliente(Cliente Cliente)
    {
        foreach(var cliente in Clientes)
        {
            if(cliente == null)
            {
                Console.WriteLine("Cliente inválido. Não pode ser nulo.");
                return;
            }
        }
        foreach(var cliente in Clientes)
        {
            if(cliente == Cliente)
            {
                Console.WriteLine("Cliente já cadastrado.");
            }
        }
        Clientes.Add(Cliente);
    }
    public void ConsultarClientePorId(string IdCliente)
    {
        foreach(var cliente in Clientes)
        {
            if (cliente.IdCliente == IdCliente)
            {
                cliente.ExibirInformacoesCliente();
                return;
            }
        }
        Console.WriteLine("Código do cliente não encontrado!");
    }
    public void ListarCliente()
    {
        if(Clientes.Count == 0)
        {
            Console.WriteLine("Não existem clientes cadastrados.");
        }
        foreach(var cliente in Clientes)
        {
            cliente.ExibirInformacoesCliente();
        }
    }
    public void CadastrarPacote(PacoteTuristico PacoteTuristico)
    {
        foreach(var pacoteT in PacotesTuristicos)
        {
            if(pacoteT == null)
            {
                Console.WriteLine("Pacote turistico inválido. Não pode ser nulo.");
                return;
            }
        }
        foreach(var pacote in PacotesTuristicos)
        {
            if(pacote.CodigoPacote == PacoteTuristico.CodigoPacote)
            {
                Console.WriteLine("Pacote turistico já cadastrado.");
            }
        }
        PacotesTuristicos.Add(PacoteTuristico);
        Console.WriteLine("Pacote turistico cadastrado com sucesso!");
    }
    public PacoteTuristico ConsultarPacotePorCodigo(string CodigoPacote)
    {
        foreach(var pacote in PacotesTuristicos)
        {
            if(pacote.CodigoPacote == CodigoPacote)
            {
                Console.WriteLine($"\nPacote encontrado\nDestino do Pacote: {pacote.Destino}\nCodigo do pacote: {pacote.CodigoPacote}\nDescrição: {pacote.DescricaoServico}\nDataInicio: {pacote.DataInicio}\nData fim: {pacote.DataFim}\nPreço do pacote: {pacote.Preco}");
                return pacote;
            }
        }
        return null;
    }
    public void ListarPacote()
    {
        if(PacotesTuristicos.Count == 0)
        {
            Console.WriteLine("Nenhum pacote encontrado.");
        }
        foreach(var pacote in PacotesTuristicos)
        {
            Console.WriteLine($"\nPacote encontrado\nDestino do Pacote: {pacote.Destino}\nCodigo do pacote: {pacote.CodigoPacote}\nDescrição: {pacote.DescricaoServico}\nDataInicio: {pacote.DataInicio}\nData fim: {pacote.DataFim}\nPreço do pacote: {pacote.Preco}\n");
        }
    }
    public void ReservarPacote(string codigoPacote, Cliente cliente)
    {
        if(cliente == null)
        {
            Console.WriteLine("cliente invalido.");
            return;
        }
        var pacote = ConsultarPacotePorCodigo(codigoPacote);
        if(codigoPacote  == null)
        {
            Console.WriteLine("Pacote não encontrado.");
            return;
        }
        if(pacote == null)
        {
            Console.WriteLine("Pacote não encontrado.");
            return;
        }
        if(pacote.VagasDisponiveis<= 0)
        {
            Console.WriteLine("Não há vagas disponiveis para esse pacote.");
        }
        pacote.Reservar();
        Console.WriteLine("Pacote Reservado!");
    }
    public void CancelarReserva(string codigoReserva)
    {
        Reserva reservaEncontrada = null;
        foreach(var reserva in Reservas)
        {
            if (reserva.CodigoReserva == codigoReserva)
            {
                reservaEncontrada = reserva;
                break;
            }
            if(reservaEncontrada != null)
            {
                reservaEncontrada.Cancelar();
                Console.WriteLine($"Reserva com código {codigoReserva} foi cancelada com sucesso.");
            }
            else
            {
                Console.WriteLine("Reserva não encontrada.");
            }
        }
    }
}