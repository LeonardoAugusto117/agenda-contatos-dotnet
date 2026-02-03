using Agenda_de_Contatos.Models;
class ContatoRepository
{
    private readonly AgendaContext _context;

    public ContatoRepository(AgendaContext context)
    {
        _context = context;
    }

    public void Adicionar(Contato contato)
    {
        _context.Contatos.Add(contato);
        _context.SaveChanges();
    }

    public List<Contato> Listar()
    {
        return _context.Contatos.ToList();
    }

    public Contato? BuscarPorNome(string nome)
    {
        return _context.Contatos
            .FirstOrDefault(c => c.Nome.ToLower() == nome.ToLower());
    }

    public bool ExisteEmail(string email)
    {
        return _context.Contatos
            .Any(c => c.Email.ToLower() == email.ToLower());
    }

    public bool RemoverPorNome(string nome)
    {
        var contato = _context.Contatos
            .FirstOrDefault(c => c.Nome.ToLower() == nome.ToLower());

        if (contato == null)
            return false;

        _context.Contatos.Remove(contato);
        _context.SaveChanges();
        return true;
    }
}
