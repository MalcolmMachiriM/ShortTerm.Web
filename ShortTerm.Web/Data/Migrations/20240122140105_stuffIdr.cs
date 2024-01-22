using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShortTerm.Web.Data.Migrations
{
    public partial class stuffIdr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1234-7896-9587-283f579e4764",
                column: "ConcurrencyStamp",
                value: "4ec97c2a-f6bd-4fea-b365-3e9da2d676b2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1728-44eb-1995-283f579e4764",
                column: "ConcurrencyStamp",
                value: "c1572a7a-ea6d-4c1b-9a6d-aacbbfcebbe6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73ad90b0-4238-44eb-9587-283f579e4764",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8e923ed1-e8db-4b7d-b80a-a3ae9de927cc", "AQAAAAEAACcQAAAAED/jXvO5DWkw33BHhKHjji+eoF9GWGT+vGLwjF0qKnbkt0lEkfw8wTn8iuiGk8Gb3g==", "6dcb2f03-00c9-42a1-b65f-1f8e204ad5dd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e18dc662-c956-45fc-a834-63128024ce27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0715c5bb-2cbe-46a7-bcfa-088383ee1071", "AQAAAAEAACcQAAAAEN3IewELevJhbvVr9MIJHldwfFL0acNmLN0hCjSNS2dfBSpvkCcK37V/yYciVDgXoA==", "0cc32f50-4d7f-4873-ba1c-0b51c3b655ad" });

            migrationBuilder.CreateIndex(
                name: "IX_PolicyReassurances_PolicyId",
                table: "PolicyReassurances",
                column: "PolicyId");

            migrationBuilder.AddForeignKey(
                name: "FK_PolicyReassurances_Policies_PolicyId",
                table: "PolicyReassurances",
                column: "PolicyId",
                principalTable: "Policies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PolicyReassurances_Policies_PolicyId",
                table: "PolicyReassurances");

            migrationBuilder.DropIndex(
                name: "IX_PolicyReassurances_PolicyId",
                table: "PolicyReassurances");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1234-7896-9587-283f579e4764",
                column: "ConcurrencyStamp",
                value: "ddd25abb-5ad8-4f16-b63c-d1c0d20d023c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1728-44eb-1995-283f579e4764",
                column: "ConcurrencyStamp",
                value: "fccec2da-51b6-4d61-a3a1-b127da91d29b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73ad90b0-4238-44eb-9587-283f579e4764",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "874e7e7a-ff1b-4a66-822d-2ccd9ee97229", "AQAAAAEAACcQAAAAEMcJwfaohNumCXJJwfqsxolGFYRdsLNlMev0taOTZOvkTaqIxL2d+z4WP52wv77l6Q==", "dd05e9a8-4852-42c2-9205-fcf48cda9956" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e18dc662-c956-45fc-a834-63128024ce27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "34b067e1-0120-4564-9024-65acd5134d07", "AQAAAAEAACcQAAAAEBU01QVohlCgERpGD3KsE50+mZCFrui8T9U6L8yopd0UMw0vfg6c7NHEo3U6Fg/xHQ==", "c07cc368-94ea-447f-9215-148b3e5dade0" });
        }
    }
}
