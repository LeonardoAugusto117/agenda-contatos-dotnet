class AgendaService

{
    // Repositorio de contatos
    private ContatoRepository _contatoRepository;

    public AgendaService(ContatoRepository repo)
    {
        _contatoRepository = repo;
    }

    // Adiciona um novo contato na lista
    public void AdicionarContato()
    {
        Console.Clear();
        ExibirTituloDaOpcao("Cadastrar Contato");

        var opcao = "1";

        while (opcao == "1")
        {
            Console.Write("Digite o nome do contato: ");
            string nome = Console.ReadLine() ?? string.Empty;

            if (string.IsNullOrWhiteSpace(nome))
            {
                Console.WriteLine("\nNome não pode ser vazio!");
                PerguntarNovamente(ref opcao);
                continue;
            }

            Console.Write("Digite o telefone do contato: ");
            string telefone = Console.ReadLine() ?? string.Empty;

            if (telefone.Length < 11)
            {
                Console.WriteLine("\nTelefone inválido. Deve conter DDD + número.");
                PerguntarNovamente(ref opcao);
                continue;
            }

            Console.Write("Digite o email do contato: ");
            string email = Console.ReadLine() ?? string.Empty;

            if (!email.Contains("@"))
            {
                Console.WriteLine("\nEmail inválido. Necessário incluir o '@' no email");
                PerguntarNovamente(ref opcao);
                continue;
            }

            if (_contatoRepository.ExisteEmail(email))
            {
                Console.WriteLine("\nJá existe um contato com esse email.");
                PerguntarNovamente(ref opcao);
                continue;
            }

            Contato novoContato = new Contato
            {
                Nome = nome,
                Telefone = telefone,
                Email = email
            };

            _contatoRepository.Adicionar(novoContato);

            Console.WriteLine("\nContato cadastrado com sucesso!");
            Console.WriteLine("Deseja cadastrar outro contato?");
            Console.WriteLine("1 - Sim / 2 - Não");

            opcao = Console.ReadLine() ?? "2";
            Console.Clear();
        }
    }

    // Referencia a lista para que outra classe consiga visualizar os contatos
    public List<Contato> ObterTodos()
    {
        return _contatoRepository.Listar();
    }

    void ExibirTituloDaOpcao(string titulo)
    {
        // Colocar o asteriscos do tamanho da frase
        int quantidadeDeLetras = titulo.Length;
        string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
        Console.WriteLine(asteriscos);
        Console.WriteLine(titulo);
        Console.WriteLine(asteriscos + "\n");
    }

    private void PerguntarNovamente(ref string opcao)
    {
        Console.WriteLine();
        Console.WriteLine("Deseja refazer o cadastro?");
        Console.WriteLine("1 - Sim / 2 - Não");
        opcao = Console.ReadLine() ?? "2";
        Console.Clear();
    }

}