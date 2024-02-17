using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BUS_TICKIT_BOOKING_API.Migrations
{
    /// <inheritdoc />
    public partial class nariya : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "bustickitbooking",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    P_Name = table.Column<string>(type: "text", nullable: false),
                    P_Age = table.Column<int>(type: "integer", nullable: false),
                    P_Xender = table.Column<string>(type: "text", nullable: false),
                    B_Name = table.Column<string>(type: "text", nullable: false),
                    B_No = table.Column<int>(type: "integer", nullable: false),
                    Set_No = table.Column<string>(type: "text", nullable: false),
                    B_Pickuppoint = table.Column<string>(type: "text", nullable: false),
                    B_Dropingpoint = table.Column<string>(type: "text", nullable: false),
                    B_Booking_DateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Price = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bustickitbooking", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bustickitbooking");
        }
    }
}
