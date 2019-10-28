using Microsoft.EntityFrameworkCore.Migrations;

namespace iNewmann.Web.Data.Migrations
{
    public partial class stockcontrol : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_stockControls",
                table: "stockControls");

            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "stockControls");

            migrationBuilder.AddColumn<long>(
                name: "Recno",
                table: "stockControls",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "Docid",
                table: "stockControls",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Docno",
                table: "stockControls",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SupplierCode",
                table: "stockControls",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_stockControls",
                table: "stockControls",
                column: "Recno");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_stockControls",
                table: "stockControls");

            migrationBuilder.DropColumn(
                name: "Recno",
                table: "stockControls");

            migrationBuilder.DropColumn(
                name: "Docid",
                table: "stockControls");

            migrationBuilder.DropColumn(
                name: "Docno",
                table: "stockControls");

            migrationBuilder.DropColumn(
                name: "SupplierCode",
                table: "stockControls");

            migrationBuilder.AddColumn<string>(
                name: "MyProperty",
                table: "stockControls",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_stockControls",
                table: "stockControls",
                column: "Id");
        }
    }
}
