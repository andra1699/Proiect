using Microsoft.EntityFrameworkCore.Migrations;

namespace Proiect.Migrations
{
    public partial class hello : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Laptop",
                type: "decimal(6, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<int>(
                name: "BrandID",
                table: "Laptop",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "Laptop",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Brand",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brand", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Laptop_BrandID",
                table: "Laptop",
                column: "BrandID");

            migrationBuilder.CreateIndex(
                name: "IX_Laptop_CategoryID",
                table: "Laptop",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Laptop_Brand_BrandID",
                table: "Laptop",
                column: "BrandID",
                principalTable: "Brand",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Laptop_Category_CategoryID",
                table: "Laptop",
                column: "CategoryID",
                principalTable: "Category",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Laptop_Brand_BrandID",
                table: "Laptop");

            migrationBuilder.DropForeignKey(
                name: "FK_Laptop_Category_CategoryID",
                table: "Laptop");

            migrationBuilder.DropTable(
                name: "Brand");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropIndex(
                name: "IX_Laptop_BrandID",
                table: "Laptop");

            migrationBuilder.DropIndex(
                name: "IX_Laptop_CategoryID",
                table: "Laptop");

            migrationBuilder.DropColumn(
                name: "BrandID",
                table: "Laptop");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "Laptop");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Laptop",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(6, 2)");
        }
    }
}
