using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace LivrariaMinsait.Migrations
{
    /// <inheritdoc />
    public partial class ArrayAutorMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Livro",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Titulo = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    SubTitulo = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Resumo = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    QtdePaginas = table.Column<int>(type: "integer", nullable: false),
                    DataPublicacao = table.Column<string>(type: "text", nullable: false),
                    Editora = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    Edicao = table.Column<int>(type: "integer", nullable: true),
                    Autor = table.Column<List<string>>(type: "text[]", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Livro", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Livro");
        }
    }
}
