using Agenda_de_Contatos.Models;
internal class Program
{
    private static void Main(string[] args)
    {
        AgendaContext context = new AgendaContext();
        ContatoRepository contatoRepository = new ContatoRepository(context);
        AgendaService agendaService = new AgendaService(contatoRepository);

        Menu menu = new Menu(agendaService);
        menu.ExibirMenu();

    }
}