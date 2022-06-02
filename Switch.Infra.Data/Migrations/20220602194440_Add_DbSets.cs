using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Switch.Infra.Data.Migrations
{
    public partial class Add_DbSets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Identificacao_Usuarios_UsuarioId",
                table: "Identificacao");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Identificacao",
                table: "Identificacao");

            migrationBuilder.RenameTable(
                name: "Identificacao",
                newName: "Identificacoes");

            migrationBuilder.RenameIndex(
                name: "IX_Identificacao_UsuarioId",
                table: "Identificacoes",
                newName: "IX_Identificacoes_UsuarioId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Identificacoes",
                table: "Identificacoes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Identificacoes_Usuarios_UsuarioId",
                table: "Identificacoes",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Identificacoes_Usuarios_UsuarioId",
                table: "Identificacoes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Identificacoes",
                table: "Identificacoes");

            migrationBuilder.RenameTable(
                name: "Identificacoes",
                newName: "Identificacao");

            migrationBuilder.RenameIndex(
                name: "IX_Identificacoes_UsuarioId",
                table: "Identificacao",
                newName: "IX_Identificacao_UsuarioId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Identificacao",
                table: "Identificacao",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Identificacao_Usuarios_UsuarioId",
                table: "Identificacao",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
