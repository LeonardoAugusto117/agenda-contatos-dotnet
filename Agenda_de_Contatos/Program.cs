ContatoRepository contatoRepository = new ContatoRepository();
AgendaService agendaService = new AgendaService(contatoRepository);

Menu menu = new Menu(agendaService);
menu.ExibirMenu();
