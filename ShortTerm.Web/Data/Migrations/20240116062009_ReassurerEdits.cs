using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShortTerm.Web.Data.Migrations
{
    public partial class ReassurerEdits : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClientFullname",
                table: "Reassurers");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "Reassurers");

            migrationBuilder.DropColumn(
                name: "ContractType",
                table: "Reassurers");

            migrationBuilder.DropColumn(
                name: "Manager",
                table: "Reassurers");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ContractStartDate",
                table: "Reassurers",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ContractEndDate",
                table: "Reassurers",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "Reassurers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ReassuranceType",
                table: "Reassurers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1234-7896-9587-283f579e4764",
                column: "ConcurrencyStamp",
                value: "6388521d-e6b5-4cea-8c84-6656b6e54553");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1728-44eb-1995-283f579e4764",
                column: "ConcurrencyStamp",
                value: "f5f433aa-3ec9-4762-8f96-9db75590d236");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73ad90b0-4238-44eb-9587-283f579e4764",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "35eb8ed3-89a9-4537-b00e-91b9fe1669b5", "AQAAAAEAACcQAAAAEMhS2/D85Bwtex1pRAedQsZsG7SX0c5k+E6P2YTZ53q0OjoU2AFfxnrKown2qmmxCw==", "091baebc-9c34-4271-8dd2-08e82aaf8aa5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e18dc662-c956-45fc-a834-63128024ce27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9f61c97e-911a-4c10-a4c0-6365ca8b5e5e", "AQAAAAEAACcQAAAAEDTR9hnrnJY7547IrfHGcj4e4fU7n0hAcHCWKORXtjtL8DOWsZfJuYUht6+nclefBw==", "9b30f9b4-0980-4649-9896-833d06c9554c" });

            migrationBuilder.CreateIndex(
                name: "IX_Reassurers_ClientId",
                table: "Reassurers",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reassurers_Clients_ClientId",
                table: "Reassurers",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reassurers_Clients_ClientId",
                table: "Reassurers");

            migrationBuilder.DropIndex(
                name: "IX_Reassurers_ClientId",
                table: "Reassurers");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Reassurers");

            migrationBuilder.DropColumn(
                name: "ReassuranceType",
                table: "Reassurers");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ContractStartDate",
                table: "Reassurers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ContractEndDate",
                table: "Reassurers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClientFullname",
                table: "Reassurers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Reassurers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ContractType",
                table: "Reassurers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Manager",
                table: "Reassurers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
    }
}
