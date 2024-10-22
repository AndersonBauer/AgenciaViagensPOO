using System.Security.Cryptography.X509Certificates;

Agencia agencia = new Agencia();
bool continuar = true;

while (continuar)
{
    Console.WriteLine("===== Menu =====");
    Console.WriteLine("1 - Cadastrar Destino");
    Console.WriteLine("2 - Cadastrar Pacote Turístico");
    Console.WriteLine("3 - Cadastrar Cliente");
    Console.WriteLine("4 - Consultar Pacote por Código");
    Console.WriteLine("5 - Listar Destino por código");
    Console.WriteLine("6 - Listar Cliente por código");
    Console.WriteLine("7 - Listagem de todas as informações");
    Console.WriteLine("8 - Realizar reserva");
    Console.WriteLine("9 - Cancelar reserva");
    Console.WriteLine("0 - Sair");
    Console.Write("Escolha uma opção: ");

    string? opcao = Console.ReadLine();

    switch(opcao)
    {
        case "1":
            Console.Write("Digite o pais do destino: ");
            string? pais = Console.ReadLine();
            if (string.IsNullOrEmpty(pais))
            {
                Console.WriteLine("Nenhuma entrada foi fornecida.\n");
                break;
            }
            Console.Write("Digite o nome do local: ");
            string? local = Console.ReadLine();
            if (string.IsNullOrEmpty(local))
            {
                Console.WriteLine("Nenhuma entrada foi fornecida.\n");
                break;
            }

            Console.Write("Digite o código unico do destino: ");
            string? codigo = Console.ReadLine();
            if (string.IsNullOrEmpty(codigo))
            {
                Console.WriteLine("Nenhuma entrada foi fornecida.\n");
                break;
            }

            Console.Write("Digite a descriçaõ do destino: ");
            string? descricao = Console.ReadLine();
            if (string.IsNullOrEmpty(descricao))
            {
                Console.WriteLine("Nenhuma entrada foi fornecida.\n");
                break;
            }
            Destino destino1 = new Destino(local, pais ,codigo ,descricao);
            agencia.CadastrarDestino(destino1);
            break;

        case "2":

            Console.Write("Digite o nome do destino do pacote turistico: ");
            string? nome = Console.ReadLine();
            if(string.IsNullOrEmpty(nome))
            {
                Console.WriteLine("Nenhuma entrada foi fornecida.\n");
                break;
            }
            Console.Write("Digite o codigo do pacote: ");
            string? codigop = Console.ReadLine();
            if(string.IsNullOrEmpty(codigop))
            {
                Console.WriteLine("Nenhuma entrada foi fornecida.\n");
                break;
            }
            Console.Write("Digite a data em que inicia este pacote: ");
            string? DataIString = Console.ReadLine();
            DateTime? DataInicio = null;
            if(!string.IsNullOrEmpty(DataIString))
            {
                try
                {
                    DataInicio = DateTime.ParseExact(DataIString, "dd/MM/yyyy",null);
                }
                catch
                {
                    Console.WriteLine("Formato de data inválido, (dd/mm/aaaa).\n");
                    break;
                }
                
            if(string.IsNullOrEmpty(DataIString))
            {
                Console.WriteLine("Nenhuma entrada foi fornecida.\n");
                break;
            }
            }

            Console.Write("Digite a data em que finaliza este pacote: ");
            string? DataFString = Console.ReadLine();
            DateTime? DataFim = null;

            if(!string.IsNullOrEmpty(DataFString))
            {
                try
                {
                    DataFim = DateTime.ParseExact(DataFString, "dd/MM/yyyy", null);
                }
                catch
                {
                    Console.WriteLine("Formato de data inválido,tente usar (dd/mm/aaaa).\n");
                    break;
                }
                
            if(string.IsNullOrEmpty(DataFString))
            {
                Console.WriteLine("Nenhuma data valida foi fornecida.\n");
                break;
            }
            
            }

            Console.Write("Digite o valor que vai custar este pacote: ");
            string? precot = Console.ReadLine();
            decimal preco = 0;
            if(precot != null)
            {
                try
                {
                    preco = decimal.Parse(precot);
                }
                catch
                {
                    Console.WriteLine("Formato de valor inválido, (0.00)");
                    break;
                }
            }
            if(string.IsNullOrEmpty(precot))
            {
                Console.WriteLine("Nenhuma entrada foi fornecida.\n");
                break;
            }
            
            Console.Write("Quantas vagas terão esse pacote ? ");
            string? vagast = Console.ReadLine();
            int vagas = 0;
            if(!string.IsNullOrEmpty(vagast))
            {
                try
                {
                    vagas = int.Parse(vagast);
                }
                catch
                {
                    Console.WriteLine("Formato de valor inválido, apenas numeros.\n");
                    break;
                }
            }
            if(string.IsNullOrEmpty(vagast))
            {
                Console.WriteLine("Nenhuma entrada foi fornecida\n");
                break;
            }
            Console.Write("Digite o codigo do serviço: ");
            string? codigoS = Console.ReadLine();
            if (string.IsNullOrEmpty(codigoS))
            {
                Console.WriteLine("Nenhuma entrada foi fornecida\n");
                break;
            }
            Console.Write("Digite a descrição do serviço: ");
            string? descricaoS = Console.ReadLine();
            if (string.IsNullOrEmpty(descricaoS))
            {
                Console.WriteLine("Nenhuma entrada foi fornecida.\n");
                break;
            }
            PacoteTuristico NovoPacote = new PacoteTuristico(codigoS, codigop, descricaoS, nome, DataInicio.Value, DataFim.Value, preco, vagas);
            agencia.CadastrarPacote(NovoPacote);
            break;

        case "3":
            Console.Write("Digite o nome do cliente a ser cadastrado: ");
            string? NomeCliente = Console.ReadLine();
            if(string.IsNullOrEmpty(NomeCliente))
            {
                Console.WriteLine("Nenhuma entrada foi fornecida.\n");
                break;
            }
            Console.Write("Digite o cpf do cliente: ");
            string? cpf = Console.ReadLine();
            if(string.IsNullOrEmpty(cpf))
            {
                Console.WriteLine("Nenhuma entrada foi fornecida.\n");
                break;
            }
            Console.Write("Digite o contato do cliente: ");
            string? contato = Console.ReadLine();
            if(string.IsNullOrEmpty(contato))
            {
                Console.WriteLine("Nenhuma entrada foi fornecida.\n");
                break;
            }
            Cliente NovoCliente = new Cliente(NomeCliente, cpf, contato);
            agencia.CadastrarCliente(NovoCliente);
            break;
        
        case "4":
            Console.Write("Digite o Código do Pacote que deseja consultar: ");
            string? PacoteConsulta = Console.ReadLine();
            if(string.IsNullOrEmpty(PacoteConsulta))
            {
                Console.WriteLine("Nenhuma entrada foi informada.\n");
                break;
            }
            agencia.ConsultarPacotePorCodigo(PacoteConsulta);
            
            break;

        case "5":
            Console.Write("Digite o Código do destino que deseja consultar: ");
            string? DestinoConsulta = Console.ReadLine();
            if(string.IsNullOrEmpty(DestinoConsulta))
            {
                Console.WriteLine("Nenhuma entrada foi informada.\n");
                break;
            }
            agencia.ConsultarDestinoPorCodigo(DestinoConsulta);

            break;

        case "6":
            Console.Write("Digite o ID do Cliente que deseja consultar: ");
            string? ClienteConsulta = Console.ReadLine();
            if(string.IsNullOrEmpty(ClienteConsulta))
            {
                Console.WriteLine("Nenhuma entrada foi informada.\n");
                break;
            }
            agencia.ConsultarClientePorId(ClienteConsulta);

            break;

        case "7":
            Console.WriteLine("1 - Listar Cliente");
            Console.WriteLine("2 - Listar Pacote");
            Console.WriteLine("3 - Listar Destino");
            Console.WriteLine("0 - Voltar");
            string? opC = Console.ReadLine();
            switch(opC)
                {
                    case "1":
                        agencia.ListarCliente();
                        break;
                    case "2":
                        agencia.ListarPacote();
                        break;
                    case "3":
                        agencia.ListarDestino();
                        break;
                    case "0":
                        Console.WriteLine("\nVoltando...\n");
                        continue;
                }
            break;

        case "8":
            Console.Write("Digite o código do pacote desejado: ");
            string? PesqP = Console.ReadLine();
            string pesqp = "";

            if(string.IsNullOrEmpty(PesqP))
            {
                Console.WriteLine("Nenhuma entrada foi informada.");
                break;
            }
            else
            {
                pesqp = PesqP;    
            }
            Console.Write("Digite o cpf do Cliente: ");
            string? PesqC = Console.ReadLine();
            string pesqc ="";

            if(string.IsNullOrEmpty(PesqC))
            {
                Console.WriteLine("Nenhuma entrada foi informada.");
                break;
            }
            else
            {
                pesqc = PesqC;
            }
            agencia.ReservarPacote(pesqp, pesqc);
            break;

        case"9":
            Console.Write("Digite o código da reserva que deseja excluir: ");
            string? CodigoCancela = Console.ReadLine();
            
            if(string.IsNullOrEmpty(CodigoCancela))
            {
                Console.WriteLine("Nenhuma entrada foi cadastrada");
            }
            else
            {
               agencia.CancelarReserva(CodigoCancela); 
            }
            break;
        
        case "0":
            Console.WriteLine("\nFechando programa...\n");
            continuar = false;
            break;
        default:
            Console.WriteLine("\nDigite uma opção valida\n");
            continue; 
    }
}