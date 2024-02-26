using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShortTerm.Web.Data.Migrations
{
    public partial class PremiumPayments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PremiumPayments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PolicyId = table.Column<int>(type: "int", nullable: false),
                    PaymentMethodId = table.Column<int>(type: "int", nullable: false),
                    BankId = table.Column<int>(type: "int", nullable: true),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PremiumPayments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PremiumPayments_Banks_BankId",
                        column: x => x.BankId,
                        principalTable: "Banks",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PremiumPayments_PaymentMethods_PaymentMethodId",
                        column: x => x.PaymentMethodId,
                        principalTable: "PaymentMethods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PremiumPayments_Policies_PolicyId",
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
                value: "b1966ab6-5b94-4a43-ad02-4939b05c4cb7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1728-44eb-1995-283f579e4764",
                column: "ConcurrencyStamp",
                value: "ccc7a941-7e7c-4328-ba13-36c176df3858");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73ad90b0-4238-44eb-9587-283f579e4764",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b9db9446-6f8a-4b14-be0c-f1fecc27db70", "AQAAAAEAACcQAAAAEJjLnd+o+cuXteKTKnGwyJ/DBDjBh71fwnKx/4sS5IeA+KDo9gDK2VqYdi8d8mFabw==", "3e900831-a13b-4fac-a71d-de3e36f1487a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e18dc662-c956-45fc-a834-63128024ce27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ea8eedb1-ae94-42d9-ac72-96ad8f797d8e", "AQAAAAEAACcQAAAAEBqRAsY8/AYMFkeVPGy7zEsVO5bEGvsKJETpFCGd5QAaNgS8AWRzDRrfA7mqxdoUBQ==", "ae128e4c-0915-43a2-8435-9f5697046ebc" });

            migrationBuilder.CreateIndex(
                name: "IX_PremiumPayments_BankId",
                table: "PremiumPayments",
                column: "BankId");

            migrationBuilder.CreateIndex(
                name: "IX_PremiumPayments_PaymentMethodId",
                table: "PremiumPayments",
                column: "PaymentMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_PremiumPayments_PolicyId",
                table: "PremiumPayments",
                column: "PolicyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PremiumPayments");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1234-7896-9587-283f579e4764",
                column: "ConcurrencyStamp",
                value: "f06998c9-6324-4511-98f1-0c61a3acda8d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1728-44eb-1995-283f579e4764",
                column: "ConcurrencyStamp",
                value: "be84df05-d5b7-4ba5-8ef6-b9ea216d40cc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73ad90b0-4238-44eb-9587-283f579e4764",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7882e39e-6859-414f-bf15-5ff3fcd307c1", "AQAAAAEAACcQAAAAEBUaZH8E1GcBCRNkjkODX8I3uv5YqJqu64xUCi/gPN5nrG11Nf3NbRgqrqLenuf4zA==", "ac119476-85d7-40f4-a960-ab55ac8c236b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e18dc662-c956-45fc-a834-63128024ce27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "09009dd5-ae7e-4cac-8859-ac21fc07761d", "AQAAAAEAACcQAAAAEDgRwd04QhWtX8K/VhRsE/jR0l2lyeOFQaYE5PSkC/OD19IgSZDZ+oWe7XmKWeTQHA==", "6fb50049-41f4-435e-a6e0-3289bc3b305c" });
        }
    }
}
