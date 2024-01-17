using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShortTerm.Web.Data.Migrations
{
    public partial class PolicyClient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1234-7896-9587-283f579e4764",
                column: "ConcurrencyStamp",
                value: "56c14d62-d1b6-496d-89d5-3205a82f4529");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1728-44eb-1995-283f579e4764",
                column: "ConcurrencyStamp",
                value: "cf3d9f88-7c43-4e82-9409-53d7abe88330");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73ad90b0-4238-44eb-9587-283f579e4764",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bf53360f-248b-47c2-a7cf-04d462d08fe9", "AQAAAAEAACcQAAAAEM8Nys8dnIx/o9dj+EIVtKBmvFSD8QT1GnaHJSKLnhdbSItdz9MGBHB3iAg2wt1ZmQ==", "43f4fcda-a1b2-4e32-819c-d50543c7a740" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e18dc662-c956-45fc-a834-63128024ce27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d653a48e-ca67-49c1-a6d4-6730e6942159", "AQAAAAEAACcQAAAAELSzuMnNfx+U4VH5DJBD7Xk7Mqbb5k5PKnSA6MQg/+6Fbpq9MdXiR8flWHU8a9KGvA==", "a19ee393-d491-491e-a67d-cad5d778d241" });

            migrationBuilder.CreateIndex(
                name: "IX_Policies_ClientId",
                table: "Policies",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Policies_Clients_ClientId",
                table: "Policies",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Policies_Clients_ClientId",
                table: "Policies");

            migrationBuilder.DropIndex(
                name: "IX_Policies_ClientId",
                table: "Policies");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1234-7896-9587-283f579e4764",
                column: "ConcurrencyStamp",
                value: "5e5aa057-dc59-47b1-8f44-f4dd0f63a13d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1728-44eb-1995-283f579e4764",
                column: "ConcurrencyStamp",
                value: "afbb5622-c74b-4b8f-957c-0c3f89581a8f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73ad90b0-4238-44eb-9587-283f579e4764",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f4244d6a-bbb9-469e-86f6-b5d0ef4d8902", "AQAAAAEAACcQAAAAECEAhnkRckBZdXTUeFfjhTzMImgTRa7oaNVVf/NeM1/2L5GanAOokOAubMX0LFlucg==", "cfc627b8-6b02-439a-ba9c-c5d55dc0a99c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e18dc662-c956-45fc-a834-63128024ce27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5b1d2958-c740-4705-8359-525642c15a23", "AQAAAAEAACcQAAAAEKTwgpHoH2J/xG7py40BNyzi6xxrv1fzk7hZcNUnC28P/DDNuo8BdjvgS/G/4Hpfjg==", "bae17c06-88b1-4151-bba9-a92330eeb928" });
        }
    }
}
