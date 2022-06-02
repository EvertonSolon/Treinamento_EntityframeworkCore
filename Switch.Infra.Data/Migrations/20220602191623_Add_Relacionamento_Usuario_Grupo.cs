using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Switch.Infra.Data.Migrations
{
    public partial class Add_Relacionamento_Usuario_Grupo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Texto",
                table: "Postagens",
                type: "nvarchar(400)",
                maxLength: 400,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "GrupoId",
                table: "Postagens",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Grupos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UrlFoto = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grupos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UsuariosGrupos",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    GrupoId = table.Column<int>(type: "int", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Administrador = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuariosGrupos", x => new { x.UsuarioId, x.GrupoId });
                    table.ForeignKey(
                        name: "FK_UsuariosGrupos_Grupos_GrupoId",
                        column: x => x.GrupoId,
                        principalTable: "Grupos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsuariosGrupos_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Postagens_GrupoId",
                table: "Postagens",
                column: "GrupoId");

            migrationBuilder.CreateIndex(
                name: "IX_UsuariosGrupos_GrupoId",
                table: "UsuariosGrupos",
                column: "GrupoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Postagens_Grupos_GrupoId",
                table: "Postagens",
                column: "GrupoId",
                principalTable: "Grupos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Postagens_Grupos_GrupoId",
                table: "Postagens");

            migrationBuilder.DropTable(
                name: "UsuariosGrupos");

            migrationBuilder.DropTable(
                name: "Grupos");

            migrationBuilder.DropIndex(
                name: "IX_Postagens_GrupoId",
                table: "Postagens");

            migrationBuilder.DropColumn(
                name: "GrupoId",
                table: "Postagens");

            migrationBuilder.AlterColumn<string>(
                name: "Texto",
                table: "Postagens",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(400)",
                oldMaxLength: 400);
        }
    }
}
