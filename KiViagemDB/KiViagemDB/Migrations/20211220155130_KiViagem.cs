using Microsoft.EntityFrameworkCore.Migrations;

namespace KiViagemDB.Migrations
{
    public partial class KiViagem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Destinos",
                columns: table => new
                {
                    DestinoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Valor = table.Column<float>(type: "real", nullable: false),
                    Pais = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destinos", x => x.DestinoId);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    ClienteID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Idade = table.Column<int>(type: "int", nullable: false),
                    DestinoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.ClienteID);
                    table.ForeignKey(
                        name: "FK_Clientes_Destinos_DestinoId",
                        column: x => x.DestinoId,
                        principalTable: "Destinos",
                        principalColumn: "DestinoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "promos",
                columns: table => new
                {
                    PromoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomePromo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PorcentagemDesc = table.Column<int>(type: "int", nullable: false),
                    ClienteID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_promos", x => x.PromoId);
                    table.ForeignKey(
                        name: "FK_promos_Clientes_ClienteID",
                        column: x => x.ClienteID,
                        principalTable: "Clientes",
                        principalColumn: "ClienteID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Compras",
                columns: table => new
                {
                    CompraId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteID = table.Column<int>(type: "int", nullable: true),
                    DestinoId = table.Column<int>(type: "int", nullable: true),
                    PromoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compras", x => x.CompraId);
                    table.ForeignKey(
                        name: "FK_Compras_Clientes_ClienteID",
                        column: x => x.ClienteID,
                        principalTable: "Clientes",
                        principalColumn: "ClienteID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Compras_Destinos_DestinoId",
                        column: x => x.DestinoId,
                        principalTable: "Destinos",
                        principalColumn: "DestinoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Compras_promos_PromoId",
                        column: x => x.PromoId,
                        principalTable: "promos",
                        principalColumn: "PromoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_DestinoId",
                table: "Clientes",
                column: "DestinoId");

            migrationBuilder.CreateIndex(
                name: "IX_Compras_ClienteID",
                table: "Compras",
                column: "ClienteID");

            migrationBuilder.CreateIndex(
                name: "IX_Compras_DestinoId",
                table: "Compras",
                column: "DestinoId");

            migrationBuilder.CreateIndex(
                name: "IX_Compras_PromoId",
                table: "Compras",
                column: "PromoId");

            migrationBuilder.CreateIndex(
                name: "IX_promos_ClienteID",
                table: "promos",
                column: "ClienteID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Compras");

            migrationBuilder.DropTable(
                name: "promos");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Destinos");
        }
    }
}
