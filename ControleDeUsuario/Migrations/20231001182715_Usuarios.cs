using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ControleDeUsuario.Migrations
{
    /// <inheritdoc />
    public partial class Usuarios : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ControleUsuarios",
                columns: table => new
                {
                    pessoaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pessoaNome = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    pessoaEmail = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    pessoaTelefone = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    pessoaDataNascimento = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ControleUsuarios", x => x.pessoaID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ControleUsuarios");
        }
    }
}
