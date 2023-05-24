using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelListing.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "132aba0b-fd4f-48ae-8507-c6388920fc63", "595b7d5c-d506-4f6f-89c0-47deda3d0f6b", "User", "NAME" },
                    { "56df214c-cb9f-4415-93b5-bc24aad6bbf9", "9419fa6d-60c8-4a9f-ad51-16d0ad1faf67", "Administrator", "ADMINISTRATOR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "132aba0b-fd4f-48ae-8507-c6388920fc63");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "56df214c-cb9f-4415-93b5-bc24aad6bbf9");
        }
    }
}
