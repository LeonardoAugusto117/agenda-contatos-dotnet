using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Agenda_de_Contatos.Migrations
{
    /// <inheritdoc />
    public partial class AddNovoCampoAtivo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "Contatos",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "Contatos");
        }
    }
}
