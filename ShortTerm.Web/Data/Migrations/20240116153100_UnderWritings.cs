using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShortTerm.Web.Data.Migrations
{
    public partial class UnderWritings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UnderWritings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    PolicyId = table.Column<int>(type: "int", nullable: false),
                    ClientProposedValueOfAsset = table.Column<double>(type: "float", nullable: false),
                    StateOfProperty = table.Column<int>(type: "int", nullable: false),
                    LocationOfProperty = table.Column<int>(type: "int", nullable: false),
                    SecurityOfPropertyScore = table.Column<int>(type: "int", nullable: false),
                    PrimaryUseOfPropertyScore = table.Column<int>(type: "int", nullable: false),
                    AdditionalNotes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnderWritings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UnderWritings_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UnderWritings_Policies_PolicyId",
                        column: x => x.PolicyId,
                        principalTable: "Policies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1234-7896-9587-283f579e4764",
                column: "ConcurrencyStamp",
                value: "aec4639e-e1f5-42b1-aa29-0314252356bb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1728-44eb-1995-283f579e4764",
                column: "ConcurrencyStamp",
                value: "5a770e17-f570-4f59-8caa-41b327bc7c3e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73ad90b0-4238-44eb-9587-283f579e4764",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cec06f30-5109-4f53-8507-a3c200e53fd0", "AQAAAAEAACcQAAAAENGVxsZfojDxYmu3goNmPSHEF4NkizlJoSZelrVv1dAsUscpLcVF6pqrgZjFJgS4IA==", "b86e10fe-90c3-4d7e-aea0-46ed7cc6c7f5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e18dc662-c956-45fc-a834-63128024ce27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b7c16d3-d7d2-4e94-b7e0-6a72ec073ba4", "AQAAAAEAACcQAAAAEOOe88ot26G74i7uZZzI8SSGYG1wi8h3RXW+3HVBzTFC2XCYYQ0WsbRN/JUjERd8kQ==", "94018d4f-3066-4ce5-9d16-320f69b2aaeb" });

            migrationBuilder.CreateIndex(
                name: "IX_UnderWritings_ClientId",
                table: "UnderWritings",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_UnderWritings_PolicyId",
                table: "UnderWritings",
                column: "PolicyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UnderWritings");

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
        }
    }
}
