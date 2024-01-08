using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShortTerm.Web.Data.Migrations
{
    public partial class policyTableChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_HighestQualifications_HighestQualificationId",
                table: "Clients");

            migrationBuilder.RenameColumn(
                name: "Product",
                table: "Policies",
                newName: "ProductId");

            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "Policies",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "NationalID",
                table: "Policies",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Policies",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "HighestQualificationId",
                table: "Clients",
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
                value: "08c69ab8-c477-4aaa-a85b-5945faa79702");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1728-44eb-1995-283f579e4764",
                column: "ConcurrencyStamp",
                value: "21fe6684-497a-4fd1-9df5-4f17cd82880b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73ad90b0-4238-44eb-9587-283f579e4764",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "df180ea9-9c92-4a2c-8b2c-2b03466b2a70", "AQAAAAEAACcQAAAAEF/Y7JooSoXcdFNvRgGrIy/vfVctZj04lbwNrOegC0R79bmn6tfQxnaSSv9C3xk6FQ==", "2e85d965-d091-446d-a439-d53246342394" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e18dc662-c956-45fc-a834-63128024ce27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4bde514b-9077-4280-b905-fc274317b4aa", "AQAAAAEAACcQAAAAEM2nxVxDVv+/RvU3rkS9rm2bN1HGCeHwS4EGZtpvZl6sloQG2BBJvuIiyTvZtY5f5A==", "54fbb116-fe48-4c6c-97c3-94921b7ea7f7" });

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_HighestQualifications_HighestQualificationId",
                table: "Clients",
                column: "HighestQualificationId",
                principalTable: "HighestQualifications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Policies_IndividualProducts_ProductGroupId",
                table: "Policies",
                column: "ProductGroupId",
                principalTable: "IndividualProducts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_HighestQualifications_HighestQualificationId",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_Policies_IndividualProducts_ProductGroupId",
                table: "Policies");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "Policies",
                newName: "Product");

            migrationBuilder.AlterColumn<int>(
                name: "Surname",
                table: "Policies",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "NationalID",
                table: "Policies",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FirstName",
                table: "Policies",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "HighestQualificationId",
                table: "Clients",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_HighestQualifications_HighestQualificationId",
                table: "Clients",
                column: "HighestQualificationId",
                principalTable: "HighestQualifications",
                principalColumn: "Id");
        }
    }
}
