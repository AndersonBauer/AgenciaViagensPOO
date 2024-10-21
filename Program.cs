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
    Console.WriteLine("6 - Listar Destino por código");
    Console.WriteLine("7 - Listagem de todas as informações");
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
            if(nome == null)
            {
                Console.WriteLine("Nenhuma entrada foi fornecida.\n");
                break;
            }
            Console.Write("Digite o codigo do pacote: ");
            string? codigop = Console.ReadLine();
            if(codigop == null)
            {
                Console.WriteLine("Nenhuma entrada foi fornecida.\n");
                break;
            }
            Console.Write("Digite a data em que inicia este pacote: ");
            string? DataIString = Console.ReadLine();
            DateTime? DataInicio = null;
            if(DataIString != null)
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
                
            if(DataIString == null)
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
                
            if(DataFim == null)
            {
                Console.WriteLine("Nenhuma data valida foi fornecida.\n");
                break;
            }
            
            }

            Console.Write("Digite o valor que vai custar este pacote: ");
            string? precot = Console.ReadLine();
            decimal preco = 0;
            if(precot!= null)
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
            if(precot == null)
            {
                Console.WriteLine("Nenhuma entrada foi fornecida.\n");
                break;
            }
            
            Console.Write("Quantas vagas terão esse pacote ?");
            string? vagast = Console.ReadLine();
            int vagas = 0;
            if(vagast!= null)
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
            if(precot == null)
            {
                Console.WriteLine("Nenhuma entrada foi fornecida\n");
                break;
            }
            Console.Write("Digite o codigo do serviço: ");
            string? codigoS = Console.ReadLine();
            if (codigoS == null)
            {
                Console.WriteLine("Nenhuma entrada foi fornecida\n");
                break;
            }
            Console.Write("Digite a descrição do serviço: ");
            string? descricaoS = Console.ReadLine();
            if (descricaoS == null)
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
            if(NomeCliente == null)
            {
                Console.WriteLine("Nenhuma entrada foi fornecida.\n");
                break;
            }
            Console.Write("Digite o cpf do cliente: ");
            string? cpf = Console.ReadLine();
            if(cpf == null)
            {
                Console.WriteLine("Nenhuma entrada foi fornecida.\n");
                break;
            }
            Console.Write("Digite o contato do cliente: ");
            string? contato = Console.ReadLine();
            if(contato == null)
            {
                Console.WriteLine("Nenhuma entrada foi fornecida.\n");
                break;
            }
            Cliente NovoCliente = new Cliente(NomeCliente, cpf, contato);
            agencia.CadastrarCliente(NovoCliente);
            break;
        
        case "4":
        //continuar o Consultar pacote por codigo
            
            break;

        case "5":
        //continuar o listar destino por codigo

            break;

        case "6":
        //continuar o listar cliente por codigo

            break;

        case "7":
        //continuar o listar todos de cada um, com switch case mesmo tipo case 1 cliente, case 2 pacotes, case 3 destinos

            break;
        
        case "0":
            //sair

            break;
        default:
            //Digite uma opção válida



            break; //esse break é o break do switch
    }
}