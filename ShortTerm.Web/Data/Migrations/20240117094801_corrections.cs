using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShortTerm.Web.Data.Migrations
{
    public partial class corrections : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_Titles_1_Clients_ClientId",
            //    table: "Titles_1");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_Titles_1_Policies_PolicyId",
            //    table: "Titles_1");

            //migrationBuilder.DropColumn(
            //    name: "QuestionDescription",
            //    table: "UnderWritings");

            //migrationBuilder.DropColumn(
            //    name: "QuestionType",
            //    table: "UnderWritings");

            //migrationBuilder.DropColumn(
            //    name: "ClientId",
            //    table: "Titles_1");

            //migrationBuilder.DropColumn(
            //    name: "PolicyId",
            //    table: "Titles_1");

            migrationBuilder.AlterColumn<double>(
                name: "ClientProposedValueOfAsset",
                table: "UnderWritings",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            //migrationBuilder.AddColumn<DateTime>(
            //    name: "DateCreated",
            //    table: "UnderWritings",
            //    type: "datetime2",
            //    nullable: false,
            //    defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            //migrationBuilder.AddColumn<int>(
            //    name: "PrimaryUseOfPropertyScore",
            //    table: "UnderWritings",
            //    type: "int",
            //    nullable: false,
            //    defaultValue: 0);

            //migrationBuilder.CreateTable(
            //    name: "UnderwritingQuestions",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        QuestionType = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        QuestionDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_UnderwritingQuestions", x => x.Id);
            //    });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1234-7896-9587-283f579e4764",
                column: "ConcurrencyStamp",
                value: "6c231d1d-d21b-4330-ab1f-1b340983f541");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1728-44eb-1995-283f579e4764",
                column: "ConcurrencyStamp",
                value: "cde40b2c-1e66-437c-8dda-4253c2184b21");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73ad90b0-4238-44eb-9587-283f579e4764",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6dfd6942-6cfd-4c7b-8e45-4338760e1b6f", "AQAAAAEAACcQAAAAEObajGjXRlKJgBdmWcr5KJsjo0MT1cbRaFWzYF9Br9frqVXT9KKpVzlueIQZJE5xvA==", "7df6d79f-a8b4-42ad-a247-942d84d7d566" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e18dc662-c956-45fc-a834-63128024ce27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "811c2660-8a97-4a7a-bd2a-5972c1a30bce", "AQAAAAEAACcQAAAAEFse5BjuV89E9BTblCSp+ryQ52TR9sJzPgFF9sjUaglMudCoH2zMRP/4SNC5DvnOkQ==", "45d0323d-04d0-4085-b352-17a952fe126a" });

            //migrationBuilder.CreateIndex(
            //    name: "IX_UnderWritings_ClientId",
            //    table: "UnderWritings",
            //    column: "ClientId");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_UnderWritings_Clients_ClientId",
            //    table: "UnderWritings",
            //    column: "ClientId",
            //    principalTable: "Clients",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_UnderWritings_Policies_PolicyId",
            //    table: "UnderWritings",
            //    column: "PolicyId",
            //    principalTable: "Policies",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UnderWritings_Clients_ClientId",
                table: "UnderWritings");

            migrationBuilder.DropForeignKey(
                name: "FK_UnderWritings_Policies_PolicyId",
                table: "UnderWritings");

            migrationBuilder.DropTable(
                name: "UnderwritingQuestions");

            migrationBuilder.DropIndex(
                name: "IX_UnderWritings_ClientId",
                table: "UnderWritings");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "UnderWritings");

            migrationBuilder.DropColumn(
                name: "PrimaryUseOfPropertyScore",
                table: "UnderWritings");

            migrationBuilder.AlterColumn<int>(
                name: "ClientProposedValueOfAsset",
                table: "UnderWritings",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddColumn<string>(
                name: "QuestionDescription",
                table: "UnderWritings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "QuestionType",
                table: "UnderWritings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "Titles_1",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PolicyId",
                table: "Titles_1",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1234-7896-9587-283f579e4764",
                column: "ConcurrencyStamp",
                value: "02d6aed8-9e91-4077-be3e-24e0dd8f2c3f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1728-44eb-1995-283f579e4764",
                column: "ConcurrencyStamp",
                value: "90bd09be-27b3-40eb-8eea-1f68ad3cfade");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73ad90b0-4238-44eb-9587-283f579e4764",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "343cacee-be13-4263-b9d8-688d2ca14bbc", "AQAAAAEAACcQAAAAECJ0NY1fHjototGUFSj+r5A/6VwchtnCV+Mj+70wpLLFR9BGoSJBifgP0qVmyEPOKQ==", "2d99a5c1-11e3-498c-afd8-d5da49c9ea5a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e18dc662-c956-45fc-a834-63128024ce27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bff67d7a-b1a9-40e0-a686-9d2c20157385", "AQAAAAEAACcQAAAAEK0hSeM09EHOe/RdLrTO47y/Q8EfjkeOKHKTkEW4QwijrymSqB56idbQhmfbJmzZ7w==", "51d0394d-0fdc-409f-bb50-79009a3b3f5d" });

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_1_Clients_ClientId",
                table: "Titles_1",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_1_Policies_PolicyId",
                table: "Titles_1",
                column: "PolicyId",
                principalTable: "Policies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
