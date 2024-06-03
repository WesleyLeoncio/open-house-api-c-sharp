using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace open_house_api_c_sharp.Migrations
{
    /// <inheritdoc />
    public partial class Create_tables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categorias",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    nome = table.Column<string>(type: "VARCHAR(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categorias", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "filmes",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    nome = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    descricao = table.Column<string>(type: "TEXT", nullable: true),
                    data_lancamento = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    duracao = table.Column<string>(type: "VARCHAR(30)", nullable: true),
                    imagem = table.Column<string>(type: "VARCHAR(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_filmes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CategoriaFilme",
                columns: table => new
                {
                    CategoriasId = table.Column<Guid>(type: "uuid", nullable: false),
                    FilmesId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriaFilme", x => new { x.CategoriasId, x.FilmesId });
                    table.ForeignKey(
                        name: "FK_CategoriaFilme_categorias_CategoriasId",
                        column: x => x.CategoriasId,
                        principalTable: "categorias",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoriaFilme_filmes_FilmesId",
                        column: x => x.FilmesId,
                        principalTable: "filmes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoriaFilme_FilmesId",
                table: "CategoriaFilme",
                column: "FilmesId");

            migrationBuilder.CreateIndex(
                name: "IX_categorias_nome",
                table: "categorias",
                column: "nome",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_filmes_nome",
                table: "filmes",
                column: "nome",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoriaFilme");

            migrationBuilder.DropTable(
                name: "categorias");

            migrationBuilder.DropTable(
                name: "filmes");
        }
    }
}
