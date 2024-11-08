using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sign_in_and_Sign_Up.Migrations
{
    /// <inheritdoc />
    public partial class AddCustomerIDToShowtimeSeats : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerID",
                table: "ShowtimeSeats",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerID",
                table: "ShowtimeSeats");
        }
    }
}
