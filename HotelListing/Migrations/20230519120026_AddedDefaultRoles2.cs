using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelListing.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultRoles2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "132aba0b-fd4f-48ae-8507-c6388920fc63");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "56df214c-cb9f-4415-93b5-bc24aad6bbf9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1ae8b9cf-9f0e-455c-9092-e068335852ac", "4a2e5aa7-afff-4ef4-a7c2-faa3ed4ed24f", "Administrator", "ADMINISTRATOR" },
                    { "50defbfd-9dea-45dd-86de-9c4d99226fe0", "bc88973a-0786-4644-a014-87e511807082", "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1ae8b9cf-9f0e-455c-9092-e068335852ac");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "50defbfd-9dea-45dd-86de-9c4d99226fe0");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "132aba0b-fd4f-48ae-8507-c6388920fc63", "595b7d5c-d506-4f6f-89c0-47deda3d0f6b", "User", "NAME" },
                    { "56df214c-cb9f-4415-93b5-bc24aad6bbf9", "9419fa6d-60c8-4a9f-ad51-16d0ad1faf67", "Administrator", "ADMINISTRATOR" }
                });
        }
    }
}
