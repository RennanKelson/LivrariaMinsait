using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace LivrariaMinsait.Migrations
{
    /// <inheritdoc />
    public partial class PrimeiraMigration : Migration
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
                    SubTitulo = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Resumo = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    QtdePaginas = table.Column<int>(type: "integer", nullable: false),
                    DataPublicacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Editora = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    Edicao = table.Column<int>(type: "integer", nullable: false),
                    Autor = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
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
