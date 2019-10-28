using Microsoft.EntityFrameworkCore.Migrations;

namespace iNewmann.Web.Data.Migrations
{
    public partial class recno : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_generalledgers",
                table: "generalledgers");

            migrationBuilder.AddColumn<long>(
                name: "Recno",
                table: "generalledgers",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_generalledgers",
                table: "generalledgers",
                column: "Recno");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_generalledgers",
                table: "generalledgers");

            migrationBuilder.DropColumn(
                name: "Recno",
                table: "generalledgers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_generalledgers",
                table: "generalledgers",
                column: "Id");
        }
    }
}
