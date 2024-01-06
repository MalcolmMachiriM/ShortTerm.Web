using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShortTerm.Web.Data.Migrations
{
    public partial class NewClientFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Languages_LanguageId",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Religions_ReligionId",
                table: "Clients");

            migrationBuilder.DropIndex(
                name: "IX_Clients_LanguageId",
                table: "Clients");

            migrationBuilder.DropIndex(
                name: "IX_Clients_ReligionId",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "CountryOfBirthId",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "CountryOfResidenceId",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "LanguageId",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "ReligionId",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "TitleId",
                table: "Clients");

            migrationBuilder.AlterColumn<string>(
                name: "RegNo",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "NationalId",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "MiddleName",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "IncomeGroupId",
                table: "Clients",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "CountryOfBirth",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CountryOfResidence",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HighestQualificationId",
                table: "Clients",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Language",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Religion",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ClientTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HighestQualifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Qualification = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HighestQualifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Titles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Titles", x => x.Id);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Clients_HighestQualificationId",
                table: "Clients",
                column: "HighestQualificationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_HighestQualifications_HighestQualificationId",
                table: "Clients",
                column: "HighestQualificationId",
                principalTable: "HighestQualifications",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_HighestQualifications_HighestQualificationId",
                table: "Clients");

            migrationBuilder.DropTable(
                name: "ClientTypes");

            migrationBuilder.DropTable(
                name: "HighestQualifications");

            migrationBuilder.DropTable(
                name: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Clients_HighestQualificationId",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "CountryOfBirth",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "CountryOfResidence",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "HighestQualificationId",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "Language",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "Religion",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Clients");

            migrationBuilder.AlterColumn<string>(
                name: "RegNo",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NationalId",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MiddleName",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IncomeGroupId",
                table: "Clients",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CountryOfBirthId",
                table: "Clients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CountryOfResidenceId",
                table: "Clients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LanguageId",
                table: "Clients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ReligionId",
                table: "Clients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TitleId",
                table: "Clients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1234-7896-9587-283f579e4764",
                column: "ConcurrencyStamp",
                value: "0fa35fdc-7ea8-4ba7-8098-a6c48e67bb51");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1728-44eb-1995-283f579e4764",
                column: "ConcurrencyStamp",
                value: "9f446f9a-7cb3-453d-82c9-839324a4bd93");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73ad90b0-4238-44eb-9587-283f579e4764",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "941c6b25-5db9-44e7-9551-4546663bcfe5", "AQAAAAEAACcQAAAAEKnwGJvp0j+redcNWTRcJYAFTQ2HZPcZ9uI54hRyA7VQ6obvPzmrk0MqBJ2j8Nowgw==", "9dd6f9fd-cf2a-494c-b22c-4846ee40de1f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e18dc662-c956-45fc-a834-63128024ce27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "195e7e9d-a9a1-4904-8796-054ae8a2ba54", "AQAAAAEAACcQAAAAEEHqbk/IbZGK5dBXVwcgq3TvVWAhaGbSTcHcTMrTfmrWLVItJEcaNnux8s9iY2Sk8Q==", "43cefa13-3c19-4693-90fe-ba16bf49a9fb" });

            migrationBuilder.CreateIndex(
                name: "IX_Clients_LanguageId",
                table: "Clients",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_ReligionId",
                table: "Clients",
                column: "ReligionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Languages_LanguageId",
                table: "Clients",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Religions_ReligionId",
                table: "Clients",
                column: "ReligionId",
                principalTable: "Religions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
