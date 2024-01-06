using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShortTerm.Web.Data.Migrations
{
    public partial class clientContacts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContactPersonId",
                table: "Clients");

            migrationBuilder.AddColumn<string>(
                name: "ContactPersonName",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ContactPersonNumber",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1234-7896-9587-283f579e4764",
                column: "ConcurrencyStamp",
                value: "0842b03a-2ec8-44c8-b485-06b7e1d37771");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1728-44eb-1995-283f579e4764",
                column: "ConcurrencyStamp",
                value: "529c6b8e-dc06-4fc6-8122-1b43f47935f1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73ad90b0-4238-44eb-9587-283f579e4764",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5c1ca64f-38d8-47f9-895b-0890dd0e8725", "AQAAAAEAACcQAAAAEFOht1m+URp9BzIRSxF4lTGMxBRV9TeOpranxvRtvXI3NIBn2DJbvG+ClpI6JmRl+g==", "98d1ab8a-012b-4c3d-9a73-9c135bbb69bc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e18dc662-c956-45fc-a834-63128024ce27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f44eae24-e459-4411-a5f7-acfa5f330990", "AQAAAAEAACcQAAAAEA8t0wNSFrNMycCJKfajfkP1A8Cko/svFisQ2RN+Irs647z3Xfx/46uBnxgE2dc1wg==", "d9b54602-464f-4aaa-87a5-74950782af8f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContactPersonName",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "ContactPersonNumber",
                table: "Clients");

            migrationBuilder.AddColumn<int>(
                name: "ContactPersonId",
                table: "Clients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1234-7896-9587-283f579e4764",
                column: "ConcurrencyStamp",
                value: "385f4774-b251-4910-84e9-2b0e4c142670");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1728-44eb-1995-283f579e4764",
                column: "ConcurrencyStamp",
                value: "bf42f908-3634-43ce-bb8f-5ce53d2703d6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73ad90b0-4238-44eb-9587-283f579e4764",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8da3dd8a-c978-4ae3-8e3b-56a8e5f34e8f", "AQAAAAEAACcQAAAAED8pxRV9g9EOk9pN5uF17joz2Ee3GYAzZK7VVc+I8hJgq1xw1cTzUz5CuEJWy/25nQ==", "6c267c78-baff-4072-92ef-c73790330939" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e18dc662-c956-45fc-a834-63128024ce27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "43159cf9-d6bd-4828-9366-767769c93641", "AQAAAAEAACcQAAAAEEABGfr7bPKukg1WNFHtc3nsSEkojkmf+if9hE1k4ieUBckEF2p+mVBHAlDfIeIq5A==", "bb333201-a39b-45b3-8c65-fcd07c598cdc" });
        }
    }
}
