class Menu
{
    void ExibirLogo(){

        Console.WriteLine(@"
  /$$$$$$                        /$$                 /$$                           /$$                  /$$$$$$  /$$ /$$                       /$$              
 /$$__  $$                      | $$                | $$                          | $$                 /$$__  $$| $$|__/                      | $$              
| $$  \__/  /$$$$$$  /$$$$$$$  /$$$$$$    /$$$$$$  /$$$$$$    /$$$$$$         /$$$$$$$  /$$$$$$       | $$  \__/| $$ /$$  /$$$$$$  /$$$$$$$  /$$$$$$    /$$$$$$ 
| $$       /$$__  $$| $$__  $$|_  $$_/   |____  $$|_  $$_/   /$$__  $$       /$$__  $$ /$$__  $$      | $$      | $$| $$ /$$__  $$| $$__  $$|_  $$_/   /$$__  $$
| $$      | $$  \ $$| $$  \ $$  | $$      /$$$$$$$  | $$    | $$  \ $$      | $$  | $$| $$$$$$$$      | $$      | $$| $$| $$$$$$$$| $$  \ $$  | $$    | $$$$$$$$
| $$    $$| $$  | $$| $$  | $$  | $$ /$$ /$$__  $$  | $$ /$$| $$  | $$      | $$  | $$| $$_____/      | $$    $$| $$| $$| $$_____/| $$  | $$  | $$ /$$| $$_____/
|  $$$$$$/|  $$$$$$/| $$  | $$  |  $$$$/|  $$$$$$$  |  $$$$/|  $$$$$$/      |  $$$$$$$|  $$$$$$$      |  $$$$$$/| $$| $$|  $$$$$$$| $$  | $$  |  $$$$/|  $$$$$$$
 \______/  \______/ |__/  |__/   \___/   \_______/   \___/   \______/        \_______/ \_______/       \______/ |__/|__/ \_______/|__/  |__/   \___/   \_______/");
    }


    private readonly AgendaService _agendaService;

    public Menu(AgendaService agendaService)
    {
        _agendaService = agendaService;
    }

    public void ExibirMenu()
    {
        
        while (true)
        {
            Console.Clear();
            ExibirLogo();
    
            Console.WriteLine($"\n");
            Console.WriteLine("1. Adicionar Contato");
            Console.WriteLine("2. Listar Contatos");
            Console.WriteLine("3. Buscar Contato");
            Console.WriteLine("4. Sair");

            string? opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    _agendaService.AdicionarContato();
                    break;

                case "2":
                    var contatos = _agendaService.ObterTodos();

                    Console.Clear();

                    if (contatos.Count == 0)
                        Console.WriteLine("Nenhum contato cadastrado.");
                    else
                        foreach (var contato in contatos)
                        Console.WriteLine(contato.Informacao);
                    break;

                case "4":
                    return;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
  
}
