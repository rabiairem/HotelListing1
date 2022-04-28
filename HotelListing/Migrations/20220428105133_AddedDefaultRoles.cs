using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelListing.Migrations
{
    public partial class AddedDefaultRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9eb5e27e-bf57-4f98-a891-6614cb8bb434");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "befe54dd-fb95-4640-ada4-485d4ef77437");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "285a4262-4e2c-4ba3-9070-783095dbc18d", "5bbf023f-7336-4341-b538-3031e419c771", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b2b93da5-fd2d-4ce7-aad0-9f34c035be05", "38a81b59-9f8b-43c3-8d22-8c6f2057dbc1", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "285a4262-4e2c-4ba3-9070-783095dbc18d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b2b93da5-fd2d-4ce7-aad0-9f34c035be05");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9eb5e27e-bf57-4f98-a891-6614cb8bb434", "11142411-4679-48c0-8b06-8b824a21a1fb", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "befe54dd-fb95-4640-ada4-485d4ef77437", "0393fcb8-90e8-45a7-af6f-a72458b3b37d", "User", "USER" });
        }
    }
}
