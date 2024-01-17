using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShortTerm.Web.Data.Migrations
{
    public partial class ReassuranceTypesonReassurer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ReassuranceType",
                table: "Reassurers",
                newName: "ReassuranceTypeId");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1234-7896-9587-283f579e4764",
                column: "ConcurrencyStamp",
                value: "ffa86576-b404-4e6e-bf3c-99098ecf6c85");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1728-44eb-1995-283f579e4764",
                column: "ConcurrencyStamp",
                value: "38e9e5e8-ce0c-4187-be9a-545200d33f4f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73ad90b0-4238-44eb-9587-283f579e4764",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d7a50b0-978d-4c1d-a102-dbca256f0108", "AQAAAAEAACcQAAAAEMexc/IwJpqSzuZi8XoiqTrirZyJ4v65SMbMJFP0JZ7LNVuTXIj6LAlga7o2XTKegA==", "768f50d0-d6cd-429d-aa08-aa8048dfeb64" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e18dc662-c956-45fc-a834-63128024ce27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "798d9139-9a11-4a78-a206-bcd35231263b", "AQAAAAEAACcQAAAAEAIiHtP+xuJmDDwMi2MBWLJ203M18vG5WdhECYFnPuDVU5wrbeY64TZKF6fEeSbQDA==", "eae68398-d811-4879-9092-88a0db88ce58" });

            migrationBuilder.CreateIndex(
                name: "IX_Reassurers_ReassuranceTypeId",
                table: "Reassurers",
                column: "ReassuranceTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reassurers_ReassuranceTypes_ReassuranceTypeId",
                table: "Reassurers",
                column: "ReassuranceTypeId",
                principalTable: "ReassuranceTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reassurers_ReassuranceTypes_ReassuranceTypeId",
                table: "Reassurers");

            migrationBuilder.DropIndex(
                name: "IX_Reassurers_ReassuranceTypeId",
                table: "Reassurers");

            migrationBuilder.RenameColumn(
                name: "ReassuranceTypeId",
                table: "Reassurers",
                newName: "ReassuranceType");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1234-7896-9587-283f579e4764",
                column: "ConcurrencyStamp",
                value: "d39bb513-089b-467a-ae5c-8e6fe33ac5f6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1728-44eb-1995-283f579e4764",
                column: "ConcurrencyStamp",
                value: "07677ae6-7187-4f9a-8c1e-14b99c0db40d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73ad90b0-4238-44eb-9587-283f579e4764",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9015c1df-34a5-42da-8c84-1db31d1a9f00", "AQAAAAEAACcQAAAAEHkAB4Mo+XcVmD3ysAgnA5axNhBvIMpHmB7JXn1GlkpIbqgmtZlyP5u+sc1j6gsQIg==", "df27bb71-fe51-48d1-88a2-06fb6279c37d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e18dc662-c956-45fc-a834-63128024ce27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b35cfc53-0109-4af1-80ce-abfeadaa03fc", "AQAAAAEAACcQAAAAEKSPV7tol9XKsYj0/0ReA7R8phsSIgBGBVVsxL2GZ0SabTGqwxNSTWtNlOIe6xl1Ag==", "cacc3fc4-cda1-483a-8223-4752c98bf0a4" });
        }
    }
}
