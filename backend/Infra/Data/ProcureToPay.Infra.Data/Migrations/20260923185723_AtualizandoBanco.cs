using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ProcureToPay.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class AtualizandoBanco : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    usuario_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    usuario_nome = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    usuario_email = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    usuario_cpf = table.Column<string>(type: "character varying(11)", maxLength: 11, nullable: false),
                    usuario_senha_hash = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    usuario_ativo = table.Column<bool>(type: "boolean", nullable: false),
                    usuario_data_criacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_usuario_id", x => x.usuario_id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
