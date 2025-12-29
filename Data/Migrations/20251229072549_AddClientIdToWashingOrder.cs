using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mvcrud.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddClientIdToWashingOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "WashingOrders",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "WashingOrders");
        }
    }
}
