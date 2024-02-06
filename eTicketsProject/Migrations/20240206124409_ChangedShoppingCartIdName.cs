using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTicketsProject.Migrations
{
    /// <inheritdoc />
    public partial class ChangedShoppingCartIdName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ShoppingCart",
                table: "ShoppingCartItems",
                newName: "ShoppingCartId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ShoppingCartId",
                table: "ShoppingCartItems",
                newName: "ShoppingCart");
        }
    }
}
