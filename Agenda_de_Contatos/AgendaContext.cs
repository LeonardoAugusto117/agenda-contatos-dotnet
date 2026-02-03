using Microsoft.EntityFrameworkCore;
using Agenda_de_Contatos.Models;

public class AgendaContext : DbContext
{
    public DbSet<Contato> Contatos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseNpgsql(
            "Host=localhost;Port=5432;Database=agenda_db;Username=postgres;Password=@erponline2019"
        );
    }



}
