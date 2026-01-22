class ContatoRepository
{
    private List<Contato> contatos = new List<Contato>();
    public void Adicionar(Contato contato)
    {
        contatos.Add(contato);
    }
    public List<Contato> Listar()
    {
        return contatos;
    }

    public Contato? BuscarPorNome(string nome)
    {
        return contatos.FirstOrDefault(c => c.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
    }

    public bool ExisteEmail(string email)
    {
        return contatos.Any(c => c.Email.Equals(email, StringComparison.OrdinalIgnoreCase));
    }


    //Buscar contato por nome
   void BuscarContatoPorNome(string nome)
    {
        Console.Write("Digite o nome do contato que deseja buscar: ");
        string nomeBusca = Console.ReadLine() ?? string.Empty;
        
        foreach (var contato in contatos)
        {
            if (contato.Nome.Equals(nomeBusca, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Contato encontrado:");
                Console.WriteLine(contato.Informacao);
                return;
            }else {
                Console.WriteLine("Contato não encontrado.");
            }

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