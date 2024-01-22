using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShortTerm.Web.Data.Migrations
{
    public partial class PolicyReassurance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PolicyReassurances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PolicyId = table.Column<int>(type: "int", nullable: false),
                    SumAssured = table.Column<double>(type: "float", nullable: false),
                    ReassurerId = table.Column<int>(type: "int", nullable: true),
                    ReasurerId = table.Column<int>(type: "int", nullable: false),
                    ReassuranceTypeId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PolicyReassurances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PolicyReassurances_ReassuranceTypes_ReassuranceTypeId",
                        column: x => x.ReassuranceTypeId,
                        principalTable: "ReassuranceTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PolicyReassurances_Reassurers_ReassurerId",
                        column: x => x.ReassurerId,
                        principalTable: "Reassurers",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1234-7896-9587-283f579e4764",
                column: "ConcurrencyStamp",
                value: "ed86ee00-60ad-49ae-9bbd-760d8235f7d8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1728-44eb-1995-283f579e4764",
                column: "ConcurrencyStamp",
                value: "a3ea75f0-2f0a-46b9-bd00-d9f90e569d78");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73ad90b0-4238-44eb-9587-283f579e4764",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da03085f-9d37-4c55-92ff-11c98795e196", "AQAAAAEAACcQAAAAEGcxH0WN78DjkMAxD/bLT13mRPi1elhRRIlkg1zzjAXhkCyvwJzqbu79jbv/65Rv1g==", "f477c73b-752c-493f-af98-9287c46a4037" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e18dc662-c956-45fc-a834-63128024ce27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b9bc9c3-b344-419a-88fc-3387b0198af2", "AQAAAAEAACcQAAAAEO4e+C6woOfks8C2hKd2uJa0doHs73bZ9NnVYU/vxaX40dn+EYda77VbD9tdxeCszw==", "e5cc59c9-5c2d-4c0f-9b78-d33b6cf47bc7" });

            migrationBuilder.CreateIndex(
                name: "IX_PolicyReassurances_ReassuranceTypeId",
                table: "PolicyReassurances",
                column: "ReassuranceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PolicyReassurances_ReassurerId",
                table: "PolicyReassurances",
                column: "ReassurerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PolicyReassurances");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1234-7896-9587-283f579e4764",
                column: "ConcurrencyStamp",
                value: "faa58a86-b2b4-4cc5-bfbf-93da85b59c83");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1728-44eb-1995-283f579e4764",
                column: "ConcurrencyStamp",
                value: "3a90b9dd-f053-45a5-b684-1d1306ca2c6c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73ad90b0-4238-44eb-9587-283f579e4764",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "229effe8-c588-46fc-960b-d2eb3bcf84d0", "AQAAAAEAACcQAAAAEPnf6Y6WUP0wAhgfUqLBdIMshVZrDu1nQ+PIzBTEEPlEB8GZVKKrX1m78uNYdSF/aQ==", "df1bc98d-a5f0-4b9b-8152-8af952a12ae5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e18dc662-c956-45fc-a834-63128024ce27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "13ea9bd0-3b16-4563-935b-4669bdb22f08", "AQAAAAEAACcQAAAAEIxko5hxXpJW9mTi0rJRtqwKYVQbXYGf5ucea8NeviKe8nm2ezGPYaVBTgqT7yYaAw==", "4f859a0c-1393-46b8-98a1-be3253330f10" });
        }
    }
}
