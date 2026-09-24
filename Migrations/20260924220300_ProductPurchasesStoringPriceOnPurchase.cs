using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unstore.Migrations
{
    /// <inheritdoc />
    public partial class ProductPurchasesStoringPriceOnPurchase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "PriceOnPurchase",
                table: "ProductPurchases",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PriceOnPurchase",
                table: "ProductPurchases");
        }
    }
}
