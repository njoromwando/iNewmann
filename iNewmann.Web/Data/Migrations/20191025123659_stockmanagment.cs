using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace iNewmann.Web.Data.Migrations
{
    public partial class stockmanagment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "COAGroups",
                columns: table => new
                {
                    GroupCode = table.Column<string>(nullable: true),
                    SubGroupCode = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "coas",
                columns: table => new
                {
                    AccountCode = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    AccountGroup = table.Column<string>(nullable: true),
                    AccountSubGroup = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "InvoiceItems",
                columns: table => new
                {
                    Recno = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true),
                    InvoiceNo = table.Column<string>(nullable: true),
                    ProductCode = table.Column<string>(nullable: true),
                    Quantity = table.Column<decimal>(nullable: false),
                    UnitPrice = table.Column<decimal>(nullable: false),
                    Total = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceItems", x => x.Recno);
                });

            migrationBuilder.CreateTable(
                name: "invoices",
                columns: table => new
                {
                    Recno = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true),
                    InvoiceNo = table.Column<string>(nullable: true),
                    SupplierCode = table.Column<string>(nullable: true),
                    Total = table.Column<string>(nullable: true),
                    InvoiceDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_invoices", x => x.Recno);
                });

            migrationBuilder.CreateTable(
                name: "stockControls",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true),
                    ProductCode = table.Column<string>(nullable: true),
                    ProductIn = table.Column<decimal>(nullable: false),
                    ProductOut = table.Column<decimal>(nullable: false),
                    Narration = table.Column<string>(nullable: true),
                    InvoiceNo = table.Column<string>(nullable: true),
                    MyProperty = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stockControls", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "suppliers",
                columns: table => new
                {
                    Recno = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Bank = table.Column<string>(nullable: true),
                    BankBranch = table.Column<string>(nullable: true),
                    BankAccountNo = table.Column<string>(nullable: true),
                    AccountNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_suppliers", x => x.Recno);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "COAGroups");

            migrationBuilder.DropTable(
                name: "coas");

            migrationBuilder.DropTable(
                name: "InvoiceItems");

            migrationBuilder.DropTable(
                name: "invoices");

            migrationBuilder.DropTable(
                name: "stockControls");

            migrationBuilder.DropTable(
                name: "suppliers");
        }
    }
}
