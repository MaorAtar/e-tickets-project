using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTicketsProject.Migrations
{
    /// <inheritdoc />
    public partial class ChangedOrderItemAmountField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Amout",
                table: "OrderItems",
                newName: "Amount");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Amount",
                table: "OrderItems",
                newName: "Amout");
        }
    }
}
