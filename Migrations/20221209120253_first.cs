using Microsoft.EntityFrameworkCore.Migrations;

namespace ekz2.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customerrr",
                columns: table => new
                {
                    cnum = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sname = table.Column<string>(nullable: true),
                    city = table.Column<string>(nullable: true),
                    comm = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customerrr", x => x.cnum);
                });

            migrationBuilder.CreateTable(
                name: "Diagnosisss",
                columns: table => new
                {
                    dnum = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sname = table.Column<string>(nullable: true),
                    city = table.Column<string>(nullable: true),
                    comm = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diagnosisss", x => x.dnum);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customerrr");

            migrationBuilder.DropTable(
                name: "Diagnosisss");
        }
    }
}
