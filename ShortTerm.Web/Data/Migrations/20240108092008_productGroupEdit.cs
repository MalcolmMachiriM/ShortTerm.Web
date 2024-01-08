using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShortTerm.Web.Data.Migrations
{
    public partial class productGroupEdit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "ProductGroups",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1234-7896-9587-283f579e4764",
                column: "ConcurrencyStamp",
                value: "ca6eb06d-8da0-46b8-94e5-53cb6234db23");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1728-44eb-1995-283f579e4764",
                column: "ConcurrencyStamp",
                value: "efb90c4b-5b7a-49f4-8128-081f6f9fb1b4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73ad90b0-4238-44eb-9587-283f579e4764",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d1c9ddc9-1bd9-49d5-9681-e15a154ae602", "AQAAAAEAACcQAAAAEFIEz0s85zoVoMjdQ6cJZlAlQIMgQRVKZ1zyMYzPDO6j7cuxD0zGO8zaMJGec2MBOA==", "3737e541-5f0f-402f-9075-a0b52ebfe469" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e18dc662-c956-45fc-a834-63128024ce27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3a240662-37d2-441d-b4a8-389174914518", "AQAAAAEAACcQAAAAEFcbIOmNTNBdzk/iV2mQDSGJ7SbrDyfMSdX55PrwmKJWFCz2sJEwJLGCrGUybb+o1g==", "53ac004c-7ad1-4c93-bd8e-6c8786b35641" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "ProductGroups",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1234-7896-9587-283f579e4764",
                column: "ConcurrencyStamp",
                value: "6cc2b768-b983-45d9-a71e-518f031fa9c5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1728-44eb-1995-283f579e4764",
                column: "ConcurrencyStamp",
                value: "fe494f79-33f2-4408-a945-6023f6b15c3f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73ad90b0-4238-44eb-9587-283f579e4764",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "25b7c3e3-538b-4a6f-8427-e3bbc40848aa", "AQAAAAEAACcQAAAAEG/ciTWQvO7whC9cegj8fJ5CBu5PeDpIEHxUHZHdP2ZPYw0AskBG4tlUz2mAFWe8GQ==", "e9bde9c7-e953-4b1a-a816-5a839647198a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e18dc662-c956-45fc-a834-63128024ce27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "982cde9d-7981-4d9e-b102-de0708c0f3ea", "AQAAAAEAACcQAAAAEGhb5Ltuy1bLg7rU+aUZdikGdH0u0TRTOeKROPWewKleXzFA6ufoSaArpYRlNDGiKg==", "648932ee-7f9f-4b31-895f-7c31d9385ff0" });
        }
    }
}
