namespace Agenda_de_Contatos.Models;

public class Contato
{
    public int Id { get; set; } // PRIMARY KEY

    public string Nome { get; set; }
    public string Telefone { get; set; }
    public string Email { get; set; }

    public string Informacao =>
        $"|| Nome: {Nome} || Telefone: {Telefone} || Email: {Email} ||";
}
