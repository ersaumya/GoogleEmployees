using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GoogleEmployees.Migrations
{
    public partial class AddedRolesToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "382c9bab-84f9-4ffa-9af0-89a6257c7713", "ebf3fa34-5902-43f9-9267-5abac8c80776", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f781f267-5232-4cca-97e0-10830b83faca", "d923f30d-b786-4612-ad15-afca518b8a9d", "Manager", "MANAGER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "382c9bab-84f9-4ffa-9af0-89a6257c7713");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f781f267-5232-4cca-97e0-10830b83faca");
        }
    }
}
