using Microsoft.EntityFrameworkCore.Migrations;

namespace iNewmann.Web.Data.Migrations
{
    public partial class codegenerators : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "products",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "codeGenerators",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category = table.Column<string>(nullable: true),
                    Seed = table.Column<int>(nullable: false),
                    Prefix = table.Column<string>(nullable: true),
                    Surfix = table.Column<string>(nullable: true),
                    CurrentNumber = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_codeGenerators", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "codeGenerators");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "products");
        }
    }
}
