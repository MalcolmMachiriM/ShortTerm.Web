using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShortTerm.Web.Data.Migrations
{
    public partial class SumAssTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SumAssuredBasis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SumAssuredBase = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SumAssuredBasis", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1234-7896-9587-283f579e4764",
                column: "ConcurrencyStamp",
                value: "db4ca5b2-534d-4a0d-843b-b9fb808a63d4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1728-44eb-1995-283f579e4764",
                column: "ConcurrencyStamp",
                value: "a917eb74-d499-4dd5-8517-739051ece458");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73ad90b0-4238-44eb-9587-283f579e4764",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ec376b61-7692-42e9-b07f-5490553b3345", "AQAAAAEAACcQAAAAELBcI3b1qWBExnT5+MaBZxDcdp2k3EmK9SoovtioJNsjfQqtTtgXuSkZO1r6nbjOlg==", "f2331757-b5f0-4b0e-ac34-bb6c3168166c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e18dc662-c956-45fc-a834-63128024ce27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dbe08b92-530e-4ef7-a08c-0d167d95f8d2", "AQAAAAEAACcQAAAAEALjUIQewOGhw00Flty2RoI/lHtkcNrrd8HiYaRukDXkFWTERh6FezLcouPlkgGHjQ==", "1f6c13ea-0f67-44bb-a8de-d2353dc29b2c" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SumAssuredBasis");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1234-7896-9587-283f579e4764",
                column: "ConcurrencyStamp",
                value: "25df4172-8dc8-4987-a6a5-506a1104e199");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1728-44eb-1995-283f579e4764",
                column: "ConcurrencyStamp",
                value: "eb1afe1b-cf2c-4eb9-b2ad-8c685a883d1e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73ad90b0-4238-44eb-9587-283f579e4764",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "850726d9-c92e-4a33-9d0e-cc083dee9918", "AQAAAAEAACcQAAAAEDMoIh5X7DrNkMNTuBfDbnERkM7NOmw3E86NfF75htiwb0bE+ra0B+z3ZRGWcuErxA==", "4a110a08-8946-4c81-bdbe-c8e12cf7d6e0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e18dc662-c956-45fc-a834-63128024ce27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "723c59cc-07a0-48f8-a973-d346b14010bc", "AQAAAAEAACcQAAAAELDG7pv0270qCfU/3c1ACB2NKGMKpECzvqSofKInDUddL9YIgtpHmbLHXJyzCcJAEg==", "f1d6a4fe-482a-4418-aaad-81961d8ee621" });
        }
    }
}
