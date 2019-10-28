using Microsoft.EntityFrameworkCore.Migrations;

namespace iNewmann.Web.Data.Migrations
{
    public partial class productsupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_products",
                table: "products");

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "products",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(4)");

            migrationBuilder.AddColumn<int>(
                name: "Recno",
                table: "products",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_products",
                table: "products",
                column: "Recno");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_products",
                table: "products");

            migrationBuilder.DropColumn(
                name: "Recno",
                table: "products");

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "products",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_products",
                table: "products",
                column: "Code");
        }
    }
}
