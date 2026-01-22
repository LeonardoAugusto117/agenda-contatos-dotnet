class AgendaService

{

    private ContatoRepository _contatoRepository;

    public AgendaService(ContatoRepository repo)
    {
        _contatoRepository = repo;
    }

    public void AdicionarContato()
    {
        Console.Clear();
        ExibirTituloDaOpcao("Cadastrar Contato");
      
        Console.WriteLine("Digite o nome do contato: ");
        string nome = Console.ReadLine() ?? string.Empty;

        Console.WriteLine("Digite o telefone do contato: ");
        string telefone = Console.ReadLine() ?? string.Empty;

        Console.WriteLine("Digite o email do contato: ");
        string email = Console.ReadLine() ?? string.Empty;


        //Implementar condição para o cadastro
        if (string.IsNullOrWhiteSpace(nome) ||
            string.IsNullOrWhiteSpace(telefone) ||
            string.IsNullOrWhiteSpace(email))
        {
            Console.WriteLine("\nTodos os campos são obrigatórios. Tente novamente.\n");
            return;
        }else if (!email.Contains("@"))
        {
            Console.WriteLine("\nEmail inválido. Tente novamente.\n");
            return;
        }else if (telefone.Length < 8)
        {
            Console.WriteLine("\nTelefone inválido. Tente novamente.\n");
            return;
        }else if (_contatoRepository.Equals(email))
        {
            Console.WriteLine("\nJá existe um contato com esse email. Tente novamente.\n");
            return;
        }


        Contato novoContato = new Contato
            {
                Nome = nome,
                Telefone = telefone,
                Email = email
            };

        // AQUI está o ponto principal:
        _contatoRepository.Adicionar(novoContato);

        Console.WriteLine("\nContato adicionado com sucesso!\n");

    }

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



}