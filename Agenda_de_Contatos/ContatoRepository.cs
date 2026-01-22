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