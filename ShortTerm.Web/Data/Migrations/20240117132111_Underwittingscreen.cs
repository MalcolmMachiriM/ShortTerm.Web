using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShortTerm.Web.Data.Migrations
{
    public partial class Underwittingscreen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LocationOfProperty",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationOfProperty", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PrimaryUseOfPropertyScore",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrimaryUseOfPropertyScore", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SecurityOfPropertyScore",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecurityOfPropertyScore", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StateOfProperty",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StateOfProperty", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1234-7896-9587-283f579e4764",
                column: "ConcurrencyStamp",
                value: "5a304d8b-7464-4bd3-8bf2-b9f94a66f3a4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1728-44eb-1995-283f579e4764",
                column: "ConcurrencyStamp",
                value: "21a5deb6-ae1d-4971-97f3-638d101cf23c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73ad90b0-4238-44eb-9587-283f579e4764",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "90515217-da96-4902-a035-b3d280ef904e", "AQAAAAEAACcQAAAAEKcsiG6bT7k44/pZDEjtjuAqz2s56hlo/+SSTewdwzb5VJVhfk7biIHyKNwt8noYAA==", "4c34f14c-651e-4a49-a62d-718302b8965a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e18dc662-c956-45fc-a834-63128024ce27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fa4f62c9-aa81-41e2-8ed1-fd5c8f38f6e0", "AQAAAAEAACcQAAAAEG/THs0oAypT+HJmuAWDNJLW5DXI3atW6nCAo0EhUsi6fdBLl0WO36hsmGNWCkarSw==", "677a521f-e98d-42c1-b5ad-27616a9cb7d2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LocationOfProperty");

            migrationBuilder.DropTable(
                name: "PrimaryUseOfPropertyScore");

            migrationBuilder.DropTable(
                name: "SecurityOfPropertyScore");

            migrationBuilder.DropTable(
                name: "StateOfProperty");

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
        }
    }
}
