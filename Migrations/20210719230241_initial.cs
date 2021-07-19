using Microsoft.EntityFrameworkCore.Migrations;

namespace lista_de_computadores.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Computador",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    marca = table.Column<string>(type: "TEXT", nullable: true),
                    modelo = table.Column<string>(type: "TEXT", nullable: true),
                    placa_mae = table.Column<string>(type: "TEXT", nullable: true),
                    ram = table.Column<string>(type: "TEXT", nullable: true),
                    hdEMarca = table.Column<string>(type: "TEXT", nullable: true),
                    velocidadeDoProcessador = table.Column<string>(type: "TEXT", nullable: true),
                    imagem = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Computador", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "Computador",
                columns: new[] { "id", "hdEMarca", "imagem", "marca", "modelo", "placa_mae", "ram", "velocidadeDoProcessador" },
                values: new object[] { 2, "500gb SeaGate", "generico", "Compaq", "Compaq", "3354288", "generico", "generico" });

            migrationBuilder.InsertData(
                table: "Computador",
                columns: new[] { "id", "hdEMarca", "imagem", "marca", "modelo", "placa_mae", "ram", "velocidadeDoProcessador" },
                values: new object[] { 3, "generico", "generico", "IBM", "Antonia", "55668899", "generico", "generico" });

            migrationBuilder.InsertData(
                table: "Computador",
                columns: new[] { "id", "hdEMarca", "imagem", "marca", "modelo", "placa_mae", "ram", "velocidadeDoProcessador" },
                values: new object[] { 4, "generico", "generico", "Dell", "Maria", "6565659", "generico", "generico" });

            migrationBuilder.InsertData(
                table: "Computador",
                columns: new[] { "id", "hdEMarca", "imagem", "marca", "modelo", "placa_mae", "ram", "velocidadeDoProcessador" },
                values: new object[] { 5, "generico", "generico", "SAMSUNG", "Machado", "565685415", "generico", "generico" });

            migrationBuilder.InsertData(
                table: "Computador",
                columns: new[] { "id", "hdEMarca", "imagem", "marca", "modelo", "placa_mae", "ram", "velocidadeDoProcessador" },
                values: new object[] { 6, "generico", "generico", "Toshiba", "Alvares", "456454545", "generico", "generico" });

            migrationBuilder.InsertData(
                table: "Computador",
                columns: new[] { "id", "hdEMarca", "imagem", "marca", "modelo", "placa_mae", "ram", "velocidadeDoProcessador" },
                values: new object[] { 7, "generico", "generico", "Positivo", "José", "9874512", "generico", "generico" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Computador");
        }
    }
}
