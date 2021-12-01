using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcClub.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Player",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Player_number = table.Column<byte>(type: "tinyint", nullable: false),
                    First_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Matches = table.Column<byte>(type: "tinyint", nullable: false),
                    Yellow_cards = table.Column<byte>(type: "tinyint", nullable: false),
                    Red_cards = table.Column<byte>(type: "tinyint", nullable: false),
                    Goal = table.Column<byte>(type: "tinyint", nullable: false),
                    Assist = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Player", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Player");
        }
    }
}
