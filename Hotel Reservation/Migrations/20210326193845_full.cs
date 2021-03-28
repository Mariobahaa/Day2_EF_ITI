using Microsoft.EntityFrameworkCore.Migrations;

namespace Hotel_Reservation.Migrations
{
    public partial class full : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Frontend",
                columns: table => new
                {
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PassWord = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Frontend", x => x.UserName);
                });

            migrationBuilder.CreateTable(
                name: "Kitchens",
                columns: table => new
                {
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PassWord = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kitchens", x => x.UserName);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Frontend");

            migrationBuilder.DropTable(
                name: "Kitchens");
        }
    }
}
