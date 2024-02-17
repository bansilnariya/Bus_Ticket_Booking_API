using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BUS_TICKIT_BOOKING_API.Migrations
{
    /// <inheritdoc />
    public partial class bansil : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Set_No",
                table: "bustickitbooking",
                newName: "set_No");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "bustickitbooking",
                newName: "price");

            migrationBuilder.RenameColumn(
                name: "P_Xender",
                table: "bustickitbooking",
                newName: "p_Xender");

            migrationBuilder.RenameColumn(
                name: "P_Name",
                table: "bustickitbooking",
                newName: "p_Name");

            migrationBuilder.RenameColumn(
                name: "P_Age",
                table: "bustickitbooking",
                newName: "p_Age");

            migrationBuilder.RenameColumn(
                name: "B_Pickuppoint",
                table: "bustickitbooking",
                newName: "b_Pickuppoint");

            migrationBuilder.RenameColumn(
                name: "B_No",
                table: "bustickitbooking",
                newName: "b_No");

            migrationBuilder.RenameColumn(
                name: "B_Name",
                table: "bustickitbooking",
                newName: "b_Name");

            migrationBuilder.RenameColumn(
                name: "B_Dropingpoint",
                table: "bustickitbooking",
                newName: "b_Dropingpoint");

            migrationBuilder.RenameColumn(
                name: "B_Booking_DateTime",
                table: "bustickitbooking",
                newName: "b_Booking_DateTime");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "bustickitbooking",
                newName: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "set_No",
                table: "bustickitbooking",
                newName: "Set_No");

            migrationBuilder.RenameColumn(
                name: "price",
                table: "bustickitbooking",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "p_Xender",
                table: "bustickitbooking",
                newName: "P_Xender");

            migrationBuilder.RenameColumn(
                name: "p_Name",
                table: "bustickitbooking",
                newName: "P_Name");

            migrationBuilder.RenameColumn(
                name: "p_Age",
                table: "bustickitbooking",
                newName: "P_Age");

            migrationBuilder.RenameColumn(
                name: "b_Pickuppoint",
                table: "bustickitbooking",
                newName: "B_Pickuppoint");

            migrationBuilder.RenameColumn(
                name: "b_No",
                table: "bustickitbooking",
                newName: "B_No");

            migrationBuilder.RenameColumn(
                name: "b_Name",
                table: "bustickitbooking",
                newName: "B_Name");

            migrationBuilder.RenameColumn(
                name: "b_Dropingpoint",
                table: "bustickitbooking",
                newName: "B_Dropingpoint");

            migrationBuilder.RenameColumn(
                name: "b_Booking_DateTime",
                table: "bustickitbooking",
                newName: "B_Booking_DateTime");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "bustickitbooking",
                newName: "Id");
        }
    }
}
