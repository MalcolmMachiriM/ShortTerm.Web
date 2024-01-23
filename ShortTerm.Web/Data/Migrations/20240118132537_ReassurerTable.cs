using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShortTerm.Web.Data.Migrations
{
    public partial class ReassurerTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reassurers_Clients_ClientId",
                table: "Reassurers");

            migrationBuilder.DropForeignKey(
                name: "FK_Reassurers_ReassuranceTypes_ReassuranceTypeId",
                table: "Reassurers");

            migrationBuilder.DropIndex(
                name: "IX_Reassurers_ClientId",
                table: "Reassurers");

            migrationBuilder.DropIndex(
                name: "IX_Reassurers_ReassuranceTypeId",
                table: "Reassurers");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Reassurers");

            migrationBuilder.DropColumn(
                name: "ContractEndDate",
                table: "Reassurers");

            migrationBuilder.DropColumn(
                name: "ContractStartDate",
                table: "Reassurers");

            migrationBuilder.DropColumn(
                name: "ReassuranceTypeId",
                table: "Reassurers");

            migrationBuilder.AddColumn<string>(
                name: "ContactDetails",
                table: "Reassurers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ContactPerson",
                table: "Reassurers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Reassurers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Reassurers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1234-7896-9587-283f579e4764",
                column: "ConcurrencyStamp",
                value: "e28d874a-d50b-40e1-8f0f-9aa2461ba267");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1728-44eb-1995-283f579e4764",
                column: "ConcurrencyStamp",
                value: "29de0ecd-0888-47a9-8713-b51c6e0d4766");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73ad90b0-4238-44eb-9587-283f579e4764",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d7841e73-bceb-47e4-b89d-f38ea8457fe6", "AQAAAAEAACcQAAAAEIcoTQ/lymB3ISj22t3dBEnpgwW4PegoPT+qObjZ9w8/BXFnpgmaosYb8qjQdqY36Q==", "bb091e9f-2b86-47a5-a961-a10a04b8ee1b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e18dc662-c956-45fc-a834-63128024ce27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3ca4c168-86ef-4bba-8221-2bc164eb3b72", "AQAAAAEAACcQAAAAEOmRHQJrICzUHPbYoUOEOaZyllPX/Ym8dD/5Qit7OelNq07oeIhDv9ExGMd+PaC/QA==", "b894e3f2-2aad-426a-82c2-2cafcec28374" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContactDetails",
                table: "Reassurers");

            migrationBuilder.DropColumn(
                name: "ContactPerson",
                table: "Reassurers");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Reassurers");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Reassurers");

            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "Reassurers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "ContractEndDate",
                table: "Reassurers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ContractStartDate",
                table: "Reassurers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReassuranceTypeId",
                table: "Reassurers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1234-7896-9587-283f579e4764",
                column: "ConcurrencyStamp",
                value: "586a0c3c-ac82-47fe-b908-544dff24456a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1728-44eb-1995-283f579e4764",
                column: "ConcurrencyStamp",
                value: "a6f93ad8-aeaa-4257-9e3b-bbbd8a308e1d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73ad90b0-4238-44eb-9587-283f579e4764",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d7ac20fe-493a-4242-8f5a-85d26ef850de", "AQAAAAEAACcQAAAAEAvAR5a9vIYekaegbEXmUYZr8Ih4xwZYMgytYw8uqxmK4+Ttuir/CfporBc1MyCqxw==", "8b3e3dcb-82f1-4642-9b3e-2d16dd181954" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e18dc662-c956-45fc-a834-63128024ce27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d6938d9a-c3ee-4f87-aa4b-4fe008bc453d", "AQAAAAEAACcQAAAAEIOlnIfW65gP8Y9WTV62PTI0YeOv3SVP8Ybtw2lOLHylnN4D3bRD/no74u2OrGbfJg==", "297d6d02-fcba-4f4e-8bde-14584b1988ec" });

            migrationBuilder.CreateIndex(
                name: "IX_Reassurers_ClientId",
                table: "Reassurers",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Reassurers_ReassuranceTypeId",
                table: "Reassurers",
                column: "ReassuranceTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reassurers_Clients_ClientId",
                table: "Reassurers",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reassurers_ReassuranceTypes_ReassuranceTypeId",
                table: "Reassurers",
                column: "ReassuranceTypeId",
                principalTable: "ReassuranceTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
