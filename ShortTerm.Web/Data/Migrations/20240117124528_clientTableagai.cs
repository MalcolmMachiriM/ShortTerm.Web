using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShortTerm.Web.Data.Migrations
{
    public partial class clientTableagai : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Language",
                table: "Clients",
                newName: "ReligionsId");

            migrationBuilder.AddColumn<int>(
                name: "CountriesId",
                table: "Clients",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LanguageId",
                table: "Clients",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1234-7896-9587-283f579e4764",
                column: "ConcurrencyStamp",
                value: "1a6c268e-b814-4fab-941a-f0f1fc0c4491");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1728-44eb-1995-283f579e4764",
                column: "ConcurrencyStamp",
                value: "429dc1c4-f253-45a3-b45f-4162f69fcf07");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73ad90b0-4238-44eb-9587-283f579e4764",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f646320-c005-4b1d-8c67-fe75763c522e", "AQAAAAEAACcQAAAAECUPZLv4uGHul/b0euC8FIqCyPEIwAyuwre2qCKxqC7i8z+oFmxfCQVfpAbGjXkZSw==", "0f056e06-712a-4145-85f0-543fe6a7930a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e18dc662-c956-45fc-a834-63128024ce27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f140f8ce-c27e-4162-9ad7-a96efeea6802", "AQAAAAEAACcQAAAAEBmtxKs94xZ/X4iaxUTY352ORKI8NxR6Sa52p77tlnDz8Ygt9HLYbOlmHeurfN7sig==", "96ccf089-5e16-4d5f-9682-b3873ecd6bd8" });

            migrationBuilder.CreateIndex(
                name: "IX_Clients_CountriesId",
                table: "Clients",
                column: "CountriesId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_IncomeGroupId",
                table: "Clients",
                column: "IncomeGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_LanguageId",
                table: "Clients",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_ReligionsId",
                table: "Clients",
                column: "ReligionsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Countries_CountriesId",
                table: "Clients",
                column: "CountriesId",
                principalTable: "Countries",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_IncomeTypes_IncomeGroupId",
                table: "Clients",
                column: "IncomeGroupId",
                principalTable: "IncomeTypes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Languages_LanguageId",
                table: "Clients",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Religions_ReligionsId",
                table: "Clients",
                column: "ReligionsId",
                principalTable: "Religions_1",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Countries_CountriesId",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_Clients_IncomeTypes_IncomeGroupId",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Languages_LanguageId",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Religions_ReligionsId",
                table: "Clients");

            migrationBuilder.DropIndex(
                name: "IX_Clients_CountriesId",
                table: "Clients");

            migrationBuilder.DropIndex(
                name: "IX_Clients_IncomeGroupId",
                table: "Clients");

            migrationBuilder.DropIndex(
                name: "IX_Clients_LanguageId",
                table: "Clients");

            migrationBuilder.DropIndex(
                name: "IX_Clients_ReligionsId",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "CountriesId",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "LanguageId",
                table: "Clients");

            migrationBuilder.RenameColumn(
                name: "ReligionsId",
                table: "Clients",
                newName: "Language");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1234-7896-9587-283f579e4764",
                column: "ConcurrencyStamp",
                value: "1976f759-40d1-4a76-9d91-b3db5439e11b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1728-44eb-1995-283f579e4764",
                column: "ConcurrencyStamp",
                value: "b0b5adaf-cfb2-4da6-bf9d-ba667d047de4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73ad90b0-4238-44eb-9587-283f579e4764",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0e218af8-0554-47f6-9237-78b6af0a37f6", "AQAAAAEAACcQAAAAEOUlCwpvpKCMjq3BwRqMBHppQ9d8Sm9QVLLesNqEc5xNfaVFGjA+XmKZUPgUh3dqFQ==", "585bffb7-1a12-47aa-a70d-de49b56a6f3e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e18dc662-c956-45fc-a834-63128024ce27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a28ea7ff-54c3-443a-8a68-7aa8d75433c5", "AQAAAAEAACcQAAAAEBukjM7Kz9zh44CRucHvZmuD5XlB4OSNHNdDrembI064LQGQtJI9/ps5CXUGtVilAw==", "2ad6ea2b-50c4-4c58-987c-ec5678191cef" });
        }
    }
}
