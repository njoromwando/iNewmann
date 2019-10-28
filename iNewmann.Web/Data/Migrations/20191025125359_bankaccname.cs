using Microsoft.EntityFrameworkCore.Migrations;

namespace iNewmann.Web.Data.Migrations
{
    public partial class bankaccname : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BankAccountname",
                table: "suppliers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BankAccountname",
                table: "suppliers");
        }
    }
}
