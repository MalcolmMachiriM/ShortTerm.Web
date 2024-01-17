using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShortTerm.Web.Data.Migrations
{
    public partial class approvePolicy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Approved",
                table: "Policies",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1234-7896-9587-283f579e4764",
                column: "ConcurrencyStamp",
                value: "312da12b-ffd8-475a-8288-f225a97a915d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1728-44eb-1995-283f579e4764",
                column: "ConcurrencyStamp",
                value: "5476154f-03f3-4f96-be86-bc285978cbf9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73ad90b0-4238-44eb-9587-283f579e4764",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7bb1c2aa-cdef-4b2f-a5b6-707aee925f82", "AQAAAAEAACcQAAAAEHGKkuwV/HuwjsL1JVo6ySixB79G1ZcFlLUUhtnALf/+kd1ue6FKbaufaaeFi+qOeA==", "88340419-f00c-4c24-95c3-dd91db27d2c9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e18dc662-c956-45fc-a834-63128024ce27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "064c0604-83c4-4592-83d0-b2bceb0693f7", "AQAAAAEAACcQAAAAELskgZq+Sxvfvz5YWcmM5Z74duxKQhZuRI7yqEvpyh5Pd+mHAzNOSgOqXHwOt0F0vA==", "db586b49-5ffa-4d8b-8c42-09d7e6c93e06" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Approved",
                table: "Policies",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

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
        }
    }
}
