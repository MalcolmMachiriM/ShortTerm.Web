using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShortTerm.Web.Data.Migrations
{
    public partial class ReassurerStuff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PolicyReassurances_Reassurers_ReassurerId",
                table: "PolicyReassurances");

            migrationBuilder.DropColumn(
                name: "ReasurerId",
                table: "PolicyReassurances");

            migrationBuilder.AlterColumn<int>(
                name: "ReassurerId",
                table: "PolicyReassurances",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1234-7896-9587-283f579e4764",
                column: "ConcurrencyStamp",
                value: "7d4ba881-3d2c-4129-9793-de1dbe6874b0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1728-44eb-1995-283f579e4764",
                column: "ConcurrencyStamp",
                value: "02b92f3f-f253-414e-8c52-8b7f6ca626ea");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73ad90b0-4238-44eb-9587-283f579e4764",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db12daa7-1fd7-4866-8a22-2b27cd94ae42", "AQAAAAEAACcQAAAAEEKgJ1w0Gc7IEXNlcsQwPsdN4Glny7giBKOAH5b8ETYQUwnS+3zJa+WVUtcAbrr39g==", "bbc4ddf7-a1b9-404d-8fc3-e68a524b8108" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e18dc662-c956-45fc-a834-63128024ce27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5365af4c-3a4c-4ad8-8df1-d686f29c3b25", "AQAAAAEAACcQAAAAEF+VdmJ9K8q9GKqiFakdSBNvQUHMWGGbv+AKn4f5IWK5JkAuIXiTQMZvcz6ZqKvYiQ==", "2484303c-013e-4851-a1b0-e35cb17ab01f" });

            migrationBuilder.AddForeignKey(
                name: "FK_PolicyReassurances_Reassurers_ReassurerId",
                table: "PolicyReassurances",
                column: "ReassurerId",
                principalTable: "Reassurers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PolicyReassurances_Reassurers_ReassurerId",
                table: "PolicyReassurances");

            migrationBuilder.AlterColumn<int>(
                name: "ReassurerId",
                table: "PolicyReassurances",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            //migrationBuilder.AddColumn<int>(
            //    name: "ReasurerId",
            //    table: "PolicyReassurances",
            //    type: "int",
            //    nullable: false,
            //    defaultValue: 0);

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

            migrationBuilder.AddForeignKey(
                name: "FK_PolicyReassurances_Reassurers_ReassurerId",
                table: "PolicyReassurances",
                column: "ReassurerId",
                principalTable: "Reassurers",
                principalColumn: "Id");
        }
    }
}
