using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShortTerm.Web.Data.Migrations
{
    public partial class UnderwritingTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StateOfProperty",
                table: "UnderWritings",
                newName: "StateOfPropertyId");

            migrationBuilder.RenameColumn(
                name: "SecurityOfPropertyScore",
                table: "UnderWritings",
                newName: "SecurityOfPropertyScoreId");

            migrationBuilder.RenameColumn(
                name: "PrimaryUseOfPropertyScore",
                table: "UnderWritings",
                newName: "PrimaryUseOfPropertyScoreId");

            migrationBuilder.RenameColumn(
                name: "LocationOfProperty",
                table: "UnderWritings",
                newName: "LocationOfPropertyId");

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
                name: "IX_UnderWritings_LocationOfPropertyId",
                table: "UnderWritings",
                column: "LocationOfPropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_UnderWritings_PrimaryUseOfPropertyScoreId",
                table: "UnderWritings",
                column: "PrimaryUseOfPropertyScoreId");

            migrationBuilder.CreateIndex(
                name: "IX_UnderWritings_SecurityOfPropertyScoreId",
                table: "UnderWritings",
                column: "SecurityOfPropertyScoreId");

            migrationBuilder.CreateIndex(
                name: "IX_UnderWritings_StateOfPropertyId",
                table: "UnderWritings",
                column: "StateOfPropertyId");

            migrationBuilder.AddForeignKey(
                name: "FK_UnderWritings_LocationOfProperty_LocationOfPropertyId",
                table: "UnderWritings",
                column: "LocationOfPropertyId",
                principalTable: "LocationOfProperty",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UnderWritings_PrimaryUseOfPropertyScore_PrimaryUseOfPropertyScoreId",
                table: "UnderWritings",
                column: "PrimaryUseOfPropertyScoreId",
                principalTable: "PrimaryUseOfPropertyScore",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UnderWritings_SecurityOfPropertyScore_SecurityOfPropertyScoreId",
                table: "UnderWritings",
                column: "SecurityOfPropertyScoreId",
                principalTable: "SecurityOfPropertyScore",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UnderWritings_StateOfProperty_StateOfPropertyId",
                table: "UnderWritings",
                column: "StateOfPropertyId",
                principalTable: "StateOfProperty",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UnderWritings_LocationOfProperty_LocationOfPropertyId",
                table: "UnderWritings");

            migrationBuilder.DropForeignKey(
                name: "FK_UnderWritings_PrimaryUseOfPropertyScore_PrimaryUseOfPropertyScoreId",
                table: "UnderWritings");

            migrationBuilder.DropForeignKey(
                name: "FK_UnderWritings_SecurityOfPropertyScore_SecurityOfPropertyScoreId",
                table: "UnderWritings");

            migrationBuilder.DropForeignKey(
                name: "FK_UnderWritings_StateOfProperty_StateOfPropertyId",
                table: "UnderWritings");

            migrationBuilder.DropIndex(
                name: "IX_UnderWritings_LocationOfPropertyId",
                table: "UnderWritings");

            migrationBuilder.DropIndex(
                name: "IX_UnderWritings_PrimaryUseOfPropertyScoreId",
                table: "UnderWritings");

            migrationBuilder.DropIndex(
                name: "IX_UnderWritings_SecurityOfPropertyScoreId",
                table: "UnderWritings");

            migrationBuilder.DropIndex(
                name: "IX_UnderWritings_StateOfPropertyId",
                table: "UnderWritings");

            migrationBuilder.RenameColumn(
                name: "StateOfPropertyId",
                table: "UnderWritings",
                newName: "StateOfProperty");

            migrationBuilder.RenameColumn(
                name: "SecurityOfPropertyScoreId",
                table: "UnderWritings",
                newName: "SecurityOfPropertyScore");

            migrationBuilder.RenameColumn(
                name: "PrimaryUseOfPropertyScoreId",
                table: "UnderWritings",
                newName: "PrimaryUseOfPropertyScore");

            migrationBuilder.RenameColumn(
                name: "LocationOfPropertyId",
                table: "UnderWritings",
                newName: "LocationOfProperty");

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
    }
}
